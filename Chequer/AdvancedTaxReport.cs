using Chequer.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class AdvancedTaxReport : Form
    {
        public AdvancedTaxReport(ReportMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | Report - AdvancedTax Report";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public ReportMain Mainform { get; set; } = null;
        public object Fr { get; set; }
        public object To { get; set; }
        public string Company { get; set; }
        public string ProName { get; set; }
        public int ID { get; set; }
        public int ID2 { get; set; }
        public int M { get; set; }

        public void AdvancedTaxReport_Load(object sender, EventArgs e)
        {
            try
            {
                //T_AdTaxTabAd.Fill(ChequerSet.T_AdvancedTax);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax Report - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Report Info  */

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Type True //
                if (!string.IsNullOrEmpty(Type_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 600;
                    ID2 = 0;
                    SearchAlone("SELECT * FROM T_AdvancedTax WHERE Type = @0", Type_Txt.SelectedItem);
                }


                // Type With Date //
                else if (!string.IsNullOrEmpty(Type_Txt.Text.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 600;
                    ID2 = 603;
                    SearchWithDate("SELECT * FROM T_AdvancedTax WHERE Type = @0 AND CDate BETWEEN @1 AND @2;", Type_Txt.Text, From_Txt.Value.ToString("d"), To_Txt.Value.ToString("d"));
                }


                // By date //
                else if (string.IsNullOrEmpty(Type_Txt.Text.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 600;
                    ID2 = 601;
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_AdvancedTax WHERE CDate BETWEEN @1 AND @2;";
                    Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("d"));
                    Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("d"));
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        AdvancedTaxReport_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }

                //Reload //
                else if (string.IsNullOrEmpty(Type_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 600;
                    ID2 = 602;
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM T_AdvancedTax;";
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            AdvancedTaxReport_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error  AdvancedTax Report - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    T_AdTaxBindSour.MoveLast();
                }
                else
                {
                    MessageBox.Show("Please Check You Choose !!!", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax Report - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if (AdvancedTaxReport_Grid.Rows.Count > 0)
            {
                Fr = From_Txt.Value.ToString("d");
                To = To_Txt.Value.ToString("d");
                Print myForm = new Print(null, null, Fr.ToString(), ID, ChequerSet.T_Cheque, DateTime.Now, ID2, To.ToString(), Type_Txt.Text.ToString(), this, null,null)
                {
                    TopLevel = false,
                };
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        panel1.Hide();
                        panel2.Hide();
                        Details_Pan.Dock = DockStyle.Fill;
                        Details_Pan.BringToFront();
                        Details_Pan.Controls.Clear();
                        Details_Pan.Controls.Add(myForm);
                        //myForm.Dock = DockStyle.Fill;
                        myForm.Show();
                        break;
                    }
                }
                if (M != 1)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Search for Data First.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        /* Function */

        private void SearchAlone(string Value, object Value2)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@0", Value2);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    AdvancedTaxReport_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax Report - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchWithDate(string Value, object Value2, object F, object T)
        {
            ReportDataSource rprtDTSource = new ReportDataSource();
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@0", Value2);
                Cmd.Parameters.AddWithValue("@1", F);
                Cmd.Parameters.AddWithValue("@2", T);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    AdvancedTaxReport_Grid.DataSource = Dt;
                    rprtDTSource.Name = "DataSet1";
                    rprtDTSource.Value = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax Report - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }
    }
}
