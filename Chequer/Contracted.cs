using Chequer.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Chequer
{
    public partial class Contracted : Form
    {
        public List<CurrencyInfo> Currencies = new List<CurrencyInfo>();
        public Contracted(IISMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - Contracted";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public IISMain Mainform { get; set; } = null;
        public Control Ctrl;
        public object ID { get; set; }

        protected internal void Contracted_Load(object sender, EventArgs e)
        {
            T_ClientTabAd.Fill(ChequerSet.T_Client);
            T_DealerTabAd.FillByType(ChequerSet.T_Dealer, "Corporate");
            T_ContractedTabAd.Fill(ChequerSet.T_Contracted);
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Sudan));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Dollar));
            Currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));

            Currency_Txt.DataSource = Currencies;

            Currency_Txt_DropDownClosed(null, null);
            try
            {
                Enabled = true;
                Edit(true, false);
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
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                ChequerSet.T_Contracted.AddT_ContractedRow(ChequerSet.T_Contracted.NewT_ContractedRow());
                T_ContractedBindSour.MoveLast();
                Trade_Txt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Trade_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text) && !string.IsNullOrEmpty(Day_Txt.Text) &&
                    !string.IsNullOrEmpty(Month_Txt.Text) && !string.IsNullOrEmpty(Year_Txt.Text) && !string.IsNullOrEmpty(Nick_Txt.Text) &&
                    !string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Goods_Txt.Text) && !string.IsNullOrEmpty(Qnt_Txt.Text) &&
                    !string.IsNullOrEmpty(Amount_Txt.Text) && !string.IsNullOrEmpty(Sale_Txt.Text) && !string.IsNullOrEmpty(Payment_Txt.Text) &&
                    !string.IsNullOrEmpty(Profit_Txt.Text) && !string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(TaxID_Txt.Text) &&
                    !string.IsNullOrEmpty(InvoiceNo_Txt.Text) && !string.IsNullOrEmpty(From_Txt.Text))
                {
                    if (CIF_Txt.TextLength == 0)
                        CIF_Txt.Text = "0";
                    else if (TaxID_Txt.TextLength == 0)
                        TaxID_Txt.Text = "0";
                    else if (InvoiceNo_Txt.TextLength == 0)
                        InvoiceNo_Txt.Text = "N/A";
                    Edit(true, false);
                    T_ContractedTabAd.Insert(Convert.ToInt32(Trade_Txt.Text), Convert.ToInt32(Deal_Txt.Text), Day_Txt.Text, Month_Txt.Text, Year_Txt.SelectedItem.ToString(), Nick_Txt.SelectedItem.ToString(), Name_Txt.Text, Goods_Txt.Text, Qnt_Txt.Text, Convert.ToDouble(Amount_Txt.Text), Word_Txt.Text, Payment_Txt.Text, Convert.ToInt32(CIF_Txt.Text), From_Txt.Text, Convert.ToDouble(Profit_Txt.Text), Word1_Txt.Text, DateTime.Now, Convert.ToInt32(Login.Instance.UserID), Sale_Txt.Text, Convert.ToInt32(TaxID_Txt.Text), InvoiceNo_Txt.Text);
                    MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    T_ContractedTabAd.Fill(ChequerSet.T_Contracted);
                    T_ContractedBindSour.MoveLast();
                    AdvancedTax();
                    SaveData2();
                    string FilePath = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Contract.docx";
                    string FilePath2 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Goods.docx";
                    string FilePath3 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Cheque.docx";
                    string FilePath4 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Request Cheque.docx";
                    Report1(FilePath, FilePath2, FilePath3, FilePath4);
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again" + "\r\n" + "You Can't Let Any Text Empty.", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Save Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit_Btn.Text == "Edit")
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
                    Query("INSERT INTO T_ContractedRecycle (ID, Trade, Deal, CDay, CMonth, CYear, Nick, CustName, Goods, Qnt, Amount, AmountAr, Payment, SalesName, CIF, BokName, Profit, ProfitAr, TxDate, UserID,TaxID,InvoiceNo)" +
                          "SELECT ID, Trade, Deal, CDay, CMonth, CYear, Nick, CustName, Goods, Qnt, Amount, AmountAr, Payment, SalesName, CIF, BokName, Profit, ProfitAr, TxDate, UserID,TaxID,InvoiceNo FROM T_Contracted WHERE Deal=@0;");
                    T_ContractedTabAd.Update(ChequerSet.T_Contracted);
                    Query("UPDATE T_ContractedRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE Deal=@0;");
                    T_ContractedTabAd.Fill(ChequerSet.T_Contracted);
                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    Query("DELETE FROM T_AdvancedTax WHERE ID=@0;");
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");
                    AdvancedTax();
                    MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_ContractedBindSour.CancelEdit();
                T_ContractedTabAd.Fill(ChequerSet.T_Contracted);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Cancel Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Query("INSERT INTO T_ContractedRecycle (ID, Trade, Deal, CDay, CMonth, CYear, Nick, CustName, Goods, Qnt, Amount, AmountAr, Payment, SalesName, CIF, BokName, Profit, ProfitAr, TxDate, UserID,TaxID,InvoiceNo)" +
                          "SELECT ID, Trade, Deal, CDay, CMonth, CYear, Nick, CustName, Goods, Qnt, Amount, AmountAr, Payment, SalesName, CIF, BokName, Profit, ProfitAr, TxDate, UserID,TaxID,InvoiceNo FROM T_Contracted WHERE Deal=@0;");
                    Query("DELETE FROM T_Contracted WHERE Deal=@0");
                    Query("UPDATE T_ContractedRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE Deal=@0;");
                    T_ContractedTabAd.Fill(ChequerSet.T_Contracted);
                    T_ContractedBindSour.MoveFirst();
                    Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate)" +
                          "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;");
                    Query("DELETE FROM T_AdvancedTax WHERE ID=@0;");
                    Query("UPDATE T_AdvancedTaxRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Contracted - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        // Contracted Function //

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Day_Txt.Enabled = Value2;
            Month_Txt.Enabled = Value2;
            Year_Txt.Enabled = Value2;
            Nick_Txt.Enabled = Value2;
            Payment_Txt.Enabled = Value2;
            From_Txt.Enabled = Value2;
            Trade_Txt.ReadOnly = Value;
            Deal_Txt.ReadOnly = Value;
            Name_Txt.Enabled = Value2;
            Goods_Txt.ReadOnly = Value;
            Qnt_Txt.ReadOnly = Value;
            Amount_Txt.ReadOnly = Value;
            CIF_Txt.ReadOnly = Value;
            Profit_Txt.ReadOnly = Value;
            TaxID_Txt.ReadOnly = Value;
            InvoiceNo_Txt.ReadOnly = Value;
            Sale_Txt.Enabled = Value2;
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

        public void SaveData2()
        {
            try
            {
                if (!string.IsNullOrEmpty(Deal_Txt.Text))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Deals\\" + Deal_Txt.Text);
                    string sourceFileNameCon = Application.StartupPath + "\\Templete\\Contract.docx";
                    string sourceFileNameGoods = Application.StartupPath + "\\Templete\\Recieving Goods.docx";
                    string sourceFileNameCheque = Application.StartupPath + "\\Templete\\Recieving Cheque.docx";
                    string sourceFileNameRequest = Application.StartupPath + "\\Templete\\Request Cheque.docx";
                    string destFileName1 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Contract.docx";
                    string destFileName2 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Goods.docx";
                    string destFileName3 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Cheque.docx";
                    string destFileName4 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Request Cheque.Docx";

                    if (File.Exists(sourceFileNameCon) && File.Exists(sourceFileNameGoods)
                        && File.Exists(sourceFileNameCheque) && File.Exists(sourceFileNameRequest))
                    {
                        if (File.Exists(destFileName1) && File.Exists(destFileName2)
                            && File.Exists(destFileName3) && File.Exists(destFileName4))
                        {
                            MessageBoxEx.Show(Resources.FileExist, Resources.E1, 700);
                        }
                        else
                        {
                            File.Copy(sourceFileNameCon, destFileName1);
                            File.Copy(sourceFileNameGoods, destFileName2);
                            if (Payment_Txt.Text == "بإصدار شيك مصرفي")
                            {
                                File.Copy(sourceFileNameCheque, destFileName3);
                                File.Copy(sourceFileNameRequest, destFileName4);
                            }
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("No Templete", Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information, 500);
                        //File.Copy(Path + "Templete\\Templete.docx", destFileName1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.E11 + "\r\n" + ex.Message, Resources.E1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string[] ReadData()
        {
            string[] data = new string[16];
            data[0] = Day_Txt.Text;
            data[1] = Month_Txt.Text;
            data[2] = Year_Txt.Text;
            data[3] = Nick_Txt.Text;
            data[4] = Name_Txt.Text;
            data[5] = Goods_Txt.Text;
            data[6] = Qnt_Txt.Text;
            data[7] = Amount_Txt.Text;
            data[8] = Word_Txt.Text;
            data[9] = Payment_Txt.Text;
            data[10] = CIF_Txt.Text;
            data[11] = From_Txt.Text;
            data[12] = Sale_Txt.Text;
            data[13] = Profit_Txt.Text;
            data[14] = Word1_Txt.Text;
            data[15] = Trade_Txt.Text;
            return data;
        }
        public void Report1(string Value, string Value2, string Value3, string Value4)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document Doc = null;
            object missing = Type.Missing;

            for (int i = 0; i <= 1; i++)
            {
                if (File.Exists(Value))
                {
                    Doc = app.Documents.Open(Value);
                    //app.Selection.Find.ClearFormatting();
                    //app.Selection.Find.Replacement.ClearFormatting();
                    app.Visible = true;
                }
                else
                {
                    MessageBoxEx.Show("Not Exist", 1000);
                    break;
                }

                _ = new string[16];
                string[] tmp = ReadData();

                app.Selection.Find.Execute("<Day>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[0], 2);
                app.Selection.Find.Execute("<Month>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[1], 2);
                app.Selection.Find.Execute("<Year>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[2], 2);
                app.Selection.Find.Execute("<Nick>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[3], 2);
                app.Selection.Find.Execute("<Name>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[4], 2);
                app.Selection.Find.Execute("<Goods>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[5], 2);
                app.Selection.Find.Execute("<Qnt>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[6], 2);
                app.Selection.Find.Execute("<Amount>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[7], 2);
                app.Selection.Find.Execute("<AmountAr>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[8], 2);
                app.Selection.Find.Execute("<Payment>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[9], 2);
                app.Selection.Find.Execute("<CIF>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[10], 2);
            }
            for (int i = 0; i <= 1; i++)
            {
                if (File.Exists(Value2))
                {
                    Doc = app.Documents.Open(Value2);
                    //app.Selection.Find.ClearFormatting();
                    //app.Selection.Find.Replacement.ClearFormatting();
                    app.Visible = true;
                }
                else
                {
                    MessageBoxEx.Show("Not Exist", 1000);
                    break;
                }
                _ = new string[16];
                string[] tmp = ReadData();

                app.Selection.Find.Execute("<Nick>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[3], 2);
                app.Selection.Find.Execute("<Goods>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[5], 2);
                app.Selection.Find.Execute("<Qnt>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[6], 2);
                app.Selection.Find.Execute("<From>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[11], 2);
                app.Selection.Find.Execute("<Sale>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[12], 2);
                app.Selection.Find.Execute("<Profit>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[13], 2);
                app.Selection.Find.Execute("<ProfitAr>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[14], 2);
            }
            if (Payment_Txt.Text == "بإصدار شيك مصرفي")
            {
                for (int i = 0; i <= 1; i++)
                {
                    if (File.Exists(Value3))
                    {
                        Doc = app.Documents.Open(Value3);
                        //app.Selection.Find.ClearFormatting();
                        //app.Selection.Find.Replacement.ClearFormatting();
                        app.Visible = true;
                    }
                    else
                    {
                        MessageBoxEx.Show("Not Exist", 1000);
                        break;
                    }
                    _ = new string[16];
                    string[] tmp = ReadData();

                    app.Selection.Find.Execute("<Nick>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[3], 2);
                    app.Selection.Find.Execute("<Goods>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[5], 2);
                    app.Selection.Find.Execute("<Qnt>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[6], 2);
                    app.Selection.Find.Execute("<From>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[11], 2);
                    app.Selection.Find.Execute("<Name>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[4], 2);
                    app.Selection.Find.Execute("<Amount>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[7], 2);
                    app.Selection.Find.Execute("<AmountAr>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[8], 2);
                }
                for (int i = 0; i <= 1; i++)
                {
                    if (File.Exists(Value4))
                    {
                        Doc = app.Documents.Open(Value4);
                        //app.Selection.Find.ClearFormatting();
                        //app.Selection.Find.Replacement.ClearFormatting();
                        app.Visible = true;
                    }
                    else
                    {
                        MessageBoxEx.Show("Not Exist", 1000);
                        break;
                    }
                    _ = new string[16];
                    string[] tmp = ReadData();
                    app.Selection.Find.Execute("<Trade>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[15], 2);
                    app.Selection.Find.Execute("<Sale>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[12], 2);
                    app.Selection.Find.Execute("<Name>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[4], 2);
                    app.Selection.Find.Execute("<Amount>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[7], 2);
                    app.Selection.Find.Execute("<AmountAr>", missing, missing, missing, missing, missing, missing, missing, missing, tmp[8], 2);
                    app.Selection.Find.Execute("<Date>", missing, missing, missing, missing, missing, missing, missing, missing, DateTime.Now.ToString("d"), 2);
                }
            }
        }

        private void Amount_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToWord toWord = new ToWord(Convert.ToDecimal(Amount_Txt.Text), Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)]);
                Word_Txt.Text = toWord.ConvertToArabic();
                ToWord toProfit = new ToWord(Convert.ToDecimal(Profit_Txt.Text), Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)]);
                Word1_Txt.Text = toProfit.ConvertToArabic();
            }
            catch (Exception)
            {
                Word_Txt.Text = String.Empty;
                Word1_Txt.Text = String.Empty;
            }
        }

        private void Currency_Txt_DropDownClosed(object sender, EventArgs e)
        {
            Amount_Txt_TextChanged(null, null);
        }

        private void Contracted_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string FilePath = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Contract.docx";
            string FilePath2 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Goods.docx";
            string FilePath3 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Recieving Cheque.docx";
            string FilePath4 = Application.StartupPath + "\\Deals\\" + Deal_Txt.Text + "\\Request Cheque.docx";
            Report1(FilePath, FilePath2, FilePath3, FilePath4);
        }

        private void Query(string Value)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            Cmd.Dispose();
            Cmd.Clone();
            Cmd.Connection = Con;
            Cmd.CommandText = Value;
            Cmd.Parameters.AddWithValue("@0", Deal_Txt.Text);
            Cmd.ExecuteNonQuery();
            Cmd.Parameters.Clear();
            Con.Close();
        }

        private void Sale_Txt_Leave(object sender, EventArgs e)
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

                    Cmd.Parameters.AddWithValue("@0", Sale_Txt.Text);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        CIF_Txt.Text = Reader["CIF"].ToString();
                        TaxID_Txt.Text = Reader["TaxID"].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                }
                if (CIF_Txt.Text != null)
                    Payment_Txt.SelectedItem = "بإضافته في الحساب";
                else
                    Payment_Txt.SelectedItem = "بإصدار شيك مصرفي";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdvancedTax()
        {
            try
            {
                string x = CIF_Txt.Text;
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "INSERT INTO T_AdvancedTax (CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate,ID) VALUES " +
                                  "(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,'" + DateTime.Today.Date.ToString("d") + "','" + $"{Login.Instance.UserID}" + "','" + DateTime.Now + "','"+Contracted_Grid.CurrentRow.Cells[0].Value+"')";
                Cmd.Parameters.AddWithValue("@0", Name_Txt.Text);
                Cmd.Parameters.AddWithValue("@1", Sale_Txt.Text);
                Cmd.Parameters.AddWithValue("@2", "Corporate Finance");
                Cmd.Parameters.AddWithValue("@3", Deal_Txt.Text);
                Cmd.Parameters.AddWithValue("@4", DateTime.Today.Date);
                Cmd.Parameters.AddWithValue("@5", TaxID_Txt.Text);
                Cmd.Parameters.AddWithValue("@6", Amount_Txt.Text);
                Cmd.Parameters.AddWithValue("@7", (Convert.ToDouble(Amount_Txt.Text) - ((Convert.ToDouble(Amount_Txt.Text) / 1.17) * 0.01)));
                Cmd.Parameters.AddWithValue("@8", ((Convert.ToDouble(Amount_Txt.Text) / 1.17) * 0.01));
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

        private void TaxID_Txt_Leave(object sender, EventArgs e)
        {
            if (TaxID_Txt.TextLength == 0)
                TaxID_Txt.Text = "0";
        }

        private void InvoiceNo_Txt_Leave(object sender, EventArgs e)
        {
            if (InvoiceNo_Txt.TextLength == 0)
                InvoiceNo_Txt.Text = "N/A";
        }
    }
}
