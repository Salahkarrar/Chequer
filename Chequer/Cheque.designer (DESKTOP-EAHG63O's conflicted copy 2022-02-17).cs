namespace Chequer
{
    partial class Cheque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Currency_Txt = new System.Windows.Forms.ComboBox();
            this.Amount_Txt = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.txtArabicWord = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cheque_Group = new System.Windows.Forms.GroupBox();
            this.Perview_Txt = new System.Windows.Forms.CheckBox();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Name_Txt = new System.Windows.Forms.ComboBox();
            this.Date_Lab = new System.Windows.Forms.Label();
            this.Date_Txt = new System.Windows.Forms.DateTimePicker();
            this.ContactNumber_Lab = new System.Windows.Forms.Label();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.ID_Lab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_Lab = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Deal_Txt = new System.Windows.Forms.TextBox();
            this.Rate_Txt = new System.Windows.Forms.TextBox();
            this.CIF_Txt = new System.Windows.Forms.TextBox();
            this.Tenor_Txt = new System.Windows.Forms.TextBox();
            this.ID_Txt = new System.Windows.Forms.TextBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Cheque_Grid = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.T_ChequeBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_InstBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_ChequeTabAd = new Chequer.ChequerDataSetTableAdapters.T_ChequeTableAdapter();
            this.T_InstTabAd = new Chequer.ChequerDataSetTableAdapters.T_InstallmentTableAdapter();
            this.ID_textGraid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Cheque_Group.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cheque_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_InstBindSour)).BeginInit();
            this.SuspendLayout();
            // 
            // Currency_Txt
            // 
            this.Currency_Txt.DisplayMember = "EnglishCurrencyName";
            this.Currency_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Currency_Txt.ForeColor = System.Drawing.Color.Black;
            this.Currency_Txt.FormattingEnabled = true;
            this.Currency_Txt.Location = new System.Drawing.Point(246, 82);
            this.Currency_Txt.Name = "Currency_Txt";
            this.Currency_Txt.Size = new System.Drawing.Size(112, 23);
            this.Currency_Txt.TabIndex = 8;
            this.Currency_Txt.ValueMember = "CurrencyID";
            this.Currency_Txt.DropDownClosed += new System.EventHandler(this.CboCurrency_DropDownClosed);
            this.Currency_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Amount_Txt
            // 
            this.Amount_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "Amount", true));
            this.Amount_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Amount_Txt.ForeColor = System.Drawing.Color.Black;
            this.Amount_Txt.Location = new System.Drawing.Point(64, 82);
            this.Amount_Txt.Name = "Amount_Txt";
            this.Amount_Txt.Size = new System.Drawing.Size(113, 22);
            this.Amount_Txt.TabIndex = 7;
            this.Amount_Txt.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            this.Amount_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnglishWord.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtEnglishWord.ForeColor = System.Drawing.Color.Black;
            this.txtEnglishWord.Location = new System.Drawing.Point(64, 183);
            this.txtEnglishWord.Multiline = true;
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.ReadOnly = true;
            this.txtEnglishWord.Size = new System.Drawing.Size(568, 23);
            this.txtEnglishWord.TabIndex = 5;
            this.txtEnglishWord.Visible = false;
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArabicWord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "AmountAr", true));
            this.txtArabicWord.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtArabicWord.ForeColor = System.Drawing.Color.Black;
            this.txtArabicWord.Location = new System.Drawing.Point(64, 112);
            this.txtArabicWord.Multiline = true;
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.ReadOnly = true;
            this.txtArabicWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArabicWord.Size = new System.Drawing.Size(568, 23);
            this.txtArabicWord.TabIndex = 10;
            this.txtArabicWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 25);
            this.panel1.TabIndex = 7;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.Black;
            this.Close_Btn.Image = global::Chequer.Properties.Resources.Dark_Close_18;
            this.Close_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close_Btn.Location = new System.Drawing.Point(995, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(25, 25);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.UseVisualStyleBackColor = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cheque_Group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 212);
            this.panel3.TabIndex = 8;
            // 
            // Cheque_Group
            // 
            this.Cheque_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cheque_Group.BackColor = System.Drawing.Color.Transparent;
            this.Cheque_Group.Controls.Add(this.Perview_Txt);
            this.Cheque_Group.Controls.Add(this.Print_Btn);
            this.Cheque_Group.Controls.Add(this.txtEnglishWord);
            this.Cheque_Group.Controls.Add(this.Name_Txt);
            this.Cheque_Group.Controls.Add(this.txtArabicWord);
            this.Cheque_Group.Controls.Add(this.Currency_Txt);
            this.Cheque_Group.Controls.Add(this.Date_Lab);
            this.Cheque_Group.Controls.Add(this.Amount_Txt);
            this.Cheque_Group.Controls.Add(this.Date_Txt);
            this.Cheque_Group.Controls.Add(this.ContactNumber_Lab);
            this.Cheque_Group.Controls.Add(this.Delete_Btn);
            this.Cheque_Group.Controls.Add(this.ID_Lab);
            this.Cheque_Group.Controls.Add(this.label6);
            this.Cheque_Group.Controls.Add(this.label1);
            this.Cheque_Group.Controls.Add(this.label3);
            this.Cheque_Group.Controls.Add(this.label7);
            this.Cheque_Group.Controls.Add(this.Name_Lab);
            this.Cheque_Group.Controls.Add(this.New_Btn);
            this.Cheque_Group.Controls.Add(this.label2);
            this.Cheque_Group.Controls.Add(this.Deal_Txt);
            this.Cheque_Group.Controls.Add(this.Rate_Txt);
            this.Cheque_Group.Controls.Add(this.CIF_Txt);
            this.Cheque_Group.Controls.Add(this.Tenor_Txt);
            this.Cheque_Group.Controls.Add(this.ID_Txt);
            this.Cheque_Group.Controls.Add(this.Edit_Btn);
            this.Cheque_Group.Controls.Add(this.Cancel_Btn);
            this.Cheque_Group.Controls.Add(this.Save_Btn);
            this.Cheque_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheque_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cheque_Group.Location = new System.Drawing.Point(186, 4);
            this.Cheque_Group.Name = "Cheque_Group";
            this.Cheque_Group.Size = new System.Drawing.Size(649, 205);
            this.Cheque_Group.TabIndex = 0;
            this.Cheque_Group.TabStop = false;
            this.Cheque_Group.Text = "Information ";
            // 
            // Perview_Txt
            // 
            this.Perview_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Perview_Txt.AutoSize = true;
            this.Perview_Txt.Location = new System.Drawing.Point(292, 179);
            this.Perview_Txt.Name = "Perview_Txt";
            this.Perview_Txt.Size = new System.Drawing.Size(65, 19);
            this.Perview_Txt.TabIndex = 13;
            this.Perview_Txt.Text = "Perview";
            this.Perview_Txt.UseVisualStyleBackColor = true;
            this.Perview_Txt.Visible = false;
            // 
            // Print_Btn
            // 
            this.Print_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Print_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Btn.ForeColor = System.Drawing.Color.Black;
            this.Print_Btn.Image = global::Chequer.Properties.Resources.Dark_Print_18;
            this.Print_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Print_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Print_Btn.Location = new System.Drawing.Point(326, 147);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(70, 25);
            this.Print_Btn.TabIndex = 14;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Name_Txt
            // 
            this.Name_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Name_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "CutName", true));
            this.Name_Txt.DisplayMember = "PtName";
            this.Name_Txt.Enabled = false;
            this.Name_Txt.FormattingEnabled = true;
            this.Name_Txt.Location = new System.Drawing.Point(246, 21);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(241, 23);
            this.Name_Txt.TabIndex = 2;
            this.Name_Txt.ValueMember = "PtName";
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Date_Lab
            // 
            this.Date_Lab.AutoSize = true;
            this.Date_Lab.ForeColor = System.Drawing.Color.Black;
            this.Date_Lab.Location = new System.Drawing.Point(499, 89);
            this.Date_Lab.Name = "Date_Lab";
            this.Date_Lab.Size = new System.Drawing.Size(36, 15);
            this.Date_Lab.TabIndex = 21;
            this.Date_Lab.Text = "Date :";
            // 
            // Date_Txt
            // 
            this.Date_Txt.Checked = false;
            this.Date_Txt.CustomFormat = "dd/MM/yyyyy";
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "C_Date", true));
            this.Date_Txt.Enabled = false;
            this.Date_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Txt.Location = new System.Drawing.Point(541, 83);
            this.Date_Txt.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.Date_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.Size = new System.Drawing.Size(94, 22);
            this.Date_Txt.TabIndex = 9;
            this.Date_Txt.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Enter += new System.EventHandler(this.Date_Txt_Enter);
            this.Date_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // ContactNumber_Lab
            // 
            this.ContactNumber_Lab.AutoSize = true;
            this.ContactNumber_Lab.ForeColor = System.Drawing.Color.Black;
            this.ContactNumber_Lab.Location = new System.Drawing.Point(503, 25);
            this.ContactNumber_Lab.Name = "ContactNumber_Lab";
            this.ContactNumber_Lab.Size = new System.Drawing.Size(32, 15);
            this.ContactNumber_Lab.TabIndex = 22;
            this.ContactNumber_Lab.Text = "CIF :";
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Enabled = false;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_Btn.Image = global::Chequer.Properties.Resources.Dark_Delete_18;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_Btn.Location = new System.Drawing.Point(493, 147);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 16;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Visible = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // ID_Lab
            // 
            this.ID_Lab.AutoSize = true;
            this.ID_Lab.ForeColor = System.Drawing.Color.Black;
            this.ID_Lab.Location = new System.Drawing.Point(32, 25);
            this.ID_Lab.Name = "ID_Lab";
            this.ID_Lab.Size = new System.Drawing.Size(26, 15);
            this.ID_Lab.TabIndex = 18;
            this.ID_Lab.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(178, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Currency :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(476, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sys. Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(196, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tenor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount :";
            // 
            // Name_Lab
            // 
            this.Name_Lab.AutoSize = true;
            this.Name_Lab.ForeColor = System.Drawing.Color.Black;
            this.Name_Lab.Location = new System.Drawing.Point(197, 25);
            this.Name_Lab.Name = "Name_Lab";
            this.Name_Lab.Size = new System.Drawing.Size(41, 15);
            this.Name_Lab.TabIndex = 13;
            this.Name_Lab.Text = "Name :";
            // 
            // New_Btn
            // 
            this.New_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Btn.ForeColor = System.Drawing.Color.Black;
            this.New_Btn.Image = global::Chequer.Properties.Resources.Dark_Add_18;
            this.New_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.New_Btn.Location = new System.Drawing.Point(85, 147);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(70, 25);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deal :";
            // 
            // Deal_Txt
            // 
            this.Deal_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "Deal", true));
            this.Deal_Txt.Location = new System.Drawing.Point(64, 50);
            this.Deal_Txt.MaxLength = 15;
            this.Deal_Txt.Name = "Deal_Txt";
            this.Deal_Txt.Size = new System.Drawing.Size(113, 21);
            this.Deal_Txt.TabIndex = 4;
            this.Deal_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Deal_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Rate_Txt
            // 
            this.Rate_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "Rate", true));
            this.Rate_Txt.Location = new System.Drawing.Point(541, 53);
            this.Rate_Txt.MaxLength = 100;
            this.Rate_Txt.Name = "Rate_Txt";
            this.Rate_Txt.Size = new System.Drawing.Size(94, 21);
            this.Rate_Txt.TabIndex = 6;
            this.Rate_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rate_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Rate_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // CIF_Txt
            // 
            this.CIF_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "CIF", true));
            this.CIF_Txt.Location = new System.Drawing.Point(541, 22);
            this.CIF_Txt.MaxLength = 15;
            this.CIF_Txt.Name = "CIF_Txt";
            this.CIF_Txt.Size = new System.Drawing.Size(94, 21);
            this.CIF_Txt.TabIndex = 3;
            this.CIF_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CIF_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.CIF_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Tenor_Txt
            // 
            this.Tenor_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "Tenor", true));
            this.Tenor_Txt.Location = new System.Drawing.Point(246, 53);
            this.Tenor_Txt.MaxLength = 100;
            this.Tenor_Txt.Name = "Tenor_Txt";
            this.Tenor_Txt.Size = new System.Drawing.Size(112, 21);
            this.Tenor_Txt.TabIndex = 5;
            this.Tenor_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tenor_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Tenor_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // ID_Txt
            // 
            this.ID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ChequeBindSour, "ID", true));
            this.ID_Txt.Location = new System.Drawing.Point(64, 22);
            this.ID_Txt.MaxLength = 15;
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.ReadOnly = true;
            this.ID_Txt.Size = new System.Drawing.Size(113, 21);
            this.ID_Txt.TabIndex = 1;
            this.ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Btn.ForeColor = System.Drawing.Color.Black;
            this.Edit_Btn.Image = global::Chequer.Properties.Resources.Dark_Edit_18;
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Btn.Location = new System.Drawing.Point(417, 147);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 15;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.ForeColor = System.Drawing.Color.Black;
            this.Cancel_Btn.Image = global::Chequer.Properties.Resources.Dark_Cancel_18;
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_Btn.Location = new System.Drawing.Point(237, 147);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_Btn.TabIndex = 12;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Enabled = false;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Btn.Image = global::Chequer.Properties.Resources.Dark_Save_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(161, 147);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 11;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Cheque_Grid);
            this.Grid_Group.Controls.Add(this.dataGridView1);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 237);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 386);
            this.Grid_Group.TabIndex = 9;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Cheque List";
            // 
            // Cheque_Grid
            // 
            this.Cheque_Grid.AllowUserToAddRows = false;
            this.Cheque_Grid.AllowUserToDeleteRows = false;
            this.Cheque_Grid.AllowUserToResizeRows = false;
            this.Cheque_Grid.AutoGenerateColumns = false;
            this.Cheque_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cheque_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Cheque_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cheque_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Cheque_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cheque_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_textGraid,
            this.cutNameDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.tenorDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.currancyDataGridViewTextBoxColumn,
            this.amountArDataGridViewTextBoxColumn,
            this.txDateDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.UserID});
            this.Cheque_Grid.DataSource = this.T_ChequeBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cheque_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cheque_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cheque_Grid.EnableHeadersVisualStyles = false;
            this.Cheque_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Cheque_Grid.Location = new System.Drawing.Point(3, 18);
            this.Cheque_Grid.MultiSelect = false;
            this.Cheque_Grid.Name = "Cheque_Grid";
            this.Cheque_Grid.ReadOnly = true;
            this.Cheque_Grid.RowHeadersVisible = false;
            this.Cheque_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Cheque_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Cheque_Grid.RowTemplate.DividerHeight = 4;
            this.Cheque_Grid.RowTemplate.Height = 25;
            this.Cheque_Grid.RowTemplate.ReadOnly = true;
            this.Cheque_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Cheque_Grid.ShowCellErrors = false;
            this.Cheque_Grid.ShowCellToolTips = false;
            this.Cheque_Grid.ShowEditingIcon = false;
            this.Cheque_Grid.ShowRowErrors = false;
            this.Cheque_Grid.Size = new System.Drawing.Size(1014, 365);
            this.Cheque_Grid.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.insDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.T_InstBindSour;
            this.dataGridView1.Location = new System.Drawing.Point(107, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 3);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(146, 100);
            this.Details_Pan.TabIndex = 3;
            // 
            // T_ChequeBindSour
            // 
            this.T_ChequeBindSour.DataMember = "T_Cheque";
            this.T_ChequeBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealDataGridViewTextBoxColumn1
            // 
            this.dealDataGridViewTextBoxColumn1.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn1.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn1.Name = "dealDataGridViewTextBoxColumn1";
            this.dealDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // insDateDataGridViewTextBoxColumn
            // 
            this.insDateDataGridViewTextBoxColumn.DataPropertyName = "Ins_Date";
            this.insDateDataGridViewTextBoxColumn.HeaderText = "Ins_Date";
            this.insDateDataGridViewTextBoxColumn.Name = "insDateDataGridViewTextBoxColumn";
            this.insDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // T_InstBindSour
            // 
            this.T_InstBindSour.DataMember = "T_Installment";
            this.T_InstBindSour.DataSource = this.ChequerSet;
            // 
            // T_ChequeTabAd
            // 
            this.T_ChequeTabAd.ClearBeforeFill = true;
            // 
            // T_InstTabAd
            // 
            this.T_InstTabAd.ClearBeforeFill = true;
            // 
            // ID_textGraid
            // 
            this.ID_textGraid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_textGraid.DataPropertyName = "ID";
            this.ID_textGraid.HeaderText = "ID";
            this.ID_textGraid.Name = "ID_textGraid";
            this.ID_textGraid.ReadOnly = true;
            this.ID_textGraid.Width = 80;
            // 
            // cutNameDataGridViewTextBoxColumn
            // 
            this.cutNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cutNameDataGridViewTextBoxColumn.DataPropertyName = "CutName";
            this.cutNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cutNameDataGridViewTextBoxColumn.Name = "cutNameDataGridViewTextBoxColumn";
            this.cutNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIFDataGridViewTextBoxColumn
            // 
            this.cIFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            this.tenorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            this.tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            this.tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            this.tenorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currancyDataGridViewTextBoxColumn
            // 
            this.currancyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.currancyDataGridViewTextBoxColumn.DataPropertyName = "Currancy";
            this.currancyDataGridViewTextBoxColumn.HeaderText = "Currancy";
            this.currancyDataGridViewTextBoxColumn.Name = "currancyDataGridViewTextBoxColumn";
            this.currancyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currancyDataGridViewTextBoxColumn.Visible = false;
            this.currancyDataGridViewTextBoxColumn.Width = 84;
            // 
            // amountArDataGridViewTextBoxColumn
            // 
            this.amountArDataGridViewTextBoxColumn.DataPropertyName = "AmountAr";
            this.amountArDataGridViewTextBoxColumn.HeaderText = "AmountAr";
            this.amountArDataGridViewTextBoxColumn.Name = "amountArDataGridViewTextBoxColumn";
            this.amountArDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountArDataGridViewTextBoxColumn.Visible = false;
            // 
            // txDateDataGridViewTextBoxColumn
            // 
            this.txDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txDateDataGridViewTextBoxColumn.DataPropertyName = "TxDate";
            this.txDateDataGridViewTextBoxColumn.HeaderText = "Tx. Date";
            this.txDateDataGridViewTextBoxColumn.Name = "txDateDataGridViewTextBoxColumn";
            this.txDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.txDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "C_Date";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 80;
            // 
            // Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 623);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Details_Pan);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Cheque_Group.ResumeLayout(false);
            this.Cheque_Group.PerformLayout();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cheque_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_InstBindSour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Currency_Txt;
        private System.Windows.Forms.TextBox Amount_Txt;
        private System.Windows.Forms.TextBox txtEnglishWord;
        private System.Windows.Forms.TextBox txtArabicWord;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox Cheque_Group;
        private System.Windows.Forms.CheckBox Perview_Txt;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.ComboBox Name_Txt;
        private System.Windows.Forms.Label Date_Lab;
        private System.Windows.Forms.DateTimePicker Date_Txt;
        private System.Windows.Forms.Label ContactNumber_Lab;
        protected internal System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label ID_Lab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Name_Lab;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Deal_Txt;
        private System.Windows.Forms.TextBox Rate_Txt;
        private System.Windows.Forms.TextBox CIF_Txt;
        private System.Windows.Forms.TextBox Tenor_Txt;
        private System.Windows.Forms.TextBox ID_Txt;
        protected internal System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Cheque_Grid;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.BindingSource T_ChequeBindSour;
        private ChequerDataSetTableAdapters.T_ChequeTableAdapter T_ChequeTabAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource T_InstBindSour;
        private ChequerDataSetTableAdapters.T_InstallmentTableAdapter T_InstTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insDateDataGridViewTextBoxColumn;
        protected internal System.Windows.Forms.Panel Details_Pan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_textGraid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
    }
}

