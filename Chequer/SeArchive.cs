using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class SeArchive : Form
    {
        public SeArchive()
        {
            InitializeComponent();
            ActiveForm.Text = Resources.AppName + " Search - Archive";
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
                T_ArchiveTabAd.Fill(ChequerSet.T_Archive);
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
                if (!string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE CIF = @0", CIF_Txt.Text);
                }

                // Deal True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE Deal = @0", Deal_Txt.Text);
                }

                // Carton True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && !string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE Carton = @0", Carton_Txt.Text);
                }

                // Type True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && !string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE Type = @0", Type_Txt.Text);
                }

                // Type True With Date//
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && !string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Archive WHERE Type = @3 AND C_Date BETWEEN @1 AND @2;", From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"), Type_Txt.Text);
                }

                // Archive True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && !string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE ArchiveName = @0", Archive_Txt.Text);
                }

                // Archive True With Date//
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && !string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Archive WHERE ArchiveName = @3 AND C_Date BETWEEN @1 AND @2;", From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"), Archive_Txt.Text);
                }
                // UserID True //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && !string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == false && To_Txt.Checked == false)
                {
                    SearchAlone("SELECT * FROM T_Archive WHERE UserID = @0;", UserID_Txt.SelectedValue);
                }
                // UserID True With Date //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text.ToString()) && string.IsNullOrEmpty(Carton_Txt.Text.ToString())
                    && string.IsNullOrEmpty(Type_Txt.Text.ToString()) && string.IsNullOrEmpty(Archive_Txt.Text.ToString()) && !string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                    && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    SearchDate("SELECT * FROM T_Archive WHERE UserID = @3 AND C_Date BETWEEN @1 AND @2;", From_Txt.Value.ToString("dd/MM/yyyy"), To_Txt.Value.ToString("dd/MM/yyyy"), UserID_Txt.SelectedValue.ToString());
                }

                // By date //
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
                         && From_Txt.Checked == true && To_Txt.Checked == true)
                {
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                            Con.Open();
                        Cmd.Connection = Con;
                        Cmd.CommandText = "SELECT * FROM T_Archive WHERE C_Date BETWEEN @1 AND @2;";
                        Cmd.Parameters.AddWithValue("@1", From_Txt.Value.ToString("dd/MM/yyyy"));
                        Cmd.Parameters.AddWithValue("@2", To_Txt.Value.ToString("dd/MM/yyyy"));
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
                else if (string.IsNullOrEmpty(CIF_Txt.Text) && string.IsNullOrEmpty(Deal_Txt.Text) && string.IsNullOrEmpty(UserID_Txt.Text.ToString())
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
                Cmd.CommandText = "SELECT * FROM T_Archive;";
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    Search_Grid.DataSource = Dt;
                }
                Cmd.Parameters.Clear();
                Con.Close();
                T_ArchiveBindSour.MoveLast();
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

        private void SearchDate(string Value, string x, string y, string z)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@1", x);
                Cmd.Parameters.AddWithValue("@2", y);
                Cmd.Parameters.AddWithValue("@3", z);
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
        }
    }
}
