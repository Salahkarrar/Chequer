using Chequer.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Cheque : Form
    {
        public List<CurrencyInfo> Currencies = new List<CurrencyInfo>();

        public Cheque(SeCheque search, string ID, string Name, string Passport, IISMain Main)
        {
            Id = ID;
            Na = Name;
            Pass = Passport;
            Subform = search;
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - Cheque";
        }
        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public decimal Num { get; set; } = 1;
        public string BiNum { get; set; }
        public SeCheque Subform { get; set; } = null;
        public IISMain Mainform { get; set; } = null;
        public string Id { get; set; }
        public string Na { get; set; }
        public string Pass { get; set; }
        public int ID { get; set; }
        public Control Ctrl { get; set; }
        public int M { get; set; }


        public void Form1_Load(object sender, EventArgs e)
        {

            T_DealerTabAd.FillByType(ChequerSet.T_Dealer, "Durable");

            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Sudan));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Dollar));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));

            Currency_Txt.DataSource = Currencies;

            if (Subform == null)
            {
                Edit(true, false);
                T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                if (Cheque_Grid.RowCount == 0)
                {

                }
                else
                {
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.Rows[0].Cells[0].Value.ToString());
                }
            }
            else if (Subform != null)
            {
                Enabled = true;
                Edit(true, false);
                T_ChequeTabAd.FillByID(ChequerSet.T_Cheque, Id);
                if (Cheque_Grid.RowCount == 0)
                {

                }
                else
                {
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.Rows[0].Cells[0].Value.ToString());
                }
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
                ChequerSet.T_Cheque.AddT_ChequeRow(ChequerSet.T_Cheque.NewT_ChequeRow());
                T_ChequeBindSour.MoveLast();
                Name_Txt.Focus();
                Date_Txt.Text = DateTime.Now.ToString("d");
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Create New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            //ID = 10;
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text)
                && !string.IsNullOrEmpty(Tenor_Txt.Text) && !string.IsNullOrEmpty(Rate_Txt.Text) && !string.IsNullOrEmpty(FirstRate_Txt.Text)
                && !string.IsNullOrEmpty(FirstPay_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text) && !string.IsNullOrEmpty(Amount_Txt.Text)
                && !string.IsNullOrEmpty(Dealer_Txt.Text) && !string.IsNullOrEmpty(DealerCIF_Txt.Text) && !string.IsNullOrEmpty(TaxID_Txt.Text)
                && !string.IsNullOrEmpty(InvoiceNo_Txt.Text) && !string.IsNullOrEmpty(Currency_Txt.SelectedValue.ToString()))
            {
                Tak();
                Edit(true, false);
                try
                {
                    T_ChequeTabAd.Insert(Name_Txt.Text, Convert.ToInt32(CIF_Txt.Text), Convert.ToInt32(Deal_Txt.Text), Convert.ToInt32(Tenor_Txt.Text),
                                         Convert.ToDouble(Rate_Txt.Text), Convert.ToDouble(Amount_Txt.Text), Currency_Txt.SelectedValue.ToString(), txtArabicWord.Text,
                                         DateTime.Now, Date_Txt.Value.Date, Convert.ToInt32($"{Login.Instance.UserID}"), Convert.ToDouble(balanceTextBox.Text), Convert.ToDouble(FirstPay_Txt.Text),
                                         txtEnglishWord.Text, Convert.ToDouble(FirstRate_Txt.Text), Convert.ToDouble(salePriceTextBox.Text), Convert.ToDouble(DAmount_Txt.Text), Convert.ToDouble(takafulTextBox.Text), Dealer_Txt.Text, Convert.ToInt32(DealerCIF_Txt.Text), InvoiceNo_Txt.Text, TaxID_Txt.Text,Convert.ToDouble(Balloon_Txt.Text), Convert.ToDouble(BalloMon_Txt.Text));
                    T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    T_ChequeBindSour.MoveLast();
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    New_Btn.Enabled = true;

                    AdvancedTax();

                    Installment();

                    Print_Btn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cheque_Grid.CurrentRow.Cells[0].Value.ToString()) && Edit_Btn.Text == "Edit")
            {
                Edit(false, true);
                New_Btn.Enabled = false;
                Save_Btn.Enabled = false;

                Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
            }
            else if (Edit_Btn.Text == "Update")
            {
                Tak();
                Edit(true, false);
                New_Btn.Enabled = true;

                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                try
                {
                    Query("INSERT INTO T_ChequeRecycle (ID,CutName,CIF,Deal,DAmount,Tenor,Rate,FirstRate,FirstPay,FirstPayAr,Amount,Currancy,C_Date,AmountAr,TxDate,UserID,SalePrice,Balance,Takaful,Dealer,DealerCIF,TaxID,InvoiceNo,Balloon,BalloMon)" +
                          "SELECT ID,CutName,CIF,Deal,DAmount,Tenor,Rate,FirstRate,FirstPay,FirstPayAr,Amount,Currancy,C_Date,AmountAr,TxDate,UserID,SalePrice,Balance,Takaful,Dealer,DealerCIF,TaxID,InvoiceNo,Balloon,BalloMon FROM T_Cheque WHERE ID=@0;");
                    
                    if (Con.State == ConnectionState.Closed)
                        Con.Open();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "UPDATE T_Cheque SET CutName = @0, CIF = @1, Deal = @2, DAmount=@3,Tenor = @4, Rate = @5, " +
                                      "FirstRate=@6,FirstPay=@7,FirstPayAr=@8,Amount = @9,Currancy = @10, AmountAr='" + txtArabicWord.Text + "',C_Date = '" + Date_Txt.Text + "', UserID = '" + $"{Login.Instance.UserID}" + "'," +
                                      "SalePrice='" + salePriceTextBox.Text + "',Balance='" + balanceTextBox.Text + "',Takaful='" + takafulTextBox.Text + "',Dealer='" + Dealer_Txt.Text + "',DealerCIF='" + DealerCIF_Txt.Text + "',TaxID='" + TaxID_Txt.Text + "',InvoiceNo='" + InvoiceNo_Txt.Text + "',Balloon='"+Balloon_Txt.Text+"',BalloMon='"+BalloMon_Txt.Text+"' WHERE ID = @11";
                    Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                    Cmd.Parameters.AddWithValue("@1", CIF_Txt.Text);
                    Cmd.Parameters.AddWithValue("@2", Deal_Txt.Text);
                    Cmd.Parameters.AddWithValue("@3", DAmount_Txt.Text);
                    Cmd.Parameters.AddWithValue("@4", Tenor_Txt.Text);
                    Cmd.Parameters.AddWithValue("@5", Rate_Txt.Text);
                    Cmd.Parameters.AddWithValue("@6", FirstRate_Txt.Text);
                    Cmd.Parameters.AddWithValue("@7", FirstPay_Txt.Text);
                    Cmd.Parameters.AddWithValue("@8", txtEnglishWord.Text);
                    Cmd.Parameters.AddWithValue("@9", Amount_Txt.Text);
                    Cmd.Parameters.AddWithValue("@10", Currency_Txt.SelectedValue);
                    Cmd.Parameters.AddWithValue("@11", ID_Txt.Text);
                    
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    Query("UPDATE T_ChequeRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");

                    Query("INSERT INTO T_InstallmentRecycle (ID, Deal,Ins_Amount,Ins_AmountAr,Ins_Count,Ins_Date)" +
                          "SELECT ID, Deal,Ins_Amount,Ins_AmountAr,Count,Ins_Date FROM T_Installment WHERE ID=@0;");
                    Query("DELETE FROM T_Installment WHERE ID=@0;");
                    Query("UPDATE T_InstallmentRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");
                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    Query("DELETE FROM T_AdvancedTax WHERE ID=@0;");
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");
                    if (Cheque_Grid.RowCount == 0)
                    {

                    }
                    else
                    {
                        T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                    }
                    Installment();
                    AdvancedTax();
                    T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
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
                T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                T_ChequeBindSour.MoveLast();
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Retrive Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(ID_Txt.Text) && dialog == DialogResult.Yes)
            {
                try
                {
                    Query("INSERT INTO T_ChequeRecycle (ID,CutName,CIF,Deal,DAmount,Tenor,Rate,FirstRate,FirstPay,FirstPayAr,Amount,Currancy,C_Date,AmountAr,TxDate,UserID,SalePrice,Balance,Takaful,Dealer,DealerCIF,TaxID,InvoiceNo)" +
                          "SELECT ID,CutName,CIF,Deal,DAmount,Tenor,Rate,FirstRate,FirstPay,FirstPayAr,Amount,Currancy,C_Date,AmountAr,TxDate,UserID,SalePrice,Balance,Takaful,Dealer,DealerCIF,TaxID,InvoiceNo FROM T_Cheque WHERE ID=@0;");
                    Query("DELETE FROM T_Cheque WHERE ID=@0;");
                    Query("UPDATE T_ChequeRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");
                    T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    T_ChequeBindSour.MoveLast();

                    Query("INSERT INTO T_InstallmentRecycle (ID, Deal,Ins_Amount,Ins_AmountAr,Ins_Count,Ins_Date)" +
                          "SELECT ID, Deal,Ins_Amount,Ins_AmountAr,Count,Ins_Date FROM T_Installment WHERE ID=@0;");
                    Query("DELETE FROM T_Installment WHERE ID=@0;");
                    Query("UPDATE T_InstallmentRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");

                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    Query("DELETE FROM T_AdvancedTax WHERE ID=@0;");
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");
                    if (Cheque_Grid.RowCount == 0)
                    {

                    }
                    else
                    {
                        T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                    }

                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            Login.Instance.Check(Login.Instance.UserName, Print_Btn.Name);
                if (Login.Instance.List.Count == 1)
                    ID = 2;
                else 
                    ID = 1;

            Print myForm = new Print(this, null, ID_Txt.Text, ID, ChequerSet.T_Cheque, Convert.ToDateTime(Date_Txt.Text), Convert.ToInt32(Tenor_Txt.Text), null, null, null, null, null)
            {
                TopLevel = false,
            };
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    panel1.Hide();
                    panel3.Hide();
                    Details_Pan.Dock = DockStyle.Fill;
                    Details_Pan.BringToFront();
                    Details_Pan.Controls.Clear();
                    Details_Pan.Controls.Add(myForm);
                    myForm.Show();
                    break;
                }
            }
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
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
                Subform.Search_Load(sender, e);
            }
            else
            {
                Close();
                Mainform.Menu_Pan.Show();
            }

        }

        private void Date_Txt_Enter(object sender, EventArgs e)
        {
            if (DateTime.Now.Date.Day <= 15)
            {
                Date_Txt.Value = DateTime.Now.AddDays(25 - DateTime.Now.Day);
            }
            else
            {
                Date_Txt.Value = DateTime.Now.AddDays(25 - DateTime.Now.Day).AddMonths(1);
            }
        }

        private void FirstPay_Txt_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DAmount_Txt.Text))
            {
                FirstPay_Txt.Text = ((Math.Round(Convert.ToDouble(DAmount_Txt.Text), 2) * (Convert.ToDouble(FirstRate_Txt.Text)) / 100)).ToString();
            }
            else
            {

            }
        }

        private void Amount_Txt_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DAmount_Txt.Text))
            {
                //salePriceTextBox.Text = (Math.Round(Convert.ToDouble(DAmount_Txt.Text), 2) + (Math.Round(Convert.ToDouble(DAmount_Txt.Text), 2) * (Math.Round(Convert.ToDouble(Rate_Txt.Text), 2) / 100) * (Math.Round(Convert.ToDouble(Tenor_Txt.Text), 2) / 12))).ToString();
                salePriceTextBox.Text = Math.Round(Convert.ToDouble(DAmount_Txt.Text) + (Convert.ToDouble(DAmount_Txt.Text) * (Convert.ToDouble(Rate_Txt.Text) / 100) * ((Convert.ToDouble(Tenor_Txt.Text) / 12))),2).ToString();
                //balanceTextBox.Text = (Math.Round(Convert.ToDouble(salePriceTextBox.Text), 2) - Convert.ToDouble(FirstPay_Txt.Text)).ToString(); ;
                balanceTextBox.Text = Math.Round(Convert.ToDouble(salePriceTextBox.Text) - Convert.ToDouble(FirstPay_Txt.Text),2).ToString();
                Amount_Txt.Text = Math.Round((Convert.ToDouble(balanceTextBox.Text) / Convert.ToDouble(Tenor_Txt.Text)), 2).ToString();
            }
            else
            {

            }
        }

        private void Cheque_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cheque_Grid.RowCount == 0)
            {

            }
            else
            {
                T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void Rate_Txt_Enter(object sender, EventArgs e)
        {
            Rate_Txt.Text = "13.3";
        }

        private void FirstRate_Txt_Enter(object sender, EventArgs e)
        {
            FirstRate_Txt.Text = "30";
        }

        private void FirstPay_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(FirstPay_Txt.Text), Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)]);
                txtEnglishWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                txtEnglishWord.Text = String.Empty;
            }

        }

        private void Amount_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(Amount_Txt.Text), Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)]);
                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                txtArabicWord.Text = String.Empty;
            }

        }

        private void LastPay_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(LastPay_Txt.Text), Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)]);
                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                txtArabicWord.Text = String.Empty;
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
                        DealerCIF_Txt.Text = Reader["CIF"].ToString();
                        TaxID_Txt.Text = Reader["TaxID"].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tenor_Txt_Enter(object sender, EventArgs e)
        {
            Tenor_Txt.Text = "36";
        }


        /* Function  */

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.Enabled = Value2;
            Dealer_Txt.Enabled = Value2;
            CIF_Txt.ReadOnly = Value;
            DealerCIF_Txt.ReadOnly = Value;
            Deal_Txt.ReadOnly = Value;
            Tenor_Txt.ReadOnly = Value;
            FirstPay_Txt.ReadOnly = Value;
            Rate_Txt.ReadOnly = Value;
            Currency_Txt.Enabled = Value2;
            Date_Txt.Enabled = Value2;
            DAmount_Txt.ReadOnly = Value;
            FirstRate_Txt.ReadOnly = Value;
            InvoiceNo_Txt.ReadOnly = Value;
            TaxID_Txt.ReadOnly = Value;
            Amount_Txt.ReadOnly = Value;
            Balloon_Txt.ReadOnly = Value;
            BalloMon_Txt.ReadOnly = Value;

            Login.Instance.Check(Login.Instance.UserName, Date_Txt.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (Date_Txt.Name == obj.FunctionName)
                {
                    Date_Txt.Enabled = Value2;
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
                //Cmd.Parameters.AddWithValue("@1", Deal_Txt.Text);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tak()
        {
            if (Tenor_Txt.Text == "36")
            {
                double St = (Convert.ToDouble(balanceTextBox.Text) * 0.01) * (1 + .005 + .005);
                double Sd = ((Convert.ToDouble(Tenor_Txt.Text) - 12) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);
                double Th = ((Convert.ToDouble(Tenor_Txt.Text) - 24) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);

                takafulTextBox.Text = Math.Round((St + Sd + Th + 125), 2).ToString();
            }
            else if(Tenor_Txt.Text=="24")
            {
                double St = (Convert.ToDouble(balanceTextBox.Text) * 0.01) * (1 + .005 + .005);
                double Sd = ((Convert.ToDouble(Tenor_Txt.Text) - 12) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);
                takafulTextBox.Text = Math.Round((St + Sd + 125), 2).ToString();
            }
            else if (Tenor_Txt.Text == "12")
            {
                double St = (Convert.ToDouble(balanceTextBox.Text) * 0.01) * (1 + .005 + .005);
                takafulTextBox.Text = Math.Round((St + 125), 2).ToString();
            }
            else if (Convert.ToInt32(Tenor_Txt.Text) > 24 && Convert.ToInt32(Tenor_Txt.Text) < 36)
            {
                double St = (Convert.ToDouble(balanceTextBox.Text) * 0.01) * (1 + .005 + .005);
                double Sd = ((Convert.ToDouble(Tenor_Txt.Text) - 12) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);
                double Th = ((Convert.ToDouble(Tenor_Txt.Text) - 24) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);
                takafulTextBox.Text = Math.Round((St + Sd + Th + 125), 2).ToString();
            }
            else if (Convert.ToInt32(Tenor_Txt.Text) > 12 && Convert.ToInt32(Tenor_Txt.Text) < 24)
            {
                double St = (Convert.ToDouble(balanceTextBox.Text) * 0.01) * (1 + .005 + .005);
                double Sd = ((Convert.ToDouble(Tenor_Txt.Text) - 12) * Convert.ToDouble(Amount_Txt.Text)) * 0.01 * (1 + .005 + .005);
                takafulTextBox.Text = Math.Round((St + Sd + 125), 2).ToString();
            }
        }

        private void Installment()
        {
            DateTime D = Date_Txt.Value.Date;
            for (int i = 0; i <= Convert.ToInt32(Tenor_Txt.Text); i++)
            {
                double Amt;
                if (i == 0)
                {
                    //Login.Instance.Check(Login.Instance.UserName, FirstPay_Txt.Name);
                    //foreach (var obj in Login.Instance.List)
                    //{
                    //    if (FirstPay_Txt.Name == obj.FunctionName)
                    //    {
                    //        T_InstTabAd.Insert(Convert.ToInt32(ID_Txt.Text), Convert.ToInt32(Deal_Txt.Text), i + 1, Convert.ToDateTime(Cheque_Grid.CurrentRow.Cells[11].Value), Convert.ToDouble(FirstPay_Txt.Text), txtEnglishWord.Text);
                    //        T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                    //    }
                    //}


                    T_InstTabAd.Insert(Convert.ToInt32(ID_Txt.Text), Convert.ToInt32(Deal_Txt.Text), i + 1, Convert.ToDateTime(Cheque_Grid.CurrentRow.Cells[11].Value), Convert.ToDouble(FirstPay_Txt.Text), txtEnglishWord.Text);
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());

                }
                else if (i == 1)
                {
                    if (D.Month == 12 && Balloon_Txt.Text != "0")
                    {
                        Amt = Convert.ToDouble(BalloMon_Txt.Text);
                    }
                    else
                    {
                        Amt = Convert.ToDouble(Amount_Txt.Text);
                    }
                    T_InstTabAd.Insert(Convert.ToInt32(ID_Txt.Text), Convert.ToInt32(Deal_Txt.Text), i + 1, D.Date, Amt, txtArabicWord.Text);
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                }
                else if (i == Convert.ToInt32(Tenor_Txt.Text))
                {
                    double t = Math.Round(Convert.ToDouble(Tenor_Txt.Text), 2) - 1;
                    double s = Math.Round(Convert.ToDouble(Amount_Txt.Text), 2) * t;
                    double Y = Convert.ToDouble(balanceTextBox.Text);
                    double X = Y - s;
                    LastPay_Txt.Text = Convert.ToString(X);
                    //string D2 = DateTime.Now.Date.Day.ToString("dd");
                    //D = Convert.ToDateTime(DateTime.Now.Date.Day.ToString("dd"));
                    //D = D.AddMonths(1);
                    D = DateTime.Now.AddDays(0).AddMonths(0).AddYears(Convert.ToInt32(Tenor_Txt.Text) / 12);
                    T_InstTabAd.Insert(Convert.ToInt32(ID_Txt.Text), Convert.ToInt32(Deal_Txt.Text), i + 1, D.Date, Math.Round(Convert.ToDouble(LastPay_Txt.Text), 2), txtArabicWord.Text);
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                }
                else
                {
                    D = D.AddMonths(1);
                    if (D.Month == 12 && Balloon_Txt.Text!= "0")
                    {
                        Amt = Convert.ToDouble(BalloMon_Txt.Text);
                    }
                    else
                    {
                        Amt = Convert.ToDouble(Amount_Txt.Text);
                    }
                    T_InstTabAd.Insert(Convert.ToInt32(ID_Txt.Text), Convert.ToInt32(Deal_Txt.Text), i + 1, D.Date, Amt, txtArabicWord.Text);
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
                }
            }
        }

        private void AdvancedTax()
        {
            try
            {
                string x = DealerCIF_Txt.Text;
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "INSERT INTO T_AdvancedTax (CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate,ID) VALUES " +
                                  "(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,'" + DateTime.Today.Date.ToString("d") + "','" + $"{Login.Instance.UserID}" + "','" + DateTime.Now + "','"+ID_Txt.Text+"')";
                Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                Cmd.Parameters.AddWithValue("@1", Dealer_Txt.Text);
                Cmd.Parameters.AddWithValue("@2", "Durable Finance");
                Cmd.Parameters.AddWithValue("@3", Deal_Txt.Text);
                Cmd.Parameters.AddWithValue("@4", DateTime.Today.Date);
                Cmd.Parameters.AddWithValue("@5", TaxID_Txt.Text);
                Cmd.Parameters.AddWithValue("@6", DAmount_Txt.Text);
                Cmd.Parameters.AddWithValue("@7", (Convert.ToDouble(DAmount_Txt.Text) - ((Convert.ToDouble(DAmount_Txt.Text) / 1.17) * 0.01)));
                Cmd.Parameters.AddWithValue("@8", ((Convert.ToDouble(DAmount_Txt.Text) / 1.17) * 0.01));
                Cmd.Parameters.AddWithValue("@9", InvoiceNo_Txt.Text);
                Cmd.Parameters.AddWithValue("@10", "CIF : " + x);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Insert Data in Tax Table, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BalloMon_Txt_Enter(object sender, EventArgs e)
        {
            BalloMon_Txt.Text = (Convert.ToDouble(Balloon_Txt.Text) + Convert.ToDouble(Amount_Txt.Text)).ToString();
        }

        private void Balloon_Txt_Enter(object sender, EventArgs e)
        {
            Balloon_Txt.Text = "0";
        }
    }

}
