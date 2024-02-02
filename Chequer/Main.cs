using Chequer.Properties;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Chequer

{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);

        private void SetIsLogout(bool value)
        {
            IsLogout = value;
        }

        public Color Tran { get => Color.Transparent; }
        public Color Blue { get => Color.FromArgb(59, 115, 185); }
        public bool IsLogout { get; set; }
        public int M { get; set; }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic dialog = MessageBox.Show("Do You Really Want to Closing The Program?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    var backupFolder = Application.StartupPath + "\\Backup\\";

                    var backupFileName = String.Format("{0}{1}~{2}.mdb",
                        backupFolder, "Chequer",
                        DateTime.Now.ToString("dd-MM-yyyy  hh-mm-ss"));

                    string So = Application.StartupPath +"\\Database\\Chequer.mdb";
                    string De = backupFileName;

                    string backupDir = Resources.PathBackup;
                    var DeletionDays = 2;
                    if (DeletionDays < 10)
                    {
                        try
                        {
                            string[] files = Directory.GetFiles(backupDir);

                            foreach (string file in files)
                            {
                                FileInfo fi = new FileInfo(file);
                                if (fi.CreationTime < DateTime.Now.AddDays(-DeletionDays))
                                {
                                    fi.Delete();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    File.Copy(So, De);
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login.Instance.CheckMain(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                Login.Instance.RoleName = obj.RoleName;
                Text = Resources.AppName + " Home ";
                if (Home_Btn.Name == obj.FunctionName)
                {
                    Home_Btn.Enabled = true;
                    Home_Btn.Tag = obj.FunctionName;
                }
                else if (IIS_Btn.Name == obj.FunctionName)
                {
                    IIS_Btn.Enabled = true;
                    HReception_Btn.Enabled = true;
                    IIS_Btn.Tag = obj.FunctionName;
                }
                else if (Search_Btn.Name == obj.FunctionName)
                {
                    Search_Btn.Enabled = true;
                    HSearch_Btn.Enabled = true;
                    Search_Btn.Tag = obj.FunctionName;
                }
                else if (Report_Btn.Name == obj.FunctionName)
                {
                    Report_Btn.Enabled = true;
                    HReport_Btn.Enabled = true;
                    Report_Btn.Tag = obj.FunctionName;
                }
                else if (Settings_Btn.Name == obj.FunctionName)
                {
                    Settings_Btn.Enabled = true;
                    HSettings_Btn.Enabled = true;
                    Settings_Btn.Tag = obj.FunctionName;
                }
            }

            Home_Btn.Click += Home_Btn_Click;
            HomeBtnEnter(sender, e);

            UserName_Lab.Text = "User Name : " + Login.Instance.UserName;
            label4.Text = "Role : " + Login.Instance.RoleName;
        }

        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            SetIsLogout(true);
            Login.Instance.Show();
            Hide();
        }

        /*Side Panel*/

        //Home;
        public void Home_Btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = Resources.AppName + " " + $"{Login.Instance.UserName}  |  " + $"{Login.Instance.RoleName}";
            Side_Pan.Height = Home_Btn.Height;
            Side_Pan.Top = Home_Btn.Top;
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(Sub_Pan);
        }
        public void HomeBtnEnter(object sender, EventArgs e)
        {
            Home_Btn.Focus();
            Home_Btn.BackColor = Blue;
        }

        public void HomeBtnLeave(object sender, EventArgs e) => Home_Btn.BackColor = Tran;

        //Reception;
        public void ReceptionBtnClick(object sender, EventArgs e)
        {
            Side_Pan.Height = IIS_Btn.Height;
            Side_Pan.Top = IIS_Btn.Top;
            IISMain myForm = new IISMain()
            {
                TopLevel = false

            };
            {
                Login.Instance.Check(Login.Instance.UserName, myForm.Name);
                foreach (var obj in Login.Instance.List)
                {
                    if (myForm.Name == obj.FunctionName)
                    {
                        M = 1;
                        Main_Pan.Controls.Clear();
                        Main_Pan.Controls.Add(myForm);
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
        public void Reception_Btn_Enter(object sender, EventArgs e)
        {
            IIS_Btn.Focus();
            IIS_Btn.BackColor = Blue;
        }

        public void Reception_Btn_Leave(object sender, EventArgs e) => IIS_Btn.BackColor = Tran;

        //Search;
        public void Search_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = Search_Btn.Height;
            Side_Pan.Top = Search_Btn.Top;

            SearchMain myForm = new SearchMain
            {
                TopLevel = false
            };
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Show();
                    break;
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
        public void Search_Btn_Enter(object sender, EventArgs e)
        {
            Search_Btn.Focus();
            Search_Btn.BackColor = Blue;
        }
        public void Search_Btn_Leave(object sender, EventArgs e) => Search_Btn.BackColor = Tran;

        //Report;
        public void Report_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = Report_Btn.Height;
            Side_Pan.Top = Report_Btn.Top;
            ReportMain myForm = new ReportMain
            {
                TopLevel = false
            };
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Show();
                    break;
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
        public void Report_Btn_Enter(object sender, EventArgs e)
        {
            Report_Btn.Focus();
            Report_Btn.BackColor = Blue;
        }
        public void Report_Btn_Leave(object sender, EventArgs e) => Report_Btn.BackColor = Tran;

        //Settings;
        public void Settings_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = Settings_Btn.Height;
            Side_Pan.Top = Settings_Btn.Top;
            SettingsMain myForm = new SettingsMain
            {
                TopLevel = false
            };
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(myForm);
                    myForm.Show();
                    break;
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
        public void Settings_Btn_Enter(object sender, EventArgs e)
        {
            Settings_Btn.Focus();
            Settings_Btn.BackColor = Blue;
        }
        public void Settings_Btn_Leave(object sender, EventArgs e) => Settings_Btn.BackColor = Tran;

        //About;
        public void About_Btn_Click(object sender, EventArgs e)
        {
            Side_Pan.Height = About_Btn.Height;
            Side_Pan.Top = About_Btn.Top;
            using (About myForm = new About())
            {
                myForm.ShowDialog();
            }
        }
        public void About_Btn_Enter(object sender, EventArgs e)
        {
            About_Btn.Focus();
            About_Btn.BackColor = Blue;
        }
        public void About_Btn_Leave(object sender, EventArgs e) => About_Btn.BackColor = Tran;

        //Sigout;

        private void CopyRight_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Login.Instance.RoleID) == 1 || Convert.ToInt32(Login.Instance.RoleID) == 2)
            {
                SetIsLogout(true);
                Login.Instance.Show();
                Hide();
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (Width <= 700)
            {
                Menu_Pan.Width = 60;
            }
            else
            {
                Menu_Pan.Width = 175;
            }
        }
    }
}
