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
        public int M { get; set; }

        private void General_Btn_Click(object sender, EventArgs e)
        {
            Report myForm = new Report(this)
            {
                TopLevel = false
            };
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
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void Accounting_Btn_Click(object sender, EventArgs e)
        {
            TakafulReport myForm = new TakafulReport(this)
            {
                TopLevel = false
            };
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
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }

        private void Tax_Btn_Click(object sender, EventArgs e)
        {
            AdvancedTaxReport myForm = new AdvancedTaxReport(this)
            {
                TopLevel = false
            };
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
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
    }
}
