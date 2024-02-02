using Chequer.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Print : Form
    {
        public readonly ChequerDataSet.T_ChequeDataTable Ch;
        public readonly ChequerDataSet.T_TakafulDataTable _Takaful;

        public Print(Cheque che, Report rep, string Numb, int ID, ChequerDataSet.T_ChequeDataTable Che, DateTime D, int Tenor, string To, string UserID, AdvancedTaxReport Sub2, Takaful Sub1, TakafulReport Sub3)
        {
            Ch = Che;
            Num = Numb;
            Id = ID;
            Date = D;
            Ten = Tenor;
            Too = To;
            Userid = UserID;
            Mainform = che;
            Subform = rep;
            SubForm1 = Sub1;
            SubForm2 = Sub2;
            SubForm3 = Sub3;
            InitializeComponent();
            Text = "AAY | IIS | Print";
            Dock = DockStyle.Fill;
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();

        public Cheque Mainform { get; set; }
        public Report Subform { get; set; }
        public AdvancedTaxReport SubForm2 { get; set; }
        public Takaful SubForm1 { get; set; }
        public TakafulReport SubForm3 { get; set; }
        public string Num { get; set; }
        public string Too { get; set; }
        public string Userid { get; set; }
        public DateTime Date { get; set; }
        public int a, b, c;
        public DateTime x, y, z;
        public string Qurey { get; set; }
        public int Id { get; set; }
        public int Ten { get; set; }
        public int Count { get; set; }


        private void Print_Btn_Click(object sender, EventArgs e)
        {
            a = 2; b = 3; c = 4;
            Fun(a, b, c, Date);
            Login.Instance.Printer("Default", $"{Login.Instance.UserID}");
            foreach (var obj in Login.Instance.List2)
            {
                ChequeRep.LocalReport.PrintToPrinter(obj.Printer);
            }

            for (int i = 1; i < Ten / 3; i++)
            {
                Next_Btn_Click(sender, e);
                Login.Instance.Printer("Default", $"{Login.Instance.UserID}");
                foreach (var obj in Login.Instance.List2)
                {
                    ChequeRep.LocalReport.PrintToPrinter(obj.Printer);
                }
            }
        }

        protected internal void Print_Load(object sender, EventArgs e)
        {
            Login.Instance.Check(Login.Instance.UserName, Footer.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (Footer.Name == obj.FunctionName)
                {
                    Footer.Enabled = true;
                    Footer.Show();
                }
            }
            Count = 1;
            try
            {
                switch (Id)
                {
                    case 1:
                        a = 2; b = 3; c = 4;
                        Fun(a, b, c, Date);
                        //Fun2();
                        break;
                    case 2:
                        Fun2(); // With Installment;
                        break;
                    case 100:
                        FunRep(Num, Too, Userid);
                        break;
                    case 500:
                        TakRep(Userid, Date.ToString("d"), Too);
                        break;
                    case 600:
                        AdvancedTaxRep(Num, Too, Userid);
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Previous_Btn_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {

            }
            else
            {
                Date = Date.AddMonths(-3);

                DateTime nextYear;
                if (Date.Year == 12)
                {
                    nextYear = Date.AddYears(-1);
                    a -= 3; b -= 3; c -= 3;
                    Para(a, b, c, nextYear);
                }
                else
                {
                    a -= 3; b -= 3; c -= 3;
                    Para(a, b, c, Date);
                }
                Count -= 1;
            }
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (Count < Ten / 3)
            {
                Date = Date.AddMonths(3);

                DateTime nextYear;
                if (Date.Year == 12)
                {
                    nextYear = Date.AddYears(1);
                    a += 3; b += 3; c += 3;
                    Para(a, b, c, nextYear);
                }
                else
                {
                    a += 3; b += 3; c += 3;
                    Para(a, b, c, Date);

                }
                //Login.Instance.Printer("Default");
                //foreach (var obj in Login.Instance.List2)
                //{
                //    ChequeRep.LocalReport.PrintToPrinter(obj.Printer);
                //}
                Count += 1;
            }
        }


        /* Function */

        public void Fun(int x, int y, int z, DateTime date)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Cheque  WHERE ID =@0;";
                Cmd.Parameters.AddWithValue("@0", Num);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_ChequeBindingSource.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChequeRep.Dock = DockStyle.Fill; ChequeRep.BringToFront();

            ReportParameter[] p = new ReportParameter[]
{
                new ReportParameter("A", Convert.ToString(x)),
                new ReportParameter("B", Convert.ToString(y)),
                new ReportParameter("C", Convert.ToString(z)),
                new ReportParameter("X", Convert.ToString(date.ToShortDateString())),
                new ReportParameter("Y", Convert.ToString(date.AddMonths(1).ToShortDateString())),
                new ReportParameter("Z", Convert.ToString(date.AddMonths(2).ToShortDateString())),
};
            ChequeRep.LocalReport.SetParameters(p);
            ChequeRep.SetDisplayMode(DisplayMode.PrintLayout);
            ChequeRep.RefreshReport();

        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            if (Mainform != null)
            {
                Close();
                Mainform.Details_Pan.SendToBack();
                Mainform.panel1.Show();
                Mainform.panel3.Show();
                Mainform.Form1_Load(sender, e);
            }
            else
            {
                Close();
                if (Subform != null)
                {
                    Subform.Details_Pan.SendToBack();
                    Subform.panel1.Show();
                    Subform.panel3.Show();
                    Subform.Report_Load(sender, e);
                }
                else if (SubForm1 != null)
                {
                    SubForm1.Details_Pan.SendToBack();
                    SubForm1.panel1.Show();
                    SubForm1.panel3.Show();
                    SubForm1.Takaful_Load(sender, e);
                }
                else if (SubForm3 != null)
                {
                    SubForm3.Details_Pan.SendToBack();
                    SubForm3.panel1.Show();
                    SubForm3.panel3.Show();
                    SubForm3.TakafulReport_Load(sender, e);
                }
                else if (SubForm2 != null)
                {
                    SubForm2.Details_Pan.SendToBack();
                    SubForm2.panel1.Show();
                    SubForm2.panel2.Show();
                    SubForm2.AdvancedTaxReport_Load(sender, e);
                }
            }
        }

        private void FunRep(string From, string Too, string userid)
        {
            string G = null;
            if (Id == 100 && Ten == 0)
            {
                Qurey = "SELECT * FROM T_Cheque WHERE UserID = @0";
                Cmd.Parameters.AddWithValue("@0", userid);
                From = null;
                Too = null;
            }
            else if (Id == 100 && Ten == 101)
            {
                Qurey = "SELECT * FROM T_Cheque WHERE TxDate BETWEEN @1 AND @2;";
                Cmd.Parameters.AddWithValue("@0", From);
                Cmd.Parameters.AddWithValue("@1", Too);
                userid = null;
            }
            else if (Id == 100 && Ten == 102)
            {
                Qurey = "SELECT * FROM T_Cheque;";
                G = "General Report";
                From = null;
                Too = null;
                userid = null;
            }
            else if (Id == 100 && Ten == 103 && Userid != null)
            {
                Qurey = "SELECT * FROM T_Cheque WHERE UserID = @0 AND TxDate BETWEEN @1 AND @2;";
                Cmd.Parameters.AddWithValue("@0", userid);
                Cmd.Parameters.AddWithValue("@1", From);
                Cmd.Parameters.AddWithValue("@2", Too);
            }
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Qurey;
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_ChequeBindingSource.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GeneralRep.Dock = DockStyle.Fill; GeneralRep.BringToFront();
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("A", From),
                new ReportParameter("B", Too),
                new ReportParameter("C", userid),
                new ReportParameter("D", G),
            };
            GeneralRep.LocalReport.SetParameters(p);
            GeneralRep.SetDisplayMode(DisplayMode.PrintLayout);
            GeneralRep.RefreshReport();
        }

        private void Para(int x, int y, int z, DateTime date)
        {
            ReportParameter[] p = new ReportParameter[]
{
                new ReportParameter("A", Convert.ToString(x)),
                new ReportParameter("B", Convert.ToString(y)),
                new ReportParameter("C", Convert.ToString(z)),
                new ReportParameter("X", Convert.ToString(date.ToShortDateString())),
                new ReportParameter("Y", Convert.ToString(date.AddMonths(1).ToShortDateString())),
                new ReportParameter("Z", Convert.ToString(date.AddMonths(2).ToShortDateString())),
};
            ChequeRep.LocalReport.SetParameters(p);
            ChequeRep.RefreshReport();

        }

        public void Fun2()
        {

            string Qurey;

            try
            {
                Qurey = "SELECT T_Cheque.*, T_Installment.* FROM T_Cheque INNER JOIN T_Installment ON T_Cheque.ID = T_Installment.ID WHERE T_Installment.ID =@0 AND T_Installment.Count <> 1;";
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\Report\\Report1.rdlc";
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Qurey;
                Cmd.Parameters.AddWithValue("@0", Num);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_ChequeBindingSource.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            reportViewer1.Dock = DockStyle.Fill; reportViewer1.BringToFront();
            
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();


        }

        private void TakRep(string userid, string From, string Too)
        {
            string G = null;
            if (Id == 500 && Ten == 0)
            {
                Qurey = "SELECT CutName,Balance,Takaful,Tenor,Deal FROM T_Takaful WHERE CDate = @0";
                Cmd.Parameters.AddWithValue("@0", From);
                Too = null;
                userid = "Date : " + From;

            }
            else if (Id == 500 && Ten == 501)
            {
                Qurey = "SELECT * FROM T_Takaful WHERE CDate BETWEEN @0 AND @1;";
                Cmd.Parameters.AddWithValue("@0", From);
                Cmd.Parameters.AddWithValue("@1", Too);
                userid = null;
                G = null;
            }
            else if (Id == 500 && Ten == 502)
            {
                Qurey = "SELECT * FROM T_Takaful;";
                From = null;
                userid = null;
                Too = null;
                G = "General Report";
            }
            else if (Id == 500 && Ten == 503)
            {
                Qurey = "SELECT * FROM T_Takaful WHERE Type = @0;";
                Cmd.Parameters.AddWithValue("@0", userid);
                userid = "Type : " + userid;
                From = null;
                Too = null;
                G = null;
            }
            else if (Id == 500 && Ten == 504)
            {
                Qurey = "SELECT * FROM T_Takaful WHERE Type = @0 AND CDate BETWEEN @1 AND @2;";
                Cmd.Parameters.AddWithValue("@0", userid);
                Cmd.Parameters.AddWithValue("@1", From);
                Cmd.Parameters.AddWithValue("@2", Too);
                userid = "Type : " + userid;
                G = null;
            }
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Qurey;
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_TakafulBindSour.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TakafulRep.Dock = DockStyle.Fill; TakafulRep.BringToFront();
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("A", From),
                new ReportParameter("B", Too),
                new ReportParameter("C", userid),
                new ReportParameter("D", G),
            };
            TakafulRep.LocalReport.SetParameters(p);
            TakafulRep.SetDisplayMode(DisplayMode.PrintLayout);
            TakafulRep.RefreshReport();
        }

        private void AdvancedTaxRep(string From, string Too, string userid)
        {
            string G = null;
            if (Id == 600 && Ten == 0)
            {
                Qurey = "SELECT * FROM T_AdvancedTax WHERE Type = @0";
                Cmd.Parameters.AddWithValue("@0", userid);
                From = null;
                Too = null;
            }
            else if (Id == 600 && Ten == 601)
            {
                Qurey = "SELECT * FROM T_AdvancedTax WHERE CDate BETWEEN @1 AND @2;";
                Cmd.Parameters.AddWithValue("@0", From);
                Cmd.Parameters.AddWithValue("@1", Too);
                userid = null;
            }
            else if (Id == 600 && Ten == 602)
            {
                Qurey = "SELECT * FROM T_AdvancedTax;";
                G = "General Report";
                From = null;
                Too = null;
                userid = null;
            }
            else if (Id == 600 && Ten == 603 && Userid != null)
            {
                Qurey = "SELECT * FROM T_AdvancedTax WHERE Type = @0 AND CDate BETWEEN @1 AND @2;";
                Cmd.Parameters.AddWithValue("@0", userid);
                Cmd.Parameters.AddWithValue("@1", From);
                Cmd.Parameters.AddWithValue("@2", Too);
            }
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Qurey;
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_AdvancedTaxBindingSource.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Print - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TaxRep.Dock = DockStyle.Fill; TaxRep.BringToFront();
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("A", From),
                new ReportParameter("B", Too),
                new ReportParameter("C", userid),
                new ReportParameter("D", G),
            };
            TaxRep.LocalReport.SetParameters(p);
            TaxRep.SetDisplayMode(DisplayMode.PrintLayout);
            TaxRep.RefreshReport();
        }
    }
}
