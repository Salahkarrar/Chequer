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

        private void Users_Btn_Click(object sender, EventArgs e)
        {
            Users myForm = new Users(this)
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

        private void Authority_Btn_Click(object sender, EventArgs e)
        {
            Authority myForm = new Authority(this)
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

        private void Printer_Btn_Click(object sender, EventArgs e)
        {
            Printer myForm = new Printer(this)
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

        private void Dealers_Btn_Click(object sender, EventArgs e)
        {
            Dealers myForm = new Dealers(this)
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

        private void Clients_Btn_Click(object sender, EventArgs e)
        {
            Client myForm = new Client(this)
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
