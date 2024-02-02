using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Archive : Form
    {
        public Archive(IISMain Main)
        {
            Na = Name;
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - Archive";
        }
        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public IISMain Mainform { get; set; } = null;
        public string Na { get; set; }
        public int ID { get; set; }
        public Control Ctrl { get; set; }
        public int M { get; set; }
        public void Archive_Load(object sender, EventArgs e)
        {
                T_ArchiveTabAd.Fill(ChequerData.T_Archive);
                Enabled = true;
                Edit(true, false);
            if (Convert.ToInt32(Login.Instance.RoleID) == 1 || Convert.ToInt32(Login.Instance.RoleID) == 2)
            {
                Delete_Btn.Show();
                Delete_Btn.Enabled = true;               
            }
            else
            {
                Delete_Btn.Hide();
                Delete_Btn.Enabled = false;
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                ChequerData.T_Archive.AddT_ArchiveRow(ChequerData.T_Archive.NewT_ArchiveRow());
                T_ArchiveBindSour.MoveLast();
                Name_Txt.Focus();
                Date_Txt.Text = DateTime.Now.ToString("d");
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Create New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            ID = 10;
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text)
                && !string.IsNullOrEmpty(Carton_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text) && !string.IsNullOrEmpty(Type_Txt.SelectedItem.ToString()))
            {
                Edit(true, false);
                try
                {
                    T_ArchiveTabAd.Insert(Name_Txt.Text, Convert.ToInt32(CIF_Txt.Text), Convert.ToInt32(Deal_Txt.Text), Convert.ToInt32(Carton_Txt.Text),
                                       Type_Txt.SelectedItem.ToString(), Archive_Txt.SelectedItem.ToString(), DateTime.Now, Date_Txt.Value, Convert.ToInt32($"{Login.Instance.UserID}"), Note_Txt.Text, Status_Txt.SelectedItem.ToString());
                    T_ArchiveTabAd.Fill(ChequerData.T_Archive);
                    T_ArchiveBindSour.MoveLast();
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    New_Btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cheque_Grid.CurrentRow.Cells[0].Value.ToString()) && Edit_Btn.Text == "Edit")
            {
                Edit(false, true);
                New_Btn.Enabled = false;
                Save_Btn.Enabled = false;

                Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
            }
            else if (Edit_Btn.Text == "Update")
            {
                Edit(true, false);
                New_Btn.Enabled = true;

                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                try
                {
                    Query("INSERT INTO T_ArchiveRecycle (ID, CustName, CIF, Deal, Carton, Type, ArchiveName, C_Date, TxDate, UserID, Notes, Status)" +
                          "SELECT ID, CustName, CIF, Deal, Carton, Type, ArchiveName, C_Date, TxDate, UserID,Notes, Status FROM T_Archive WHERE ID=@10;");
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "UPDATE T_Archive SET CustName = @0, CIF = @1, Deal = @2, Carton = @3, Type = @4, C_Date = @5, UserID = @6, ArchiveName = @7, TxDate = @8  WHERE ID = @10";
                    Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", CIF_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Deal_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", Carton_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", Type_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", Date_Txt.Value.ToString("d"));
                    Cmd.Parameters.AddWithValue("@6", $"{Login.Instance.UserID}");
                    Cmd.Parameters.AddWithValue("@7", Archive_Txt.Text) ;
                    Cmd.Parameters.AddWithValue("@8", DateTime.Now.ToString("g"));
                    Cmd.Parameters.AddWithValue("@10", ID_Txt.Text);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    Query("UPDATE T_ArchiveRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");
                    T_ArchiveTabAd.Fill(ChequerData.T_Archive);
                    MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_ArchiveTabAd.Fill(ChequerData.T_Archive);
                T_ArchiveBindSour.MoveLast();
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(ID_Txt.Text) && dialog == DialogResult.Yes)
            {
                try
                {
                    Query("INSERT INTO T_ArchiveRecycle (ID, CustName, CIF, Deal, Carton, Type, ArchiveName, C_Date, TxDate, UserID, Notes, Status)" +
                          "SELECT ID, CustName, CIF, Deal, Carton, Type, ArchiveName, C_Date, TxDate, UserID, Notes, Status FROM T_Archive WHERE ID=@0;");
                    Query("DELETE FROM T_Archive WHERE ID=@0;");
                    Query("UPDATE T_ArchiveRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");

                    T_ArchiveTabAd.Fill(ChequerData.T_Archive);
                    T_ArchiveBindSour.MoveLast();
                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
                Close();
                Mainform.Menu_Pan.Show();
        }

        /* Function  */

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.Enabled = Value2;
            CIF_Txt.ReadOnly = Value;
            Deal_Txt.ReadOnly = Value;
            Carton_Txt.ReadOnly = Value;
            Note_Txt.ReadOnly = Value;
            Type_Txt.Enabled = Value2;
            Date_Txt.Enabled = Value2;
            Archive_Txt.Enabled = Value2;
            Status_Txt.Enabled = Value2;
            Login.Instance.Check(Login.Instance.UserName, Date_Txt.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (Date_Txt.Name == obj.FunctionName)
                {
                    Date_Txt.Enabled = Value2;
                }
            }
        }

        public static InputLanguage GetInput(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                {
                    return lang;
                }
            }
            return null;
        }

        private void SwitchInput(InputLanguage layout) => InputLanguage.CurrentInputLanguage = layout;

        private void ProID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            Ctrl = (Control)sender;
            if (Ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is ComboBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is DateTimePicker)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is MaskedTextBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void English_Enter(object sender, EventArgs e)
        {
            SwitchInput(GetInput("english"));
        }

        private void Query(string Value)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            Cmd.Dispose();
            Cmd.Clone();
            Cmd.Connection = Con;
            Cmd.CommandText = Value;
            Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
            Cmd.ExecuteNonQuery();
            Cmd.Parameters.Clear();
            Con.Close();
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            //ID = 1;
            //Print myForm = new Print(null, null, ID_Txt.Text, ID, ChequerSet.T_Cheque, Convert.ToDateTime(Date_Txt.Text), Convert.ToInt32(Carton_Txt.Text), null, null)
            //{
            //    TopLevel = false,
            //};
            //Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            //foreach (var obj in Login.Instance.List)
            //{
            //    if (myForm.Name == obj.FunctionName)
            //    {
            //        M = 1;
            //        panel1.Hide();
            //        panel3.Hide();
            //        Details_Pan.Dock = DockStyle.Fill;
            //        Details_Pan.BringToFront();
            //        Details_Pan.Controls.Clear();
            //        Details_Pan.Controls.Add(myForm);
            //        //myForm.Dock = DockStyle.Fill;
            //        myForm.Show();
            //        break;
            //    }
            //}
            //if (M != 1)
            //{
            //    MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            //}
        }

        private void Deal_Txt_DoubleClick(object sender, EventArgs e)
        {
            Deal_Txt.ReadOnly = false;
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SDeal_Txt.Text))
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Archive WHERE Deal = @0";
                    Cmd.Parameters.AddWithValue("@0", SDeal_Txt.Text);
                    using (OleDbDataAdapter Da = new OleDbDataAdapter(Cmd))
                    {
                        DataTable Dt = new DataTable();
                        Da.Fill(Dt);
                        Cheque_Grid.DataSource = Dt;
                    }
                    Cmd.Parameters.Clear();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Archive - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                T_ArchiveTabAd.Fill(ChequerData.T_Archive);
            }
        }
    }

}
