using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;

namespace Microsoft.Reporting.WinForms
{
    public static class LocalReportExtensions
    {
        
        public static void PrintToPrinter(this LocalReport report, string P)
        {
            string p = P;
            PageSettings pageSettings = new PageSettings();
            pageSettings.PrinterSettings.Copies = 1;
            pageSettings.PaperSize = report.GetDefaultPageSettings().PaperSize;
            pageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape;
            pageSettings.Margins = report.GetDefaultPageSettings().Margins;
            Print(report, pageSettings, p);
        }

        public static void Print(this LocalReport report, PageSettings pageSettings, string Printer)
        {
            string deviceInfo = 
            $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>{pageSettings.PaperSize.Width}in</PageWidth>
                    <PageHeight>{pageSettings.PaperSize.Height}in</PageHeight>
                    <MarginTop>{pageSettings.Margins.Top}in</MarginTop>
                    <MarginLeft>{pageSettings.Margins.Left}in</MarginLeft>
                    <MarginRight>{pageSettings.Margins.Right }in</MarginRight>
                    <MarginBottom>{pageSettings.Margins.Bottom}in</MarginBottom>
                </DeviceInfo>";
            Warning[] warnings;
            var streams = new List<Stream>();
            var pageIndex = 0;
            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    MemoryStream stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);
            foreach (Stream stream in streams)
                stream.Position = 0;
            if (streams == null || streams.Count == 0)
                throw new Exception("No stream to print.");
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PrinterSettings.PrinterName = Printer;
            pd.DefaultPageSettings.Landscape = false; 
            pd.PrintPage += (sender, e) =>
            {
                Metafile pageImage = new Metafile(streams[pageIndex]);
                Rectangle adjustedRect = new Rectangle(e.PageBounds.Left - (int)e.PageSettings.HardMarginX, e.PageBounds.Top - (int)e.PageSettings.HardMarginY, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                e.Graphics.DrawImage(pageImage, adjustedRect);
                pageIndex++;
                e.HasMorePages = (pageIndex < streams.Count);
                e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
            };
            pd.EndPrint += (Sender, e) =>
            {
                if (streams != null)
                {
                    foreach (Stream stream in streams)
                        stream.Close();
                    streams = null;
                }
            };
            pd.Print();
        }
                
            
        
    }
}