﻿using Chequer.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Chequer
{
    public partial class TakafulAdd : Form
    {
        public TakafulAdd(Takaful Tak, string ID, string Name, string Passport, IISMain Main)
        {
            Mainform = Main;
            InitializeComponent();
            ActiveForm.Text = "AAY | IIS | IIS - Takaful - Other";
        }

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.Path);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public IISMain Mainform { get; set; } = null;
        public Control Ctrl;
        public object ID { get; set; }

        protected internal void TakafulAdd_Load(object sender, EventArgs e)
        {
            try
            {
                Enabled = true;
                Edit(true, false);
                T_TakafulTabAd.FillByType(ChequerSet.T_Takaful,"Durable Finance");
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
                MessageBox.Show("Problem in Database." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false, true);
                ChequerSet.T_Takaful.AddT_TakafulRow(ChequerSet.T_Takaful.NewT_TakafulRow());
                T_TakafulBindSour.MoveLast();
                Name_Txt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Make New Row." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Dealer - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name_Txt.Text) && !string.IsNullOrEmpty(Tenor_Txt.Text) && !string.IsNullOrEmpty(CIF_Txt.Text) &&
                    !string.IsNullOrEmpty(Type_Txt.Text) && !string.IsNullOrEmpty(Balance_Txt.Text) && !string.IsNullOrEmpty(Takaful_Txt.Text) &&
                    !string.IsNullOrEmpty(Deal_Txt.Text))
                {
                    Edit(true, false);
                    T_TakafulTabAd.Insert(Name_Txt.Text, Convert.ToInt32(CIF_Txt.Text), Convert.ToDouble(Balance_Txt.Text), Convert.ToDouble(Takaful_Txt.Text),
                        Convert.ToInt32(Tenor_Txt.Text), Convert.ToInt32(Deal_Txt.Text), Date_Txt.Value.Date, Convert.ToInt32($"{Login.Instance.UserID}"), Type_Txt.SelectedItem.ToString());
                    MessageBoxEx.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    T_TakafulTabAd.FillByType(ChequerSet.T_Takaful, "Durable Finance");
                    T_TakafulBindSour.MoveLast();
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again" + "\r\n", "Hand Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Name and CIF Can't Duplicated, Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Dealer - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    try
                    {
                        Query("INSERT INTO T_TakafulRecycle (ID, CutName, CIF, Balance, Takaful, Tenor, Deal, Type, UserID, CDate)" +
                          "SELECT ID, CutName, CIF, Balance, Takaful, Tenor, Deal, Type, UserID, CDate FROM T_Takaful WHERE ID=@0;");
                        T_TakafulBindSour.EndEdit();
                        T_TakafulTabAd.FillByType(ChequerSet.T_Takaful, "Durable Finance");
                        Query("UPDATE T_TakafulRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Modify" + "' WHERE ID=@0;");
                        MessageBoxEx.Show("Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Dealer - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Login.Instance.Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_TakafulBindSour.CancelEdit();
                T_TakafulTabAd.FillByType(ChequerSet.T_Takaful, "Durable Finance");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Cancel Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Dealer - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Query("INSERT INTO T_TakafulRecycle (ID, CutName, CIF, Balance, Takaful, Tenor, Deal, Type, UserID, CDate)" +
                          "SELECT ID, CutName, CIF, Balance, Takaful, Tenor, Deal, Type, UserID, CDate FROM T_Takaful WHERE ID=@0;");
                    Query("DELETE FROM T_Takaful WHERE ID=@0");
                    Query("UPDATE T_TakafulRecycle SET DelDate='" + DateTime.Now + "', DelUserName='" + Login.Instance.UserName + "', DelStatus='" + "Delete" + "' WHERE ID=@0;");
                    T_TakafulTabAd.FillByType(ChequerSet.T_Takaful, "Durable Finance");
                    T_TakafulBindSour.MoveFirst();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Dealer - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Takaful Function //

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Name_Txt.ReadOnly = Value;
            CIF_Txt.ReadOnly = Value;
            Balance_Txt.ReadOnly = Value;
            Takaful_Txt.ReadOnly = Value;
            Tenor_Txt.ReadOnly = Value;
            Deal_Txt.ReadOnly = Value;
            Type_Txt.Enabled = Value2;
            Date_Txt.Enabled = Value2;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            Close();
            Mainform.Takaful_Pan.Show();
            Mainform.Menu_Pan.Show();
            //Mainform.Takaful_Pan.BringToFront();
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
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Cmd.Dispose();
                Cmd.Clone();
                Cmd.Connection = Con;
                Cmd.CommandText = Value;
                Cmd.Parameters.AddWithValue("@0", Takaful_Grid.CurrentRow.Cells[0].Value);
                Cmd.ExecuteNonQuery();
                Cmd.Parameters.Clear();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Retrive Data From Database, Please Call System Administrator" + "\r\n" + ex.Message, "Error Cheque - 1006", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
