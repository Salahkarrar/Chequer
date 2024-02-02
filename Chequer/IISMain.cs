using Chequer.Properties;
using System;
using System.Windows.Forms;

namespace Chequer
{
    public partial class IISMain : Form
    {
        public IISMain()
        {
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS Main";
            Dock = DockStyle.Fill;
        }
        public int M { get; set; }

        private void Cheque_Btn_Click(object sender, EventArgs e)
        {
            Cheque myForm = new Cheque(null, null, null, null, this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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
            Contracted myForm = new Contracted(this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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
            Archive myForm = new Archive(this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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

        private void AdvancedTax_Btn_Click(object sender, EventArgs e)
        {
            AdvancedTax myForm = new AdvancedTax(null, null, null, null, this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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

        private void Takaful_Btn_Click(object sender, EventArgs e)
        {
            Takaful myForm = new Takaful(null, null, null, null, this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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

        private void Other_Btn_Click(object sender, EventArgs e)
        {
            TakafulAdd myForm = new TakafulAdd(null, null, null, null, this)
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
                    Takaful_Pan.Hide();
                    //Details_Pan.Controls.Clear();
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

        private void Takaful_Btn_Click_1(object sender, EventArgs e)
        {
            if (Takaful_Pan.Visible == false)
                Takaful_Pan.Show();
            else
                Takaful_Pan.Hide();
        }
    }
}
