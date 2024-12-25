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
        // Database connection object

        public Main() => InitializeComponent();

        // Color properties
        public Color Tran => Color.Transparent;
        public Color Blue => Color.FromArgb(59, 115, 185);

        // Public properties
        public bool IsLogout { get; set; }
        public int count { get; set; }

        // Property to set logout status
        private void SetIsLogout(bool value) => IsLogout = value;

        // Event handler for form closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var dialog = MessageBox.Show("Do You Really Want to Close The Program?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    BackupDatabase();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        // Method to backup the database
        private void BackupDatabase()
        {
            // Define the backup folder and file name with current date and time
            var backupFolder = Path.Combine(Application.StartupPath, "Backup");
            var backupFileName = $"{backupFolder}\\Chequer~{DateTime.Now:dd-MM-yyyy  hh-mm-ss}.mdb";
            var sourceFile = Path.Combine(Application.StartupPath, "Database\\Chequer.mdb");
            var backupDir = Resources.PathBackup;
            var deletionDays = 2;

            // Delete old backups if deletionDays is less than 10
            if (deletionDays < 10)
            {
                try
                {
                    foreach (var file in Directory.GetFiles(backupDir))
                    {
                        var fileInfo = new FileInfo(file);
                        if (fileInfo.CreationTime < DateTime.Now.AddDays(-deletionDays))
                        {
                            fileInfo.Delete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            // Copy the current database file to the backup location
            File.Copy(sourceFile, backupFileName);
        }


        // Event handler for form load
        private void Main_Load(object sender, EventArgs e)
        {
            Login.Instance.CheckMain(Login.Instance.UserName);
            foreach (var obj in Login.Instance.List)
            {
                Login.Instance.RoleName = obj.RoleName;
                Text = $"{Resources.AppName} Home";
                EnableButton(obj.FunctionName);
            }

            Home_Btn.Click += Home_Btn_Click;
            HomeBtnEnter(sender, e);

            UserName_Lab.Text = $"User Name : {Login.Instance.UserName}";
            label4.Text = $"Role : {Login.Instance.RoleName}";
        }

        // Method to enable buttons based on user role
        private void EnableButton(string functionName)
        {
            switch (functionName)
            {
                case nameof(Home_Btn):
                    EnableButton(Home_Btn, functionName);
                    break;
                case nameof(IIS_Btn):
                    EnableButton(IIS_Btn, functionName);
                    HReception_Btn.Enabled = true;
                    break;
                case nameof(Search_Btn):
                    EnableButton(Search_Btn, functionName);
                    HSearch_Btn.Enabled = true;
                    break;
                case nameof(Report_Btn):
                    EnableButton(Report_Btn, functionName);
                    HReport_Btn.Enabled = true;
                    break;
                case nameof(Settings_Btn):
                    EnableButton(Settings_Btn, functionName);
                    HSettings_Btn.Enabled = true;
                    break;
            }
        }

        // Helper method to enable a button and set its tag
        private void EnableButton(Button button, string functionName)
        {
            button.Enabled = true;
            button.Tag = functionName;
        }

        // Event handler for sign out button click
        private void Singout_Btn_Click(object sender, EventArgs e)
        {
            SetIsLogout(true);
            Login.Instance.Show();
            Hide();
        }

        // Event handler for home button click
        public void Home_Btn_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = $"{Resources.AppName} {Login.Instance.UserName} | {Login.Instance.RoleName}";
            UpdateSidePanel(Home_Btn);
            Main_Pan.Controls.Clear();
            Main_Pan.Controls.Add(Sub_Pan);
        }

        // Event handler for home button enter
        public void HomeBtnEnter(object sender, EventArgs e)
        {
            Home_Btn.Focus();
            Home_Btn.BackColor = Blue;
        }

        // Event handler for home button leave
        public void HomeBtnLeave(object sender, EventArgs e) => Home_Btn.BackColor = Tran;

        // Event handler for reception button click
        public void ReceptionBtnClick(object sender, EventArgs e)
        {
            UpdateSidePanel(IIS_Btn);
            LoadForm(new IISMain());
        }

        // Event handler for reception button enter
        public void Reception_Btn_Enter(object sender, EventArgs e)
        {
            IIS_Btn.Focus();
            IIS_Btn.BackColor = Blue;
        }

        // Event handler for reception button leave
        public void Reception_Btn_Leave(object sender, EventArgs e) => IIS_Btn.BackColor = Tran;

        // Event handler for search button click
        public void Search_Btn_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(Search_Btn);
            LoadForm(new SearchMain());
        }

        // Event handler for search button enter
        public void Search_Btn_Enter(object sender, EventArgs e)
        {
            Search_Btn.Focus();
            Search_Btn.BackColor = Blue;
        }

        // Event handler for search button leave
        public void Search_Btn_Leave(object sender, EventArgs e) => Search_Btn.BackColor = Tran;

        // Event handler for report button click
        public void Report_Btn_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(Report_Btn);
            LoadForm(new ReportMain());
        }

        // Event handler for report button enter
        public void Report_Btn_Enter(object sender, EventArgs e)
        {
            Report_Btn.Focus();
            Report_Btn.BackColor = Blue;
        }

        // Event handler for report button leave
        public void Report_Btn_Leave(object sender, EventArgs e) => Report_Btn.BackColor = Tran;

        // Event handler for settings button click
        public void Settings_Btn_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(Settings_Btn);
            LoadForm(new SettingsMain());
        }

        // Event handler for settings button enter
        public void Settings_Btn_Enter(object sender, EventArgs e)
        {
            Settings_Btn.Focus();
            Settings_Btn.BackColor = Blue;
        }

        // Event handler for settings button leave
        public void Settings_Btn_Leave(object sender, EventArgs e) => Settings_Btn.BackColor = Tran;

        // Event handler for about button click
        public void About_Btn_Click(object sender, EventArgs e)
        {
            UpdateSidePanel(About_Btn);
            using (var myForm = new About())
            {
                myForm.ShowDialog();
            }
        }

        // Event handler for about button enter
        public void About_Btn_Enter(object sender, EventArgs e)
        {
            About_Btn.Focus();
            About_Btn.BackColor = Blue;
        }

        // Event handler for about button leave
        public void About_Btn_Leave(object sender, EventArgs e) => About_Btn.BackColor = Tran;

        // Event handler for copyright click
        private void CopyRight_Click(object sender, EventArgs e)
        {
            if (Login.Instance.RoleID == "1" || Login.Instance.RoleID == "2")
            {
                SetIsLogout(true);
                Login.Instance.Show();
                Hide();
            }
        }

        // Event handler for form size changed
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Menu_Pan.Width = Width <= 700 ? 60 : 175;
        }

        // Method to update the side panel position and height
        private void UpdateSidePanel(Button button)
        {
            Side_Pan.Height = button.Height;
            Side_Pan.Top = button.Top;
        }

        // Method to load a form into the main panel
        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            Login.Instance.Check(Login.Instance.UserName, form.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (form.Name == obj.FunctionName)
                {
                    count = 1;
                    Main_Pan.Controls.Clear();
                    Main_Pan.Controls.Add(form);
                    form.Show();
                    break;
                }
            }
            if (count != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
    }
}
