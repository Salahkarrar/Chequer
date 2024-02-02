using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class AdvancedTax : Form
    {
        public AdvancedTax(AdvancedTax Rep, string ID, string Name, string Passport, IISMain Main)
        {
            Id = ID;
            Na = Name;
            Pass = Passport;
            Subform = Rep;
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - AdvancedTax";
        }
        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public decimal Num { get; set; } = 1;
        public string BiNum { get; set; }
        public AdvancedTax Subform { get; set; } = null;
        public IISMain Mainform { get; set; } = null;
        public string Id { get; set; }
        public string Na { get; set; }
        public string Pass { get; set; }
        public int ID { get; set; }
        public Control Ctrl { get; set; }
        public int M { get; set; }


        public void AdvancedTax_Load(object sender, EventArgs e)
        {

            T_AdvancedTaxTabAd.Fill(ChequerSet.T_AdvancedTax);
            T_DealerTabAd.Fill(ChequerSet.T_Dealer);
            if (Subform == null)
            {
                T_AdvancedTaxTabAd.FillByDate(ChequerSet.T_AdvancedTax, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
            }
            else if (Subform != null)
            {
                Enabled = true;
                Edit(true, false);
                T_AdvancedTaxTabAd.FillByID(ChequerSet.T_AdvancedTax, Id);
            }
            Login.Instance.Check(Login.Instance.UserName, Delete_Btn.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (Delete_Btn.Name == obj.FunctionName)
                {
                    Delete_Btn.Enabled = true;
                    Delete_Btn.Show();
                }
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                ChequerSet.T_AdvancedTax.AddT_AdvancedTaxRow(ChequerSet.T_AdvancedTax.NewT_AdvancedTaxRow());
                T_AdvancedTaxBindSour.MoveLast();
                Name_Txt.Focus();
                Date_Txt.Text = DateTime.Now.ToString("d");
                PayDate_Txt.Text = DateTime.Now.ToString("d");
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Create New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            ID = 10;
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Dealer_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text)
                && !string.IsNullOrEmpty(Type_Txt.Text) && !string.IsNullOrEmpty(TaxID_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text)
                && !string.IsNullOrEmpty(DAmount_Txt.Text) && !string.IsNullOrEmpty(InvoiceAmt_Txt.Text) && !string.IsNullOrEmpty(Tax_Txt.Text)
                && !string.IsNullOrEmpty(InvoiceNo_Txt.Text) && !string.IsNullOrEmpty(Account_Txt.Text) && !string.IsNullOrEmpty(PayDate_Txt.Text))
            {
                Edit(true, false);
                try
                {
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "INSERT INTO T_AdvancedTax (CustName, DealerName, Type, Deal,CDate, Amount, " +
                                      "InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TaxID, TxDate) VALUES " +
                                      "(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,'"+ Login.Instance.UserID + "','"+ TaxID_Txt.Text + "','"+ DateTime.Now+ "')";
                    Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", Dealer_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Type_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", Deal_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", Date_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", DAmount_Txt.Text);
                    Cmd.Parameters.AddWithValue("@6", InvoiceAmt_Txt.Text);
                    Cmd.Parameters.AddWithValue("@7", Tax_Txt.Text);
                    Cmd.Parameters.AddWithValue("@8", InvoiceNo_Txt.Text);
                    Cmd.Parameters.AddWithValue("@9", Account_Txt.Text);
                    Cmd.Parameters.AddWithValue("@10", PayDate_Txt.Text);
                    //Cmd.Parameters.AddWithValue("@11", $"{Login.Instance.UserID}");
                    //Cmd.Parameters.AddWithValue("@12", TaxID_Txt.Text);
                    //Cmd.Parameters.AddWithValue("@13", DateTime.Now);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    //T_AdvancedTaxTabAd.Insert(Name_Txt.Text, Dealer_Txt.Text, Type_Txt.SelectedItem.ToString(), Convert.ToInt32(Deal_Txt.Text), Date_Txt.Value, Convert.ToDouble(DAmount_Txt.Text),
                    //    Convert.ToDouble(InvoiceAmt_Txt.Text), Convert.ToDouble(Tax_Txt.Text), InvoiceNo_Txt.Text, Account_Txt.Text, PayDate_Txt.Value,
                    //                     Convert.ToInt32($"{Login.Instance.UserID}"), DateTime.Now, TaxID_Txt.Text, Convert.ToInt32(ID_Txt.Text));
                    T_AdvancedTaxTabAd.FillByDate(ChequerSet.T_AdvancedTax, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    T_AdvancedTaxBindSour.MoveLast();
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    New_Btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AdvancedTax_Grid.CurrentRow.Cells[0].Value.ToString()) && Edit_Btn.Text == "Edit")
            {
                Edit(false, true);
                New_Btn.Enabled = false;
                Save_Btn.Enabled = false;

                Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
            }
            else if (Edit_Btn.Text == "Update")
            {
                Edit(true, false);
                New_Btn.Enabled = true;

                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                try
                {
                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "UPDATE T_AdvancedTax SET CustName = @0, DealerName = @1, Type = @2, Deal=@3,CDate = @4, Amount = @5, " +
                                      "InvoiceAmount=@6,Tax=@7,InvoiceNo=@8,Account = @9,CDate2 = @10, UserID=@11,TaxID=@12 WHERE ID = @13";
                    Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", Dealer_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Type_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", Deal_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", Date_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", DAmount_Txt.Text);
                    Cmd.Parameters.AddWithValue("@6", InvoiceAmt_Txt.Text);
                    Cmd.Parameters.AddWithValue("@7", Tax_Txt.Text);
                    Cmd.Parameters.AddWithValue("@8", InvoiceNo_Txt.Text);
                    Cmd.Parameters.AddWithValue("@9", Account_Txt.Text);
                    Cmd.Parameters.AddWithValue("@10", PayDate_Txt.Text);
                    Cmd.Parameters.AddWithValue("@11", $"{Login.Instance.UserID}");
                    Cmd.Parameters.AddWithValue("@12", TaxID_Txt.Text);
                    Cmd.Parameters.AddWithValue("@13", ID_Txt.Text);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");

                    T_AdvancedTaxTabAd.FillByDate(ChequerSet.T_AdvancedTax, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_AdvancedTaxTabAd.FillByDate(ChequerSet.T_AdvancedTax, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                T_AdvancedTaxBindSour.MoveLast();
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(ID_Txt.Text) && dialog == DialogResult.Yes)
            {
                try
                {
                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, DAmount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, DAmount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    Query("DELETE FROM T_AdvancedTax WHERE ID=@0;");
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");
                    T_AdvancedTaxTabAd.FillByDate(ChequerSet.T_AdvancedTax, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    T_AdvancedTaxBindSour.MoveLast();

                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            if (Subform != null)
            {
                Close();
                Subform.Details_Pan.SendToBack();
                Subform.panel1.Show();
                Subform.panel2.Show();
                Subform.AdvancedTax_Load(sender, e);
            }
            else
            {
                Close();
                Mainform.Menu_Pan.Show();
            }

        }

        private void Dealer_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                using (OleDbCommand Cmd = new OleDbCommand
                {

                    Connection = Con,

                    CommandText = "SELECT * FROM T_Dealer WHERE DealerName=@0"
                })
                {

                    Cmd.Parameters.AddWithValue("@0", Dealer_Txt.Text);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        string x = Reader["CIF"].ToString();
                        TaxID_Txt.Text = Reader["TaxID"].ToString();
                        Account_Txt.Text = "CIF : " + x;
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Function  */

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.Enabled = Value2;
            Dealer_Txt.Enabled = Value2;
            Type_Txt.Enabled = Value2;
            Deal_Txt.ReadOnly = Value;
            TaxID_Txt.ReadOnly = Value;
            Date_Txt.Enabled = Value2;
            DAmount_Txt.ReadOnly = Value;
            InvoiceAmt_Txt.ReadOnly = Value;
            Tax_Txt.Enabled = Value2;
            InvoiceNo_Txt.Enabled = Value2;
            Account_Txt.Enabled = Value2;
            PayDate_Txt.Enabled = Value2;

            Login.Instance.Check(Login.Instance.UserName, PayDate_Txt.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (PayDate_Txt.Name == obj.FunctionName)
                {
                    PayDate_Txt.Enabled = Value2;
                }
            }
        }

        public static InputLanguage GetInput(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                {
                    return lang;
                }
            }
            return null;
        }

        private void SwitchInput(InputLanguage layout) => InputLanguage.CurrentInputLanguage = layout;

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
            else if (Ctrl is MaskedTextBox)
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

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void English_Enter(object sender, EventArgs e)
        {
            SwitchInput(GetInput("english"));
        }

        private void Query(string Value)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Dispose();
                Cmd.Clone();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error AdvancedTax - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Type_Txt_Leave(object sender, EventArgs e)
        {
            if (Type_Txt.Text != "Durable Finance" && Type_Txt.Text != "Corporate Finance")
            {
                TaxID_Txt.Text = "N/A";
                InvoiceNo_Txt.Text = "N/A";
            }

            else
            {

            }
        }

        private void DAmount_Txt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DAmount_Txt.Text))
            {
                if (Type_Txt.SelectedItem.ToString() == "Durable Finance" && Type_Txt.SelectedItem.ToString() == "Corporate Finance")
                {
                    InvoiceAmt_Txt.Text = (Convert.ToDouble(DAmount_Txt.Text) - ((Convert.ToDouble(DAmount_Txt.Text) / 1.17) * 0.01)).ToString();
                    Tax_Txt.Text = ((Convert.ToDouble(DAmount_Txt.Text) / 1.17) * 0.01).ToString();
                }
                else
                {
                    InvoiceAmt_Txt.Text = DAmount_Txt.Text;
                    Tax_Txt.Text = ((Convert.ToDouble(DAmount_Txt.Text)) * 0.01).ToString();
                }
            }
        }

    }

}
