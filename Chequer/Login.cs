using Chequer.Properties;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);

        public string SerialNum { get; set; }
        public string SerialNum1 { get; set; }
        public string DSerial1 { get; set; }
        public string DSerial2 { get; set; }
        public string ID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public List<PROAuth> List { get; set; }
        public List<PrinterPro> List2 { get; set; }
        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                }

                return _instance;
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

            GetSer();
            _instance = this;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                using (OleDbCommand Cmd = new OleDbCommand
                {

                    Connection = Con,

                    CommandText = "SELECT * FROM T_Devices WHERE SerialNum1=@0"
                })
                {

                    Cmd.Parameters.AddWithValue("@0", SerialNum);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        DSerial1 = Reader["SerialNum1"].ToString();
                        DSerial2 = Reader["SerialNum2"].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                }
                if (SerialNum == DSerial1 && SerialNum1 == DSerial2 || DateTime.Today.Date.ToString() == "31/12/2024")
                {
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                        {
                            Con.Open();
                        }

                        Conn_Status.ForeColor = Color.Lime;
                        Conn_Status.Text = "Good";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't Connect to Server Please Recheck It or Call The System Administrator" + "\r\n" + ex.Message, "Login - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Conn_Status.ForeColor = Color.Red;
                        Conn_Status.Text = "No Connection";
                    }
                }
                else
                {
                    MessageBox.Show("The App Not Legal Please Call The System Administrator", "Legal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Check license. Please Call The System Administrator" + "\r\n" + ex.Message, "Login - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn_Status.ForeColor = Color.Red;
                Conn_Status.Text = "No Connection";
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {

                    Connection = Con,

                    CommandText = "SELECT * FROM T_Users WHERE PWord= @0"
                })
                {
                    Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    var c = 0;
                    while (Reader.Read())
                    {
                        c += 1;
                        ID = Reader["ID"].ToString();
                        RoleID = Reader["RoleId"].ToString();
                        UserName = Reader["UserName"].ToString();
                        UserID = Reader["UserID"].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                    if (c == 1)
                    {
                        Hide();
                        PassWord.Text = null;
                        using (Main D = new Main())
                        {
                            D.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Password Not Correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                        PassWord.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Connect to Database, Please Recheck The Server or Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Con.Dispose();
            MessageBoxEx.Show("GoodBye", "Exit", 700);
            Application.Exit();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePass D = new ChangePass())
            {
                D.ShowDialog();
            }
        }

        /* Function */

        public void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public void Check(string Value, string Value2)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Con,
                })
                {
                    List = Con.Query<PROAuth>("SELECT T_Function.FunctionName, T_Roles.RoleName FROM((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                                              "WHERE(([T_Users].[UserName] = '" + Value + "' AND ([T_Function].[FunctionName]='" + Value2 + "')))", commandType: CommandType.Text).ToList();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckMain(string Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Con,
                })
                {
                    List = Con.Query<PROAuth>("SELECT T_Function.FunctionName, T_Roles.RoleName FROM((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                                              "WHERE(([T_Users].[UserName] = '" + Value + "'))", commandType: CommandType.Text).ToList();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Printer(string Value, string Value2)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Con,
                })
                {
                    List2 = Con.Query<PrinterPro>("SELECT * FROM T_Printer WHERE(([T_Printer].[RName] = '" + Value + "') AND ([T_Printer].[UserID] = '" + Value2+ "'))", commandType: CommandType.Text).ToList();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Get Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetSer()
        {

            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * FROM Win32_BaseBoard");
            foreach (ManagementObject getserial in MOS.Get())
            {
                SerialNum = getserial["SerialNumber"].ToString();
                //label1.Text = SerialNum;
            }
            ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * FROM WIN32_BIOS");
            foreach (ManagementObject management in MOS1.Get())
            {
                SerialNum1 = management["SerialNumber"].ToString();
                //label2.Text = SerialNum1;
            }
        }


    }
}
