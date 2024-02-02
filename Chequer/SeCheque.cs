using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class SeCheque : Form
    {
        public SeCheque()
        {
            InitializeComponent();
            ActiveForm.Text = Resources.AppName + " Search - Cheque";
            Dock = DockStyle.Fill;
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public int M { get; set; }

        internal protected void Search_Load(object sender, EventArgs e)
        {

            try
            {
                t_UsersTableAdapter.Fill(ChequerSet.T_Users);
                tUsersBindingSource.AddNew();
                T_ChequeTabAd.Fill(ChequerSet.T_Cheque);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*  Search Info  */

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                //CIF Ture
                if (!string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Cheque WHERE CIF = @0", CIF_Txt.Text);
                }

                // Deal True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Cheque WHERE Deal = @0", Deal_Txt.Text);
                }

                // UserID True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text) && !string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Cheque WHERE UserID = @0;", UserID_Txt.SelectedValue);
                }


                // By date //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM T_Cheque WHERE TxDate BETWEEN @1 AND @2;";
                        Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("dd/MM/yyyy")+" 12:00:00 AM");
                        Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("dd/MM/yyyy")+" 11:59:59 PM");
                        using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                        {
                            DataTable Dt = new DataTable();
                            Da.Fill(Dt);
                            Search_Grid.DataSource = Dt;
                        }
                        Cmd.Parameters.Clear();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Reload //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    Reload_Btn_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Please Check You Choose !!!", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Some Problem." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Search_Grid.RowCount == 0)
            {
                MessageBox.Show("No Data Founded" + "\r\n" + "Please Check You Choose !!!", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reload_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Cheque;";
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    Search_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
                T_ChequeBindSour.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Search_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e) => Close();

        private void Search_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Btn_Click( sender, e);
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {

                string ID = Search_Grid.CurrentRow.Cells[0].Value.ToString();
                string Name = Search_Grid.CurrentRow.Cells[2].Value.ToString();
                string Pass = Search_Grid.CurrentRow.Cells[5].Value.ToString();
                Cheque myForm = new Cheque(this, ID, Name, Pass, null)
                {
                    TopLevel = false
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
                        myForm.Dock = DockStyle.Fill;
                        myForm.Show();
                        break;
                    }
                }
                if (M != 1)
                {
                    MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
           
        }
    }
}
