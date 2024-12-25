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

        // Property to track permission status
        public int conut { get; set; }

        // Event handler for Cheque button click
        private void Cheque_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new Cheque(null, null, null, null, this));
        }

        // Event handler for Contract button click
        private void Contract_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new Contracted(this));
        }

        // Event handler for Archive button click
        private void Archive_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new Archive(this));
        }

        // Event handler for Advanced Tax button click
        private void AdvancedTax_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new AdvancedTax(null, null, null, null, this));
        }

        // Event handler for Takaful button click
        private void Takaful_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new Takaful(null, null, null, null, this));
        }

        // Event handler for Other button click
        private void Other_Btn_Click(object sender, EventArgs e)
        {
            OpenForm(new TakafulAdd(null, null, null, null, this));
        }

        // Event handler for Takaful panel toggle button click
        private void Takaful_Btn_Click_1(object sender, EventArgs e)
        {
            Takaful_Pan.Visible = !Takaful_Pan.Visible;
        }

        // Method to open a form and check permissions
        private void OpenForm(Form myForm)
        {
            myForm.TopLevel = false;
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);

            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    conut = 1;
                    Menu_Pan.Hide();
                    Takaful_Pan.Hide();
                    Details_Pan.Controls.Add(myForm);
                    myForm.Dock = DockStyle.Fill;
                    myForm.Show();
                    return;
                }
            }

            if (conut != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }
    }
}
