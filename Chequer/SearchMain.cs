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
        public int M { get; set; }

        private void Cheque_Btn_Click(object sender, EventArgs e)
        {
            SeCheque myForm = new SeCheque()
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

        private void Contract_Btn_Click(object sender, EventArgs e)
        {
            SeContracted myForm = new SeContracted()
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

        private void Archive_Btn_Click(object sender, EventArgs e)
        {
            SeArchive myForm = new SeArchive()
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
