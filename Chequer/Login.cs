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
        // Singleton instance of the Login form
        private static Login _instance;
        // Database connection object
        private readonly OleDbConnection _connection;

        // Constructor
        public Login()
        {
            InitializeComponent();
            // Initialize the database connection with the path from resources
            _connection = new OleDbConnection(Resources.Path);
        }

        // Properties to store various serial numbers and user information
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

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Singleton instance property
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Login();
                        }
                    }
                }
                return _instance;
            }
        }

        // Event handler for form load
        private void Login_Load(object sender, EventArgs e)
        {
            GetSerialNumbers(); // Retrieve serial numbers
            _instance = this; // Set the singleton instance

            try
            {
                OpenConnection(); // Open database connection
                ValidateDevice(); // Validate the device
                CheckLicense(); // Check the license
            }
            catch (Exception ex)
            {
                // Show error message and update connection status
                ShowErrorMessage("Problem in Check license. Please Call The System Administrator", ex, "Login - 1000");
                UpdateConnectionStatus(Color.Red, "No Connection");
            }
        }

        // Event handler for login button click
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection(); // Open database connection
                ValidateUser(); // Validate the user
            }
            catch (Exception ex)
            {
                // Show error message
                ShowErrorMessage("Can't Connect to Database, Please Recheck The Server or Call System Administrator", ex, "Error Login - 1001");
            }
        }

        // Event handler for exit button click
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            _connection.Dispose(); // Dispose the connection
            MessageBoxEx.Show("GoodBye", "Exit", 700); // Show goodbye message
            Application.Exit(); // Exit the application
        }

        // Event handler for change password menu item click
        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var changePassForm = new ChangePass())
            {
                changePassForm.ShowDialog(); // Show change password form
            }
        }

        // Method to edit button icon and text
        public void Edit_Ico(Button button, string text, Image image)
        {
            button.Text = text;
            button.Image = image;
            button.ImageAlign = ContentAlignment.TopLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        // Method to check user authorization for a function
        public void Check(string userName, string functionName)
        {
            ExecuteQuery(() =>
            {
                List = _connection.Query<PROAuth>(
                    "SELECT T_Function.FunctionName, T_Roles.RoleName " +
                    "FROM ((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) " +
                    "INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) " +
                    "INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                    "WHERE T_Users.UserName = @UserName AND T_Function.FunctionName = @FunctionName",
                    new { UserName = userName, FunctionName = functionName }).ToList();
            }, "Error Login - 1002");
        }

        // Method to check main user authorization
        public void CheckMain(string userName)
        {
            ExecuteQuery(() =>
            {
                List = _connection.Query<PROAuth>(
                    "SELECT T_Function.FunctionName, T_Roles.RoleName " +
                    "FROM ((T_Function INNER JOIN T_FunctionRole ON T_Function.FunctionID = T_FunctionRole.FunctionID) " +
                    "INNER JOIN T_Roles ON T_FunctionRole.RoleID = T_Roles.RoleID) " +
                    "INNER JOIN T_Users ON T_Roles.RoleID = T_Users.RoleID " +
                    "WHERE T_Users.UserName = @UserName",
                    new { UserName = userName }).ToList();
            }, "Error Login - 1003");
        }

        // Method to get printer information
        public void Printer(string rName, string userId)
        {
            ExecuteQuery(() =>
            {
                List2 = _connection.Query<PrinterPro>(
                    "SELECT * FROM T_Printer WHERE RName = @RName AND UserID = @UserID",
                    new { RName = rName, UserID = userId }).ToList();
            }, "Error Login - 1003");
        }

        // Method to get serial numbers
        private void GetSerialNumbers()
        {
            SerialNum = GetWmiProperty("Win32_BaseBoard", "SerialNumber");
            SerialNum1 = GetWmiProperty("WIN32_BIOS", "SerialNumber");
        }

        // Method to get WMI property
        private string GetWmiProperty(string wmiClass, string propertyName)
        {
            var searcher = new ManagementObjectSearcher($"SELECT * FROM {wmiClass}");
            foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
            {
                return obj[propertyName]?.ToString();
            }
            return string.Empty;
        }

        // Method to open database connection
        private void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        // Method to validate the device
        private void ValidateDevice()
        {
            var command = new OleDbCommand("SELECT * FROM T_Devices WHERE SerialNum1 = @SerialNum", _connection);
            command.Parameters.AddWithValue("@SerialNum", SerialNum);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                DSerial1 = reader["SerialNum1"].ToString();
                DSerial2 = reader["SerialNum2"].ToString();
            }

            if (SerialNum != DSerial1 || SerialNum1 != DSerial2)
            {
                MessageBox.Show("The App Not Legal Please Call The System Administrator", "Legal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // Method to check the license
        private void CheckLicense()
        {
            if (DateTime.Today <= DateTime.ParseExact(Resources.ExpairdDate, "yyyy-MM-dd", null))
            {
                UpdateConnectionStatus(Color.Lime, "Good");
            }
            else
            {
                throw new Exception("License check failed.");
            }
        }

        // Method to validate the user
        private void ValidateUser()
        {
            var command = new OleDbCommand("SELECT * FROM T_Users WHERE PWord = @Password", _connection);
            command.Parameters.AddWithValue("@Password", PassWord.Text);

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                ID = reader["ID"].ToString();
                RoleID = reader["RoleId"].ToString();
                UserName = reader["UserName"].ToString();
                UserID = reader["UserID"].ToString();

                Hide();
                PassWord.Text = string.Empty;
                var mainForm = new Main();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBoxEx.Show("Password Not Correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                PassWord.Text = string.Empty;
            }
        }

        // Method to execute a query with error handling
        private void ExecuteQuery(Action queryAction, string errorMessage)
        {
            try
            {
                OpenConnection();
                queryAction();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Problem in Database, Can't Get Your Data.", ex, errorMessage);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Method to show error message
        private void ShowErrorMessage(string message, Exception ex, string errorCode)
        {
            MessageBox.Show($"{message}\r\n{ex.Message}", errorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Method to update connection status
        private void UpdateConnectionStatus(Color color, string text)
        {
            Conn_Status.ForeColor = color;
            Conn_Status.Text = text;
        }
    }
}
