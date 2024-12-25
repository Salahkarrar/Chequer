using Chequer.Properties;
using System;
using System.Windows.Forms;

namespace Chequer
{
    public partial class ReportMain : Form
    {
        public ReportMain()
        {
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | Main Report";
            Dock = DockStyle.Fill;
        }

        public int count { get; set; }

        // Method to handle button click events and load the corresponding report form
        private void LoadReportForm<T>(Func<T> formFactory) where T : Form
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

        // Event handler for General button click
        private void General_Btn_Click(object sender, EventArgs e)
        {
            LoadReportForm(() => new Report(this));
        }

        // Event handler for Accounting button click
        private void Accounting_Btn_Click(object sender, EventArgs e)
        {
            LoadReportForm(() => new TakafulReport(this));
        }

        // Event handler for Tax button click
        private void Tax_Btn_Click(object sender, EventArgs e)
        {
            LoadReportForm(() => new AdvancedTaxReport(this));
        }
    }
}
