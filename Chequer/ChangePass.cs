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

        // Connection to the database
        public OleDbConnection _connection { get; } = new OleDbConnection(Resources.Path);

        // Command to execute SQL queries
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();

        // User information
        public string UserName { get; set; }
        public string ID { get; set; }

        // Control for handling key events
        public Control Ctrl { get; set; }

        private void PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                Cmd.Connection = _connection;
                Cmd.CommandText = "SELECT * FROM T_Users WHERE PWord=@0";
                Cmd.Parameters.AddWithValue("@0", PassWord.Text);

                using (OleDbDataReader reader = Cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserName = reader["UserName"].ToString();
                        ID = reader["ID"].ToString();
                        groupBox1.Enabled = true;
                        UserName_Txt.Text = UserName;
                        New_Txt.Focus();
                    }
                    else
                    {
                        MessageBoxEx.Show("Incorrect Password, Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                        PassWord.Text = null;
                    }
                }

                Cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrieve Your Data, Call System Administrator" + "\r\n" + ex.Message, "Error Change Password - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName_Txt.Text) || New_Txt.TextLength <= 4 || New_Txt.Text != Confirm_Txt.Text)
            {
                MessageBox.Show("The User Name can't be empty, or your new password and confirm password do not match, and the new password must be greater than 4 characters. Please try again.", "Error Changed Password - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            const string statusChanged = "Changed";

            try
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                Cmd.Connection = _connection;
                Cmd.CommandText = "UPDATE T_Users SET PWord=@1, UserStatus=@2 WHERE ID=@0";
                Cmd.Parameters.AddWithValue("@1", New_Txt.Text);
                Cmd.Parameters.AddWithValue("@2", statusChanged);
                Cmd.Parameters.AddWithValue("@0", ID);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();

                MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 700);

                ClearForm();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't save your data. Please check your data or call administration." + "\r\n" + ex.Message, "Change Password - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            PassWord.Clear();
            New_Txt.Clear();
            Confirm_Txt.Clear();
            UserName_Txt.Clear();
            groupBox1.Enabled = false;
            PassWord.Focus();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            Ctrl = sender as Control;
            if (Ctrl != null)
            {
                SelectNextControl(Ctrl, true, true, true, true);
            }
        }
    }
}
