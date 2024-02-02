using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Printer : Form
    {
        public Printer(SettingsMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | Chequer | Settings - Printer";
            Dock = DockStyle.Fill;
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public SettingsMain Mainform { get; set; } = null;
        public Control Ctrl;
        public object ID { get; set; }
        public string V { get; set; }
        public string R { get; set; }

        protected internal void Printer_Load(object sender, EventArgs e)
        {
            t_PrinterTableAdapter.Fill(CoSet.T_Printer);
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                Default_Txt.Items.Add(pkInstalledPrinters);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Default_Txt.SelectedItem != null)
                {
                    CoSet.T_Printer.AddT_PrinterRow(CoSet.T_Printer.NewT_PrinterRow());
                    t_PrinterBindingSource.MoveLast();
                    R = label3.Text;
                    V = Default_Txt.Text;
                    Query("INSERT INTO T_Printer (Printer,RName,UserID) VALUES (@0,@1,@2)");
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    t_PrinterTableAdapter.Fill(CoSet.T_Printer);
                }
                else
                {
                    MessageBoxEx.Show("Please Choose Printer.", "Error Printer - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The User ID Can't Duplicated, Please Delete The Printer First & Try Again." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Printer - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Menu_Pan.Show();
        }

        private void ProID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            Ctrl = (Control)sender;
            if (Ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is ComboBox)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else if (Ctrl is DateTimePicker)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
                else
                    return;
            }
        }

        private void Query(string Value)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            Cmd.Dispose();
            Cmd.Clone();
            Cmd.Connection = Con;
            Cmd.CommandText = Value;
            Cmd.Parameters.AddWithValue("@0", V);
            Cmd.Parameters.AddWithValue("@1", R);
            Cmd.Parameters.AddWithValue("@2", $"{Login.Instance.UserID}");
            Cmd.ExecuteNonQuery();
            Cmd.Parameters.Clear();
            Con.Close();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM T_Printer WHERE UserID = @0";
                    Cmd.Parameters.AddWithValue("@0", $"{Login.Instance.UserID}");
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
