using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class TakafulReport : Form
    {
        public TakafulReport(ReportMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | Report - Takaful Report";
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

        public void TakafulReport_Load(object sender, EventArgs e)
        {
            try
            {
                //T_TakafulTabAd.Fill(ChequerSet.T_Takaful);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Takaful - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Report Info  */

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // By date //
                if (string.IsNullOrEmpty(Type_Txt.Text) && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 500;
                    ID2 = 501;
                    
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Takaful WHERE CDate BETWEEN @1 AND @2;";
                    Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("d"));
                    Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("d"));
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Takaful_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }

                else if (!string.IsNullOrEmpty(Type_Txt.Text) && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 500;
                    ID2 = 503;

                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Takaful WHERE Type = @0;";
                    Cmd.Parameters.AddWithValue("@0", Type_Txt.Text);
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Takaful_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                else if (!string.IsNullOrEmpty(Type_Txt.Text) && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    ID = 500;
                    ID2 = 504;

                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Takaful WHERE Type = @0 AND CDate BETWEEN @1 AND @2;";
                    Cmd.Parameters.AddWithValue("@0", Type_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("d"));
                    Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("d"));
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Takaful_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                //Reload //
                else if (string.IsNullOrEmpty(Type_Txt.Text) && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    ID = 500;
                    ID2 = 502;
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM T_Takaful;";
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            Takaful_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Takaful - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    T_TakafulBindSour.MoveLast();
                }
                else
                {
                    MessageBox.Show("Please Check You Choose !!!", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Takaful - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            Fr = From_Txt.Value.ToString("d");
            To = To_Txt.Value.ToString("d");
            if (Takaful_Grid.Rows.Count > 0)
            {
                Print myForm = new Print(null, null, null, ID, ChequerSet.T_Cheque, Convert.ToDateTime(Fr), ID2, To.ToString(), Type_Txt.Text, null, null,this)
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
                        panel3.Hide();
                        Details_Pan.Dock = DockStyle.Fill;
                        Details_Pan.BringToFront();
                        Details_Pan.Controls.Clear();
                        Details_Pan.Controls.Add(myForm);
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

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }
    }
}
