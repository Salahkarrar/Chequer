using Chequer.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Takaful : Form
    {
        public Takaful(Takaful Tak, string ID, string Name, string Passport, IISMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - Takaful - Durable Finance";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public IISMain Mainform { get; set; } = null;
        public int Index { get; set; } = 1;
        public List<PROAuth> List { get; set; }
        public int M { get; set; }

        public object ID { get; set; }

        protected internal void Takaful_Load(object sender, EventArgs e)
        {
            Details_Pan.SendToBack();
            panel1.Show();
            panel3.Show();
            Index = 1;
            T_TakafulTabAd.Fill(chequerDataSet.T_Takaful);
            T_ChequeTabAd.Fill(chequerDataSet.T_Cheque);
            Fill(Index);
            FunFill(Index);
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Fun_Grid.SelectedRows.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_Takaful (CutName,CIF,Deal,Tenor,Balance,Takaful,CDate,UserID,Type) VALUES " +
                                      " (@0,@1,@2,@3,@4,@5,@6,@7,@8)";
                    Cmd.Parameters.AddWithValue("@0", Fun_Grid.SelectedRows[i].Cells[2].Value.ToString());
                    Cmd.Parameters.AddWithValue("@1", Convert.ToInt32(Fun_Grid.SelectedRows[i].Cells[3].Value));
                    Cmd.Parameters.AddWithValue("@2", Convert.ToInt32(Fun_Grid.SelectedRows[i].Cells[1].Value));
                    Cmd.Parameters.AddWithValue("@3", Convert.ToInt32(Fun_Grid.SelectedRows[i].Cells[4].Value));
                    Cmd.Parameters.AddWithValue("@4", Convert.ToDouble(Fun_Grid.SelectedRows[i].Cells[16].Value));
                    Cmd.Parameters.AddWithValue("@5", Convert.ToDouble(Fun_Grid.SelectedRows[i].Cells[18].Value));
                    Cmd.Parameters.AddWithValue("@6", Date_Txt.Text);
                    Cmd.Parameters.AddWithValue("@7", Convert.ToInt32($"{Login.Instance.UserID}"));
                    Cmd.Parameters.AddWithValue("@8", "Durable Finance");
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_TakafulTabAd.Fill(chequerDataSet.T_Takaful);
                }
                Fill(Index);
                FunFill(Index);
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
                for (int i = 0; i < FunRole_Grid.SelectedRows.Count; i++)
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM T_Takaful WHERE Deal=@0";
                    Cmd.Parameters.AddWithValue("@0", FunRole_Grid.SelectedRows[i].Cells[1].Value);
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
                Cmd.CommandText = "SELECT * FROM T_Takaful WHERE CDate=@0";
                Cmd.Parameters.AddWithValue("@0", Date_Txt.Text);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_TakafulBindSour.DataSource = Dt;
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
                Cmd.CommandText = "SELECT * FROM T_Cheque WHERE Deal NOT IN (Select Deal FROM T_Takaful)";
                Cmd.Parameters.AddWithValue("@0", DateTime.Today.Date);
                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_ChequeBindSour1.DataSource = Dt;
                    Fun_Grid.DataSource = T_ChequeBindSour1;
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
            Mainform.Takaful_Pan.Show();
            Mainform.Takaful_Pan.BringToFront();
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            if (FunRole_Grid.Rows.Count > 0)
            {
                Print myForm = new Print(null, null, null, 500, null, Convert.ToDateTime(Date_Txt.Text), 0, null, $"{Login.Instance.UserID}", null, this, null)
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

        private void Date_Txt_ValueChanged(object sender, EventArgs e)
        {
            Fill(Index);
        }

        private void Deal_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Deal_Txt.TextLength == 0)
            {
                T_ChequeTabAd.Fill(chequerDataSet.T_Cheque);
                //Fill();
            }
            else
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                Cmd.CommandText = "SELECT * FROM T_Cheque WHERE Deal NOT IN (Select Deal FROM T_Takaful) AND Deal LIKE '%" + Deal_Txt.Text + "%';";

                using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                {
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                    T_ChequeBindSour1.DataSource = Dt;
                    T_ChequeTabAd.Fill(chequerDataSet.T_Cheque);
                }
                Con.Close();
            }
        }

        private void Deal_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Deal_Txt.TextLength == 0)
                {
                    T_ChequeTabAd.Fill(chequerDataSet.T_Cheque);
                    //Fill();
                }
                else
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT Deal,CutName From T_Cheque WHERE Deal LIKE '%" + Deal_Txt.Text + "%';";

                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        T_ChequeBindSour1.DataSource = Dt;
                        T_ChequeTabAd.Fill(chequerDataSet.T_Cheque);
                    }
                    Con.Close();
                }
            }
        }

        private void Archive_Btn_Click(object sender, EventArgs e)
        {
            Archive();
        }
        private void Archive()
        {
            for(int i=0;i<FunRole_Grid.Rows.Count;i++)
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.Connection = Con;
                //Cmd.CommandText = "Insert into T_Archive (CustName,CIF,Deal,Carton,Type,ArchiveName,C_Date,Notes,Status,TxDate,UserID) "+
                //                  "VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)";
                //Cmd.Parameters.AddWithValue("@0", FunRole_Grid.Rows[i].Cells[1].Value.ToString());
                //Cmd.Parameters.AddWithValue("@1", 0);
                //Cmd.Parameters.AddWithValue("@2", FunRole_Grid.Rows[i].Cells[0].Value);
                //Cmd.Parameters.AddWithValue("@3", 0);
                //Cmd.Parameters.AddWithValue("@4", "Durable");
                //Cmd.Parameters.AddWithValue("@5", "HQ");
                //Cmd.Parameters.AddWithValue("@6", DateTime.Now.Date);
                //Cmd.Parameters.AddWithValue("@7", "");
                //Cmd.Parameters.AddWithValue("@8", "In Archive");
                //Cmd.Parameters.AddWithValue("@9", DateTime.Now);
                //Cmd.Parameters.AddWithValue("@10", Login.Instance.UserID);
                Cmd.CommandText = "Insert into T_Archive (CustName,Deal,Type,ArchiveName,C_Date,Status,TxDate,UserID,CIF) " +
                                  "VALUES (@0,@1,@2,@3,@4,@5,@6,@7,@8)";
                Cmd.Parameters.AddWithValue("@0", FunRole_Grid.Rows[i].Cells[2].Value.ToString());
                Cmd.Parameters.AddWithValue("@1", FunRole_Grid.Rows[i].Cells[1].Value);
                Cmd.Parameters.AddWithValue("@2", "Durable");
                Cmd.Parameters.AddWithValue("@3", "HQ");
                Cmd.Parameters.AddWithValue("@4", DateTime.Now.Date.ToString("d"));
                Cmd.Parameters.AddWithValue("@5", "In Archive");
                Cmd.Parameters.AddWithValue("@6", DateTime.Now.ToString("G"));
                Cmd.Parameters.AddWithValue("@7", Login.Instance.UserID);
                Cmd.Parameters.AddWithValue("@8", FunRole_Grid.Rows[i].Cells[3].Value);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
            }
        }
    }
}
