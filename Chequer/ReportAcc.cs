using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Accounting : Form
    {
        public Accounting(ReportMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | Chequer | Report - Accounting Report";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public ReportMain Mainform { get; set; } = null;
        public object Fr { get; set; }
        public object To { get; set; }
        public string Company { get; set; }
        public string ProName { get; set; }
        public int ID { get; set; }

        private void Report_Load(object sender, EventArgs e)
        {
            //T_ContractTabAd.Fill(CoSet.T_Contract);
            try
            {
                Dock = DockStyle.Fill;
                T_PayBindSour.AddNew();
                //T_ContractTabAd.Fill(CoSet.T_Contract);
                T_ContractBindSour.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Report Info  */

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Pay True //
                if (!string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 11;
                    SearchAlone("SELECT * FROM PtData WHERE Pay = @0", Pay_Txt.SelectedValue);
                }

                // Antibody True //
                else if (string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && !string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 12;
                    SearchAlone("SELECT * FROM PtData WHERE Contract = @0", Contract_Txt.SelectedValue);
                }

                // PCR With Date //
                else if (!string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 13;
                    SearchWithDate("SELECT * FROM PtData WHERE Pay = @0 AND CDate BETWEEN @1 AND @2;", Pay_Txt.SelectedValue, From_Txt.Value.ToString("d"), To_Txt.Value.ToString("d"));
                }

                // Antibody With Date //
                else if (string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && !string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 14;
                    SearchWithDate("SELECT * FROM PtData WHERE Contract = @0 AND CDate BETWEEN @1 AND @2;", Contract_Txt.SelectedValue, From_Txt.Value.ToString("d"), To_Txt.Value.ToString("d"));
                }

                // By date //
                else if (string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 15;
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM PtData WHERE CDate BETWEEN @1 AND @2;";
                    Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("d"));
                    Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("d"));
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Report_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }

                // Both with date //
                else if (!string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && !string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 16;
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM PtData WHERE (CDate Between @1 AND @2) AND (Contract=@3) AND (Pay='" + Pay_Txt.SelectedValue + "');";
                        Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("d"));
                        Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("d"));
                        Cmd.Parameters.AddWithValue("@3", Contract_Txt.SelectedValue);
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            Report_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Reload //
                else if (string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString()) &&
                    From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 17;
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM PtData;";
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            Report_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    PtDataBindour.MoveLast();
                }

                // Both without date //
                else if (!string.IsNullOrEmpty(Pay_Txt.SelectedValue.ToString()) && !string.IsNullOrEmpty(Contract_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 19;
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM PtData WHERE Pay= @0 AND Contract = @1";
                        Cmd.Parameters.AddWithValue("@0", Pay_Txt.SelectedValue);
                        Cmd.Parameters.AddWithValue("@1", Contract_Txt.SelectedValue);
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            Report_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Check You Choose !!!", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            //if (Report_Grid.Rows.Count > 0)
            //{
            //    Fr = From_Txt.Value.ToString("d");
            //    To = To_Txt.Value.ToString("d");
            //    using (Print2 frm = new Print(Fr.ToString(), To.ToString(), Pay_Txt.SelectedValue.ToString(), Contract_Txt.SelectedValue.ToString(), ID, CoSet.PtData))
            //    {
            //        frm.ShowDialog();
            //    }
            //}
            //else
            //{
            //    MessageBoxEx.Show("Please Search for Data First.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            //}
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
                    Report_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchWithDate(string Value, object Value2, object F, object T)
        {
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
                    Report_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Report - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }
    }
}
