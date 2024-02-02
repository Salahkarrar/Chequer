using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Users : Form
    {
        public Users(SettingsMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | Chequer | Settings - Users";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public SettingsMain Mainform { get; set; } = null;
        public Control Ctrl;
        public object ID { get; set; }

        protected internal void Users_Load(object sender, EventArgs e)
        {
            RolesTabAd.Fill(ChequerSet.T_Roles);
            UsersTabAd.Fill(ChequerSet.T_Users);
            try
            {
                Enabled = true;
                Edit(true, false);
                RolesTabAd.Fill(ChequerSet.T_Roles);
                UsersTabAd.Fill(ChequerSet.T_Users);
                if (Convert.ToInt32(Login.Instance.RoleID) == 1 || Convert.ToInt32(Login.Instance.RoleID) == 2)
                {
                    Delete_Btn.Enabled = true;
                }
                else
                {
                    Delete_Btn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                ChequerSet.T_Users.AddT_UsersRow(ChequerSet.T_Users.NewT_UsersRow());
                UsersBindSour.MoveLast();
                Name_Txt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(UserID_Txt.Text) && !string.IsNullOrEmpty(Password_Txt.Text) && Password_Txt.TextLength >= 4 &&
                    !string.IsNullOrEmpty(Auth_Txt.Text))
                {
                    Edit(true, false);
                    UsersTabAd.Insert(Convert.ToInt32(Auth_Txt.SelectedValue), Name_Txt.Text, Password_Txt.Text, Convert.ToInt32(UserID_Txt.Text));
                    MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    UsersTabAd.Fill(ChequerSet.T_Users);
                    UsersBindSour.MoveLast();
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again" + "\r\n" + "Choose Strong Password", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Name,Password and Phone Can't Duplicated, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit_Btn.Text == "Edit")
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
                    UsersBindSour.EndEdit();
                    UsersTabAd.Update(ChequerSet.T_Users);
                    MessageBoxEx.Show("Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                UsersBindSour.CancelEdit();
                UsersTabAd.Fill(ChequerSet.T_Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Cancel Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM T_Users WHERE UserName=@0";
                    Cmd.Parameters.AddWithValue("@0", User_Grid.CurrentRow.Cells[1].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    UsersTabAd.Fill(ChequerSet.T_Users);
                    UsersBindSour.MoveFirst();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void User_Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
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

        // User Function //

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            Password_Txt.ReadOnly = Value;
            UserID_Txt.ReadOnly = Value;
            Auth_Txt.Enabled = Value2;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }

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

        private void User_Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dr in User_Grid.Rows)
            {
                if (dr.Cells[0].Value.ToString() == "3")
                {
                    dr.Visible = false;
                }
            }
        }
    }
}
