namespace Chequer
{
    partial class Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.T_ChequeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerDataSet = new Chequer.ChequerDataSet();
            this.T_TakafulBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_AdvancedTaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TV_ChequeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChequeRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Footer = new System.Windows.Forms.Panel();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.Previous_Btn = new System.Windows.Forms.Button();
            this.GeneralRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.T_ChequeTableAdapter = new Chequer.ChequerDataSetTableAdapters.T_ChequeTableAdapter();
            this.TakafulRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TV_ChequeTableAdapter = new Chequer.ChequerDataSetTableAdapters.TV_ChequeTableAdapter();
            this.T_TakafulTabAd = new Chequer.ChequerDataSetTableAdapters.T_TakafulTableAdapter();
            this.TaxRep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T_AdvancedTaxTableAdapter = new Chequer.ChequerDataSetTableAdapters.T_AdvancedTaxTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_AdvancedTaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_ChequeBindingSource)).BeginInit();
            this.Footer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // T_ChequeBindingSource
            // 
            this.T_ChequeBindingSource.DataMember = "T_Cheque";
            this.T_ChequeBindingSource.DataSource = this.ChequerDataSet;
            // 
            // ChequerDataSet
            // 
            this.ChequerDataSet.DataSetName = "ChequerDataSet";
            this.ChequerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_TakafulBindSour
            // 
            this.T_TakafulBindSour.DataMember = "T_Takaful";
            this.T_TakafulBindSour.DataSource = this.ChequerDataSet;
            // 
            // T_AdvancedTaxBindingSource
            // 
            this.T_AdvancedTaxBindingSource.DataMember = "T_AdvancedTax";
            this.T_AdvancedTaxBindingSource.DataSource = this.ChequerDataSet;
            // 
            // TV_ChequeBindingSource
            // 
            this.TV_ChequeBindingSource.DataMember = "TV_Cheque";
            this.TV_ChequeBindingSource.DataSource = this.ChequerDataSet;
            // 
            // ChequeRep
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.T_ChequeBindingSource;
            this.ChequeRep.LocalReport.DataSources.Add(reportDataSource1);
            this.ChequeRep.LocalReport.ReportEmbeddedResource = "Chequer.ChequeRep.rdlc";
            this.ChequeRep.Location = new System.Drawing.Point(12, 31);
            this.ChequeRep.Name = "ChequeRep";
            this.ChequeRep.ServerReport.BearerToken = null;
            this.ChequeRep.Size = new System.Drawing.Size(132, 206);
            this.ChequeRep.TabIndex = 2;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.Print_Btn);
            this.Footer.Controls.Add(this.Next_Btn);
            this.Footer.Controls.Add(this.Previous_Btn);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Enabled = false;
            this.Footer.Location = new System.Drawing.Point(0, 552);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1020, 48);
            this.Footer.TabIndex = 3;
            this.Footer.Visible = false;
            // 
            // Print_Btn
            // 
            this.Print_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Print_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Btn.ForeColor = System.Drawing.Color.Black;
            this.Print_Btn.Image = global::Chequer.Properties.Resources.Dark_Print_18;
            this.Print_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Print_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Print_Btn.Location = new System.Drawing.Point(708, 8);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(89, 34);
            this.Print_Btn.TabIndex = 17;
            this.Print_Btn.Text = "Print All";
            this.Print_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Next_Btn
            // 
            this.Next_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Next_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Next_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Next_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Next_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Next_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Next_Btn.ForeColor = System.Drawing.Color.Black;
            this.Next_Btn.Image = global::Chequer.Properties.Resources.Dark_Arrow_Right_36;
            this.Next_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Next_Btn.Location = new System.Drawing.Point(525, 3);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(37, 42);
            this.Next_Btn.TabIndex = 15;
            this.Next_Btn.UseVisualStyleBackColor = false;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // Previous_Btn
            // 
            this.Previous_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Previous_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Previous_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Previous_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Previous_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Previous_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Previous_Btn.ForeColor = System.Drawing.Color.Black;
            this.Previous_Btn.Image = global::Chequer.Properties.Resources.Dark_Arrow_Left_36;
            this.Previous_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Previous_Btn.Location = new System.Drawing.Point(459, 3);
            this.Previous_Btn.Name = "Previous_Btn";
            this.Previous_Btn.Size = new System.Drawing.Size(37, 42);
            this.Previous_Btn.TabIndex = 16;
            this.Previous_Btn.UseVisualStyleBackColor = false;
            this.Previous_Btn.Click += new System.EventHandler(this.Previous_Btn_Click);
            // 
            // GeneralRep
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.T_ChequeBindingSource;
            this.GeneralRep.LocalReport.DataSources.Add(reportDataSource2);
            this.GeneralRep.LocalReport.ReportEmbeddedResource = "Chequer.GeneralRep.rdlc";
            this.GeneralRep.Location = new System.Drawing.Point(150, 31);
            this.GeneralRep.Name = "GeneralRep";
            this.GeneralRep.ServerReport.BearerToken = null;
            this.GeneralRep.Size = new System.Drawing.Size(132, 206);
            this.GeneralRep.TabIndex = 4;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.T_ChequeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Chequer.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(288, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(132, 206);
            this.reportViewer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.Close_Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 25);
            this.panel2.TabIndex = 6;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.Black;
            this.Close_Btn.Image = global::Chequer.Properties.Resources.Dark_Close_18;
            this.Close_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close_Btn.Location = new System.Drawing.Point(995, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(25, 25);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.UseVisualStyleBackColor = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // T_ChequeTableAdapter
            // 
            this.T_ChequeTableAdapter.ClearBeforeFill = true;
            // 
            // TakafulRep
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.T_TakafulBindSour;
            this.TakafulRep.LocalReport.DataSources.Add(reportDataSource4);
            this.TakafulRep.LocalReport.ReportEmbeddedResource = "Chequer.TakafulRep.rdlc";
            this.TakafulRep.Location = new System.Drawing.Point(438, 31);
            this.TakafulRep.Name = "TakafulRep";
            this.TakafulRep.ServerReport.BearerToken = null;
            this.TakafulRep.Size = new System.Drawing.Size(132, 206);
            this.TakafulRep.TabIndex = 7;
            // 
            // TV_ChequeTableAdapter
            // 
            this.TV_ChequeTableAdapter.ClearBeforeFill = true;
            // 
            // T_TakafulTabAd
            // 
            this.T_TakafulTabAd.ClearBeforeFill = true;
            // 
            // TaxRep
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.T_AdvancedTaxBindingSource;
            this.TaxRep.LocalReport.DataSources.Add(reportDataSource5);
            this.TaxRep.LocalReport.ReportEmbeddedResource = "Chequer.TaxRep.rdlc";
            this.TaxRep.Location = new System.Drawing.Point(587, 31);
            this.TaxRep.Name = "TaxRep";
            this.TaxRep.ServerReport.BearerToken = null;
            this.TaxRep.Size = new System.Drawing.Size(132, 206);
            this.TaxRep.TabIndex = 8;
            // 
            // T_AdvancedTaxTableAdapter
            // 
            this.T_AdvancedTaxTableAdapter.ClearBeforeFill = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.TaxRep);
            this.Controls.Add(this.TakafulRep);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.GeneralRep);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.ChequeRep);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_AdvancedTaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TV_ChequeBindingSource)).EndInit();
            this.Footer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ChequerDataSet ChequerDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer ChequeRep;
        private System.Windows.Forms.BindingSource T_ChequeBindingSource;
        private ChequerDataSetTableAdapters.T_ChequeTableAdapter T_ChequeTableAdapter;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Button Previous_Btn;
        private System.Windows.Forms.Button Print_Btn;
        private Microsoft.Reporting.WinForms.ReportViewer GeneralRep;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close_Btn;
        private Microsoft.Reporting.WinForms.ReportViewer TakafulRep;
        private System.Windows.Forms.BindingSource TV_ChequeBindingSource;
        private ChequerDataSetTableAdapters.TV_ChequeTableAdapter TV_ChequeTableAdapter;
        private System.Windows.Forms.BindingSource T_TakafulBindSour;
        private ChequerDataSetTableAdapters.T_TakafulTableAdapter T_TakafulTabAd;
        private Microsoft.Reporting.WinForms.ReportViewer TaxRep;
        private System.Windows.Forms.BindingSource T_AdvancedTaxBindingSource;
        private ChequerDataSetTableAdapters.T_AdvancedTaxTableAdapter T_AdvancedTaxTableAdapter;
        protected internal System.Windows.Forms.Panel Footer;
    }
}