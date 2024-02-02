using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class ChangePass : Form
    {
        public ChangePass() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public string UserName { get; set; }
        public string ID { get; set; }
        public Control Ctrl { get; set; }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            var c = 0;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    Cmd.Connection = Con;
                    Cmd.CommandText = "SELECT * FROM T_Users WHERE PWord=@0";
                    Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        c += 1;
                        UserName = Reader["UserName"].ToString();
                        ID = Reader["ID"].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                    if (c == 1)
                    {
                        groupBox1.Enabled = true;
                        UserName_Txt.Text = UserName;
                        New_Txt.Focus();
                    }
                    else
                    {
                        MessageBoxEx.Show("Password Not Correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                        PassWord.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Connect to Database, Please Recheck The Server or Call System Administrator" + "\r\n" + ex.Message, "Error Change Password - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (UserName_Txt.Text != null && New_Txt.Text == Confirm_Txt.Text)
            {
                //Con.Close();
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "UPDATE T_Users SET PWord=@0 WHERE UserName=@1";
                    Cmd.Parameters.AddWithValue("@0", New_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", UserName_Txt.Text);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    PassWord.Clear();
                    New_Txt.Clear();
                    Confirm_Txt.Clear();
                    UserName_Txt.Clear();
                    groupBox1.Enabled = false;
                    PassWord.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Another Password" + "\r\n" + ex.Message, "Change Password - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The User Name Can't be Empty or Your New Password & Confirm Password not Equal, Please Try Again.", "Error Changed Password - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Function */

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

    }
}
