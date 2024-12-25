using Chequer.Properties;
using System;
using System.Windows.Forms;

namespace Chequer
{
    public partial class SettingsMain : Form
    {
        public SettingsMain()
        {
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | Main Settings";
            Dock = DockStyle.Fill;
        }

        public int M { get; set; }

        // Method to handle button click events and load the corresponding form
        private void LoadForm<T>(Func<T> formFactory) where T : Form
        {
            // Create an instance of the form using the provided factory method
            var myForm = formFactory();
            myForm.TopLevel = false;

            // Check user permissions for the form
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    Menu_Pan.Hide();
                    Details_Pan.Controls.Clear();
                    Details_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                    return;
                }
            }

            // Show a message if the user does not have permission
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        // Event handler for Users button click
        private void Users_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(() => new Users(this));
        }

        // Event handler for Authority button click
        private void Authority_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(() => new Authority(this));
        }

        // Event handler for Printer button click
        private void Printer_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(() => new Printer(this));
        }

        // Event handler for Dealers button click
        private void Dealers_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(() => new Dealers(this));
        }

        // Event handler for Clients button click
        private void Clients_Btn_Click(object sender, EventArgs e)
        {
            LoadForm(() => new Client(this));
        }
    }
}

