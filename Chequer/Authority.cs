using Chequer.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Authority : Form
    {
        public Authority(SettingsMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | Chequer | Settings - Authority ";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public SettingsMain Mainform { get; set; } = null;
        public int Index { get; set; } = 1;
        public List<PROAuth> List { get; set; }

        public object ID { get; set; }

        protected internal void Authority_Load(object sender, EventArgs e)
        {
            Index = 1;
            T_RolesTabAd.Fill(CoSet.T_Roles);
            T_FunTabAd.Fill(CoSet.T_Function);
            Fill(Index);
            FunFill(Index);
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string FID = null;
            try
            {
                for (int i = 0; i < Fun_Grid.SelectedCells.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT FunctionID FROM T_Function WHERE FunctionName=@0";
                    Cmd.Parameters.AddWithValue("@0", Fun_Grid.SelectedCells[i].Value);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        FID = Reader[0].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                    T_FunRoleTabAd.Insert(Convert.ToInt32(FID), Convert.ToInt32(MAuthority_Txt.SelectedValue));
                    Fill(Index);
                    FunFill(Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Authority - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < FunRole_Grid.SelectedCells.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM T_FunctionRole WHERE (FunctionID=@0) AND (RoleID=@1)";
                    Cmd.Parameters.AddWithValue("@0", FunRole_Grid.SelectedCells[i].Value);
                    Cmd.Parameters.AddWithValue("@1", MAuthority_Txt.SelectedValue);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                Fill(Index);
                FunFill(Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Detete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Authority - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MAuthority_Txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = Convert.ToInt32(MAuthority_Txt.SelectedValue);
            Fill(Index);
            FunFill(Index);
        }

        private void Fun_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Add_Btn_Click(sender, e);

        private void FunRole_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Remove_Btn_Click(sender, e);

        /* Function */

        public void Fill(int Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_FunctionRole WHERE RoleID=@0";
                Cmd.Parameters.AddWithValue("@0", Value);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_FunRoleBindSour.DataSource = Dt;
                    FunRole_Grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data.." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Authority - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Fill(Index);
            }
        }

        public void FunFill(int Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Function WHERE FunctionID NOT IN (Select FunctionID FROM T_FunctionRole WHERE RoleID=@0)";
                Cmd.Parameters.AddWithValue("@0", Value);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    FunBindSour2.DataSource = Dt;
                    Fun_Grid.DataSource = FunBindSour2;
                }
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't retrive Your Data.." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Authority - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }
    }
}
