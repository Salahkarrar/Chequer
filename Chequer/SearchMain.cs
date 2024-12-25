using Chequer.Properties;
using System;
using System.Windows.Forms;

namespace Chequer
{
    public partial class SearchMain : Form
    {
        public SearchMain()
        {
            InitializeComponent();
            ActiveForm.Text = Resources.AppName + " Search Main";
            Dock = DockStyle.Fill;
        }

        public int count { get; set; }

        // Method to handle button click events and load the corresponding search form
        private void LoadSearchForm<T>(Func<T> formFactory) where T : Form
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
                    count = 1;
                    Menu_Pan.Hide();
                    Details_Pan.Controls.Clear();
                    Details_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                    return;
                }
            }

            // Show a message if the user does not have permission
            if (count != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        // Event handler for Cheque button click
        private void Cheque_Btn_Click(object sender, EventArgs e)
        {
            LoadSearchForm(() => new SeCheque());
        }

        // Event handler for Contract button click
        private void Contract_Btn_Click(object sender, EventArgs e)
        {
            LoadSearchForm(() => new SeContracted());
        }

        // Event handler for Archive button click
        private void Archive_Btn_Click(object sender, EventArgs e)
        {
            LoadSearchForm(() => new SeArchive());
        }
    }
}
