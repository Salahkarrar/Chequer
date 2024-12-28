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
        string startDate = DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM";
        string endDate = DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM";


        public void Form1_Load(object sender, EventArgs e)
        {
            // Fill the dealer table adapter with data of type "Durable"
            T_DealerTabAd.FillByType(ChequerSet.T_Dealer, "Durable");

            // Initialize the list of currencies
            if (Currencies == null)
            {
                Currencies = new List<CurrencyInfo>();
            }
            else
            {
                Currencies.Clear();
            }

            Currencies.AddRange(new[]
            {
        new CurrencyInfo(CurrencyInfo.Currencies.Sudan),
        new CurrencyInfo(CurrencyInfo.Currencies.UAE),
        new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia),
        new CurrencyInfo(CurrencyInfo.Currencies.Dollar),
        new CurrencyInfo(CurrencyInfo.Currencies.Gold)
    });

            // Set the data source for the currency text box
            Currency_Txt.DataSource = Currencies;

            // Check if Subform is null
            if (Subform == null)
            {
                Edit(true, false);
                // Fill the cheque table adapter with data for the current date
                string startDate = DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM";
                string endDate = DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM";
                T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, startDate, endDate);

                // Check if there are any rows in the cheque grid
                if (Cheque_Grid.RowCount > 0)
                {
                    // Fill the installment table adapter with data based on the first row's ID
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.Rows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                Enabled = true;
                Edit(true, false);
                // Fill the cheque table adapter with data based on the ID
                T_ChequeTabAd.FillByID(ChequerSet.T_Cheque, Id);

                // Check if there are any rows in the cheque grid
                if (Cheque_Grid.RowCount > 0)
                {
                    // Fill the installment table adapter with data based on the first row's ID
                    T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.Rows[0].Cells[0].Value.ToString());
                }
            }

            // Check user permissions for the delete button
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
                // Set the form to edit mode and disable certain controls
                Edit(false, true);

                // Add a new row to the T_Cheque table
                ChequerSet.T_Cheque.AddT_ChequeRow(ChequerSet.T_Cheque.NewT_ChequeRow());

                // Move the binding source to the last item
                T_ChequeBindSour.MoveLast();

                // Set focus to the Name text box
                Name_Txt.Focus();

                // Set the Date text box to the current date
                Date_Txt.Text = DateTime.Now.ToString("d");

                // Disable the New button
                New_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Problem in Database, Can't Create New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Save_Btn_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(CIF_Txt.Text) && !string.IsNullOrEmpty(Deal_Txt.Text)
                && !string.IsNullOrEmpty(Tenor_Txt.Text) && !string.IsNullOrEmpty(Rate_Txt.Text) && !string.IsNullOrEmpty(FirstRate_Txt.Text)
                && !string.IsNullOrEmpty(FirstPay_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text) && !string.IsNullOrEmpty(Amount_Txt.Text)
                && !string.IsNullOrEmpty(Dealer_Txt.Text) && !string.IsNullOrEmpty(DealerCIF_Txt.Text) && !string.IsNullOrEmpty(TaxID_Txt.Text)
                && !string.IsNullOrEmpty(InvoiceNo_Txt.Text) && Currency_Txt.SelectedValue != null)
            {
                Takaful();
                Edit(true, false);
                try
                {
                    // Insert new cheque record
                    T_ChequeTabAd.Insert(Name_Txt.Text, Convert.ToInt32(CIF_Txt.Text), Convert.ToInt32(Deal_Txt.Text), Convert.ToInt32(Tenor_Txt.Text),
                                         Convert.ToDouble(Rate_Txt.Text), Convert.ToDouble(Amount_Txt.Text), Currency_Txt.SelectedValue.ToString(), 
                                         txtArabicWord.Text, DateTime.Now, Date_Txt.Value.Date, Convert.ToInt32(Login.Instance.UserID), 
                                         Convert.ToDouble(balanceTextBox.Text), Convert.ToDouble(FirstPay_Txt.Text),                                         txtEnglishWord.Text, Convert.ToDouble(FirstRate_Txt.Text), Convert.ToDouble(salePriceTextBox.Text), Convert.ToDouble(DAmount_Txt.Text), Convert.ToDouble(takafulTextBox.Text), Dealer_Txt.Text, Convert.ToInt32(DealerCIF_Txt.Text), InvoiceNo_Txt.Text, TaxID_Txt.Text, Convert.ToDouble(Balloon_Txt.Text), Convert.ToDouble(BalloMon_Txt.Text));

                    // Refresh the cheque data grid
                    T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, DateTime.Today.ToString("dd/MM/yyyy") + " 12:00:00AM", DateTime.Today.ToString("dd/MM/yyyy") + " 11:59:59 PM");
                    T_ChequeBindSour.MoveLast();

                    // Show success message
                    MessageBoxEx.Show("Data Saved", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                    New_Btn.Enabled = true;

                    // Perform additional operations
                    AdvancedTax();
                    Installment();
                    Print_Btn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show("Problem in Database, Can't Store Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show error message if required fields are missing
                MessageBoxEx.Show("Please Check Your Data and Try Again", Resources.M00, MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            // Check if the selected row in the grid is valid
            if (string.IsNullOrEmpty(Cheque_Grid.CurrentRow?.Cells[0].Value?.ToString()))
                return;

            // Toggle between Edit and Update modes
            if (Edit_Btn.Text == "Edit")
            {
                // Enter edit mode
                ToggleEditMode(false, true);
                SetButtonStates(false, false);
                Login.Instance.Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
            }
            else if (Edit_Btn.Text == "Update")
            {
                // Perform update operation
                UpdateCheque();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the Edit button icon and text
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);

                // Enable edit mode and disable new mode
                Edit(true, false);

                // Enable the New button
                New_Btn.Enabled = true;

                // Fill the T_Cheque table adapter with today's data
                T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, startDate, endDate);

                // Move to the last record in the binding source
                T_ChequeBindSour.MoveLast();

                // Ensure the New button is enabled
                New_Btn.Enabled = true;
            }
            catch (Exception ex)
            {
                // Display an error message if there is a problem with the database
                MessageBox.Show("Problem in Database, Can't Retrieve Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check if the ID text is not empty and the user confirmed the deletion
            if (!string.IsNullOrEmpty(ID_Txt.Text) && dialog == DialogResult.Yes)
            {
                try
                {
                    // Move the cheque data to the recycle table and delete it from the original table
                    BackupChequeData();
                    Query("DELETE FROM T_Cheque WHERE ID=@0;", ID_Txt.Text);
                    Query("UPDATE T_ChequeRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='Delete' WHERE ID=@0;", ID_Txt.Text);

                    // Move the installment data to the recycle table and delete it from the original table
                    BackupInstallmentData();

                    // Move the advanced tax data to the recycle table and delete it from the original table
                    BackupAdvancedTaxData();

                    // Refresh the cheque data grid
                    RefreshDataGrids();

                    // Show success message
                    MessageBoxEx.Show("Data Deleted", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 700);
                }
                catch (Exception ex)
                {
                    // Show error message if there is a problem with the database
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Print_Btn_Click(object sender, EventArgs e)
        {
            // Check user permissions for the Print button
            Login.Instance.Check(Login.Instance.UserName, Print_Btn.Name);

            // Determine the ID based on the user's permission list count
            ID = (Login.Instance.List.Count == 1) ? 2 : 1;

            // Create a new Print form instance
            Print myForm = new Print(this, null, ID_Txt.Text, ID, ChequerSet.T_Cheque, Convert.ToDateTime(Date_Txt.Text), Convert.ToInt32(Tenor_Txt.Text), null, null, null, null, null)
            {
                TopLevel = false,
            };

            // Check user permissions for the Print form
            Login.Instance.Check(Login.Instance.UserName, myForm.Name);

            // Iterate through the permission list to find a match
            foreach (var obj in Login.Instance.List)
            {
                if (myForm.Name == obj.FunctionName)
                {
                    M = 1;
                    // Hide unnecessary panels and adjust the layout
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

            // Show a message if the user does not have the required permission
            if (M != 1)
            {
                MessageBoxEx.Show("Please Check Your Permission.", Resources.M01, MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
        }


        private void Close_Btn_Click(object sender, EventArgs e)
        {
            // Check if the Subform is not null
            if (Subform != null)
            {
                // Close the current form
                Close();

                // Send the Details_Pan to the back
                Subform.Details_Pan.SendToBack();

                // Show the panels in the Subform
                Subform.panel1.Show();
                Subform.panel2.Show();

                // Reload the search functionality in the Subform
                Subform.Search_Load(sender, e);
            }
            else
            {
                // Close the current form
                Close();

                // Show the Menu_Pan in the Mainform
                Mainform.Menu_Pan.Show();
            }
        }


        private void Date_Txt_Enter(object sender, EventArgs e)
        {
            // Get the current date
            DateTime currentDate = DateTime.Now.Date;

            // Calculate the target date, which is the 25th of the current or next month
            DateTime targetDate = currentDate.Day <= 15
                ? currentDate.AddDays(25 - currentDate.Day)
                : currentDate.AddDays(25 - currentDate.Day).AddMonths(1);

            // Set the Date_Txt value to the target date
            Date_Txt.Value = targetDate;
        }


        private void FirstPay_Txt_Enter(object sender, EventArgs e)
        {
            // Check if DAmount_Txt and FirstRate_Txt are not null or empty
            if (!string.IsNullOrEmpty(DAmount_Txt.Text) && !string.IsNullOrEmpty(FirstRate_Txt.Text))
            {
                // Convert DAmount_Txt to double and round to 2 decimal places
                double amount = Math.Round(Convert.ToDouble(DAmount_Txt.Text), 2);
                // Convert FirstRate_Txt to double
                double rate = Convert.ToDouble(FirstRate_Txt.Text);
                // Calculate the first payment amount
                double firstPay = amount * rate / 100;
                // Set the calculated value to FirstPay_Txt
                FirstPay_Txt.Text = firstPay.ToString();
            }
        }


        private void Amount_Txt_Enter(object sender, EventArgs e)
        {
            // Check if DAmount_Txt is not null or empty
            if (!string.IsNullOrEmpty(DAmount_Txt.Text))
            {
                // Convert DAmount_Txt to double and round to 2 decimal places
                double amount = Math.Round(Convert.ToDouble(DAmount_Txt.Text), 2);
                // Convert Rate_Txt to double
                double rate = Convert.ToDouble(Rate_Txt.Text);
                // Convert Tenor_Txt to double and calculate the period in years
                double tenor = Convert.ToDouble(Tenor_Txt.Text) / 12;

                // Calculate the sale price
                double salePrice = amount + (amount * (rate / 100) * tenor);
                // Set the calculated sale price to salePriceTextBox
                salePriceTextBox.Text = Math.Round(salePrice, 2).ToString();

                // Calculate the balance
                double balance = salePrice - Convert.ToDouble(FirstPay_Txt.Text);
                // Set the calculated balance to balanceTextBox
                balanceTextBox.Text = Math.Round(balance, 2).ToString();

                // Calculate the amount per installment
                double installmentAmount = balance / Convert.ToDouble(Tenor_Txt.Text);
                // Set the calculated installment amount to Amount_Txt
                Amount_Txt.Text = Math.Round(installmentAmount, 2).ToString();
            }
        }


        private void Cheque_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if there are any rows in the Cheque_Grid
            if (Cheque_Grid.RowCount > 0)
            {
                // Fill the T_Installment table with data based on the selected row's first cell value
                T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
            }
        }


        private void Rate_Txt_Enter(object sender, EventArgs e) => Rate_Txt.Text = "13.3";

        private void FirstRate_Txt_Enter(object sender, EventArgs e) => FirstRate_Txt.Text = "30";

        private void FirstPay_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                // Convert the text in FirstPay_Txt to a decimal and get the selected currency
                decimal amount = Convert.ToDecimal(FirstPay_Txt.Text);
                CurrencyInfo selectedCurrency = Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)];

                // Create a ToWord instance and convert the amount to Arabic words
                ToWord toWord = new ToWord(amount, selectedCurrency);
                txtEnglishWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                // Clear the txtEnglishWord text if an exception occurs
                txtEnglishWord.Text = string.Empty;
            }
        }


        private void Amount_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                // Convert the text in Amount_Txt to a decimal and get the selected currency
                decimal amount = Convert.ToDecimal(Amount_Txt.Text);
                CurrencyInfo selectedCurrency = Currencies[Convert.ToInt32(Currency_Txt.SelectedValue)];

                // Create a ToWord instance and convert the amount to Arabic words
                ToWord toWord = new ToWord(amount, selectedCurrency);
                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                // Clear the txtArabicWord text if an exception occurs
                txtArabicWord.Text = string.Empty;
            }
        }


        private void LastPay_Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert the last payment amount to a decimal and get the selected currency
                decimal lastPaymentAmount = Convert.ToDecimal(LastPay_Txt.Text);
                int selectedCurrencyIndex = Convert.ToInt32(Currency_Txt.SelectedValue);
                CurrencyInfo selectedCurrency = Currencies[selectedCurrencyIndex];

                // Convert the amount to Arabic words
                ToWord toWord = new ToWord(lastPaymentAmount, selectedCurrency);
                txtArabicWord.Text = toWord.ConvertToArabic();
            }
            catch (Exception)
            {
                // Clear the Arabic words text box if an error occurs
                txtArabicWord.Text = string.Empty;
            }

        }

        private void Dealer_Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                // Ensure the database connection is open
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Create and configure the OleDbCommand
                using (OleDbCommand cmd = new OleDbCommand
                {
                    Connection = Con,
                    CommandText = "SELECT CIF, TaxID FROM T_Dealer WHERE DealerName = @DealerName"
                })
                {
                    // Add the parameter to the command
                    cmd.Parameters.AddWithValue("@DealerName", Dealer_Txt.Text);

                    // Execute the command and read the results
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the text boxes with the retrieved data
                            DealerCIF_Txt.Text = reader["CIF"].ToString();
                            TaxID_Txt.Text = reader["TaxID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Can't retrieve data from the database. Please contact the system administrator.\r\n" + ex.Message, "Error Cheque - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the database connection is closed
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Tenor_Txt_Enter(object sender, EventArgs e) => Tenor_Txt.Text = "36";

        //************************ General Function *********************************************//

        private void Edit(bool isReadOnly, bool isEnabled)
        {
            // Enable or disable controls based on the provided values
            Save_Btn.Enabled = isEnabled;
            Name_Txt.Enabled = isEnabled;
            Dealer_Txt.Enabled = isEnabled;
            CIF_Txt.ReadOnly = isReadOnly;
            DealerCIF_Txt.ReadOnly = isReadOnly;
            Deal_Txt.ReadOnly = isReadOnly;
            Tenor_Txt.ReadOnly = isReadOnly;
            FirstPay_Txt.ReadOnly = isReadOnly;
            Rate_Txt.ReadOnly = isReadOnly;
            Currency_Txt.Enabled = isEnabled;
            Date_Txt.Enabled = isEnabled;
            DAmount_Txt.ReadOnly = isReadOnly;
            FirstRate_Txt.ReadOnly = isReadOnly;
            InvoiceNo_Txt.ReadOnly = isReadOnly;
            TaxID_Txt.ReadOnly = isReadOnly;
            Amount_Txt.ReadOnly = isReadOnly;
            Balloon_Txt.ReadOnly = isReadOnly;
            BalloMon_Txt.ReadOnly = isReadOnly;

            // Check user permissions and enable Date_Txt if the user has access
            Login.Instance.Check(Login.Instance.UserName, Date_Txt.Name);
            foreach (var obj in Login.Instance.List)
            {
                if (Date_Txt.Name == obj.FunctionName)
                {
                    Date_Txt.Enabled = isEnabled;
                }
            }
        }


        public static InputLanguage GetInput(string inputName)
        {
            // Iterate through all installed input languages
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                // Check if the language's English name starts with the specified input name (case-insensitive)
                if (lang.Culture.EnglishName.StartsWith(inputName, StringComparison.OrdinalIgnoreCase))
                {
                    return lang; // Return the matching input language
                }
            }
            return null; // Return null if no matching language is found
        }



        private void SwitchInput(InputLanguage layout) => InputLanguage.CurrentInputLanguage = layout;

        private void ProID_Txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Cast the sender to a Control
            Ctrl = (Control)sender;

            // Check if the control is a TextBox
            if (Ctrl is TextBox)
            {
                // If the Enter key is pressed, move to the next control
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
            }
            // Check if the control is a ComboBox
            else if (Ctrl is ComboBox)
            {
                // If the Enter key is pressed, move to the next control
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
            }
            // Check if the control is a DateTimePicker
            else if (Ctrl is DateTimePicker)
            {
                // If the Enter key is pressed, move to the next control
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
            }
            // Check if the control is a MaskedTextBox
            else if (Ctrl is MaskedTextBox)
            {
                // If the Enter key is pressed, move to the next control
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
            }
            // For any other control type
            else
            {
                // If the Enter key is pressed, move to the next control
                if (e.KeyCode == Keys.Enter)
                {
                    SelectNextControl(Ctrl, true, true, true, true);
                }
            }
        }


        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the character that was pressed
            char ch = e.KeyChar;

            // Check if the character is not a number, backspace, or period
            if (!char.IsNumber(ch) && ch != 8 && ch != 46)
            {
                // If the character is invalid, handle the event to prevent it from being processed
                e.Handled = true;
            }
        }

        private void English_Enter(object sender, EventArgs e) => SwitchInput(GetInput("english"));

        private void Query(string query, params object[] parameters)
        {
            try
            {
                // Ensure the connection is open
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                // Dispose of the previous command and create a new one
                Cmd.Dispose();
                Cmd = new OleDbCommand(query, Con);

                // Add parameters to the command
                for (int i = 0; i < parameters.Length; i++)
                {
                    Cmd.Parameters.AddWithValue($"@{i}", parameters[i]);
                }

                // Execute the command
                Cmd.ExecuteNonQuery();

                // Clear the parameters and close the connection
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Can't Retrieve Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Calculates the Takaful amount based on the balance, amount, and tenor.
        /// </summary>
        private void Takaful()
        {
            try
            {
                // Convert input values from text boxes to appropriate data types
                double balance = Convert.ToDouble(balanceTextBox.Text);
                double amount = Convert.ToDouble(Amount_Txt.Text);
                int tenor = Convert.ToInt32(Tenor_Txt.Text);

                // Calculate the base St value
                double St = (balance * 0.01) * (1 + 0.005 + 0.005);

                // Initialize Sd and Th to zero
                double Sd = 0;
                double Th = 0;

                // Calculate Sd if tenor is greater than 12 months
                if (tenor > 12)
                {
                    Sd = ((tenor - 12) * amount) * 0.01 * (1 + 0.005 + 0.005);
                }

                // Calculate Th if tenor is greater than 24 months
                if (tenor > 24)
                {
                    Th = ((tenor - 24) * amount) * 0.01 * (1 + 0.005 + 0.005);
                }

                // Calculate the final Takaful amount
                double takafulAmount = St + Sd + Th + 125;

                // Display the calculated Takaful amount in the text box
                takafulTextBox.Text = Math.Round(takafulAmount, 2).ToString();
            }
            catch (FormatException ex)
            {
                // Handle invalid input format exception
                MessageBox.Show("Invalid input format. Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Retrieve the Dealer CIF text
                string dealerCIF = DealerCIF_Txt.Text;

                // Ensure the connection is open
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

                // Set up the command connection and text
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
                Cmd.Parameters.AddWithValue("@10", "CIF : " + dealerCIF);
                Cmd.ExecuteNonQuery();

                // Clear the parameters and close the connection
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Can't Insert Data in Tax Table, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BalloMon_Txt_Enter(object sender, EventArgs e)
        {
            try
            {
                double balloonAmount = Convert.ToDouble(Balloon_Txt.Text);
                double amount = Convert.ToDouble(Amount_Txt.Text);
                BalloMon_Txt.Text = (balloonAmount + amount).ToString();
            }
            catch (FormatException)
            {
                // Log or handle the exception as needed
                MessageBox.Show("Invalid input format. Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Balloon_Txt_Enter(object sender, EventArgs e) => Balloon_Txt.Text = "0";


        //************************ Edit Methods *********************************************//

        // Method to toggle edit mode
        private void ToggleEditMode(bool isEditMode, bool isNewMode)
        {
            Edit(isEditMode, isNewMode);
        }

        // Method to set the states of New and Save buttons
        private void SetButtonStates(bool isNewEnabled, bool isSaveEnabled)
        {
            New_Btn.Enabled = isNewEnabled;
            Save_Btn.Enabled = isSaveEnabled;
        }

        // Method to update cheque details
        private void UpdateCheque()
        {
            Takaful();
            ToggleEditMode(true, false);
            SetButtonStates(true, true);
            Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);

            try
            {
                // Backup existing cheque data
                BackupChequeData();
                // Update cheque data in the database
                UpdateChequeData();
                // Backup and update installment data
                BackupInstallmentData();
                // Backup and update advanced tax data
                BackupAdvancedTaxData();
                // Refresh data grids to reflect changes
                RefreshDataGrids();
                MessageBoxEx.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Problem in Database, Can't Update Your Data.\r\nCall System Administrator\r\n{ex.Message}", "Error Cheque - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to backup existing cheque data
        private void BackupChequeData()
        {
            Query("INSERT INTO T_ChequeRecycle (ID, CutName, CIF, Deal, DAmount, Tenor, Rate, FirstRate, FirstPay, FirstPayAr, Amount, Currancy, C_Date, AmountAr, TxDate, UserID, SalePrice, Balance, Takaful, Dealer, DealerCIF, TaxID, InvoiceNo, Balloon, BalloMon) " +
                  "SELECT ID, CutName, CIF, Deal, DAmount, Tenor, Rate, FirstRate, FirstPay, FirstPayAr, Amount, Currancy, C_Date, AmountAr, TxDate, UserID, SalePrice, Balance, Takaful, Dealer, DealerCIF, TaxID, InvoiceNo, Balloon, BalloMon FROM T_Cheque WHERE ID=@0;",ID_Txt.Text);
        }

        // Method to update cheque data in the database
        private void UpdateChequeData()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();

            Cmd.Connection = Con;
            Cmd.CommandText = "UPDATE T_Cheque SET CutName = @1, CIF = @2, Deal = @3, DAmount = @4, Tenor = @5, Rate = @6, " +
                              "FirstRate = @7, FirstPay = @8, FirstPayAr = @9, Amount = @10, Currancy = @11, AmountAr = @12, " +
                              "C_Date = @13, UserID = @14, SalePrice = @15, Balance = @16, Takaful = @17, Dealer = @18, " +
                              "DealerCIF = @19, TaxID = @20, InvoiceNo = @21, Balloon = @22, BalloMon = @23 WHERE ID = @24";

            AddCommandParameters();
            int rowsAffected = Cmd.ExecuteNonQuery();

            // Check if any rows were affected
            if (rowsAffected == 0)
            {
                MessageBox.Show("No rows were updated. Please check the parameters and query.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cmd.Parameters.Clear();
            Con.Close();

            Query("UPDATE T_ChequeRecycle SET DelDate = '"+ DateTime.Now +"', DelUserName = '"+ Login.Instance.UserName +"', DelStatus = 'Modify' WHERE ID = @0;", ID_Txt.Text);
        }

        // Method to add parameters to the command
        private void AddCommandParameters()
        {
            //Cmd.Parameters.AddWithValue("@0", ID_Txt.Text);
            Cmd.Parameters.AddWithValue("@1", Name_Txt.Text);
            Cmd.Parameters.AddWithValue("@2", CIF_Txt.Text);
            Cmd.Parameters.AddWithValue("@3", Deal_Txt.Text);
            Cmd.Parameters.AddWithValue("@4", DAmount_Txt.Text);
            Cmd.Parameters.AddWithValue("@5", Tenor_Txt.Text);
            Cmd.Parameters.AddWithValue("@6", Rate_Txt.Text);
            Cmd.Parameters.AddWithValue("@7", FirstRate_Txt.Text);
            Cmd.Parameters.AddWithValue("@8", FirstPay_Txt.Text);
            Cmd.Parameters.AddWithValue("@9", txtEnglishWord.Text);
            Cmd.Parameters.AddWithValue("@10", Amount_Txt.Text);
            Cmd.Parameters.AddWithValue("@11", Currency_Txt.SelectedValue);
            Cmd.Parameters.AddWithValue("@12", txtArabicWord.Text);
            Cmd.Parameters.AddWithValue("@13", Date_Txt.Text);
            Cmd.Parameters.AddWithValue("@14", Login.Instance.UserID);
            Cmd.Parameters.AddWithValue("@15", salePriceTextBox.Text);
            Cmd.Parameters.AddWithValue("@16", balanceTextBox.Text);
            Cmd.Parameters.AddWithValue("@17", takafulTextBox.Text);
            Cmd.Parameters.AddWithValue("@18", Dealer_Txt.Text);
            Cmd.Parameters.AddWithValue("@19", DealerCIF_Txt.Text);
            Cmd.Parameters.AddWithValue("@20", TaxID_Txt.Text);
            Cmd.Parameters.AddWithValue("@21", InvoiceNo_Txt.Text);
            Cmd.Parameters.AddWithValue("@22", Balloon_Txt.Text);
            Cmd.Parameters.AddWithValue("@23", BalloMon_Txt.Text);
            Cmd.Parameters.AddWithValue("@24", ID_Txt.Text);
        }

        // Method to backup existing installment data
        private void BackupInstallmentData()
        {
            Query("INSERT INTO T_InstallmentRecycle (ID, Deal, Ins_Amount, Ins_AmountAr, Ins_Count, Ins_Date) " +
                  "SELECT ID, Deal, Ins_Amount, Ins_AmountAr, Count, Ins_Date FROM T_Installment WHERE ID=@0;", ID_Txt.Text);
            Query("DELETE FROM T_Installment WHERE ID=@0;", ID_Txt.Text);
            Query("UPDATE T_InstallmentRecycle SET DelDate = '" + DateTime.Now + "', DelUserName = '" + Login.Instance.UserName + "', DelStatus = 'Modify' WHERE ID = @0;", ID_Txt.Text);
        }

        // Method to backup existing advanced tax data
        private void BackupAdvancedTaxData()
        {
            Query("INSERT INTO T_AdvancedTaxRecycle (ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate) " +
                  "SELECT ID, CustName, DealerName, Type, Deal, CDate, TaxID, Amount, InvoiceAmount, Tax, InvoiceNo, Account, CDate2, UserID, TxDate FROM T_AdvancedTax WHERE ID=@0;", ID_Txt.Text);
            Query("DELETE FROM T_AdvancedTax WHERE ID=@0;", ID_Txt.Text);
            Query("UPDATE T_AdvancedTaxRecycle SET DelDate = '" + DateTime.Now + "', DelUserName = '" + Login.Instance.UserName + "', DelStatus = 'Modify' WHERE ID = @0;", ID_Txt.Text);
        }

        // Method to refresh data grids to reflect changes
        private void RefreshDataGrids()
        {
            if (Cheque_Grid.RowCount > 0)
            {
                T_InstTabAd.FillByID(ChequerSet.T_Installment, Cheque_Grid.CurrentRow.Cells[0].Value.ToString());
            }
            Installment();
            AdvancedTax();
            T_ChequeTabAd.FillByDate(ChequerSet.T_Cheque, startDate, endDate);
        }
    }

}
