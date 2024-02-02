using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class SeContracted : Form
    {
        public SeContracted()
        {
            InitializeComponent();
            ActiveForm.Text = Resources.AppName + " Search - Contracted";
            Dock = DockStyle.Fill;
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public int M { get; set; }

        internal protected void Search_Load(object sender, EventArgs e)
        {
            try
            {
                T_UsersTabAd.Fill(ChequerSet.T_Users);
                T_UsersBindSour.AddNew();
                this.T_ConTabAd.Fill(this.ChequerSet.T_Contracted);
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
                // Deal True //
                if (!string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Contracted WHERE Deal = @0", Deal_Txt.Text);
                }

                // Deal True with Date//
                if (!string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Contracted WHERE Deal = @0 AND TxDate BETWEEN @1 AND @2;", Deal_Txt.Text, From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"));
                }

                // UserID True //
                else if (string.IsNullOrEmpty(Deal_Txt.Text) && !string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Contracted WHERE UserID = @0;", UserID_Txt.SelectedValue);
                }

                // UserID True  with Date//
                else if (string.IsNullOrEmpty(Deal_Txt.Text) && !string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Contracted WHERE UserID = @0 AND TxDate BETWEEN @1 AND @2;", UserID_Txt.SelectedValue.ToString(), From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"));
                }

                // By date //
                else if (string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
                         && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Contracted WHERE TxDate BETWEEN @1 AND @2;", null, From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"));
                }
                //Reload //
                else if (string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.SelectedValue.ToString())
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
            if (SeContracted_Grid.RowCount == 0)
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
                Cmd.CommandText = "SELECT * FROM T_Contracted;";
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    SeContracted_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
                T_ConBindSour.MoveLast();
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
                    SeContracted_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Search - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchDate(string Value, string x, string y, string z)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@0", x);
                Cmd.Parameters.AddWithValue("@1", y);
                Cmd.Parameters.AddWithValue("@2", z);

                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    SeContracted_Grid.DataSource = Dt;
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
            string FilePath = Application.StartupPath + "\\Deals\\" + SeContracted_Grid.CurrentRow.Cells[2].Value.ToString() + "\\Contract.docx";
            string FilePath2 = Application.StartupPath + "\\Deals\\" + SeContracted_Grid.CurrentRow.Cells[2].Value.ToString() + "\\Recieving Goods.docx";
            string FilePath3 = Application.StartupPath + "\\Deals\\" + SeContracted_Grid.CurrentRow.Cells[2].Value.ToString() + "\\Recieving Cheque.docx";
            string FilePath4 = Application.StartupPath + "\\Deals\\" + SeContracted_Grid.CurrentRow.Cells[2].Value.ToString() + "\\Request Cheque.docx";
            Contracted Frm = new Contracted(null);
            Frm.Report1(FilePath, FilePath2, FilePath3, FilePath4);
        }
    }
}
