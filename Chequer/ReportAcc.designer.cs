namespace Chequer
{
    partial class Accounting
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
            this.SystemInfo_Group = new System.Windows.Forms.GroupBox();
            this.To_Txt = new System.Windows.Forms.DateTimePicker();
            this.From_Txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contract_Txt = new System.Windows.Forms.ComboBox();
            this.T_ContractBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.CoSet = new Chequer.ChequerDataSet();
            this.Pay_Txt = new System.Windows.Forms.ComboBox();
            this.T_PayBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Reload_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Report_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_Col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Contract_Col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antibody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PtDataBindour = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.SystemInfo_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_ContractBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_PayBindSour)).BeginInit();
            this.panel1.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtDataBindour)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemInfo_Group
            // 
            this.SystemInfo_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SystemInfo_Group.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfo_Group.Controls.Add(this.To_Txt);
            this.SystemInfo_Group.Controls.Add(this.From_Txt);
            this.SystemInfo_Group.Controls.Add(this.label3);
            this.SystemInfo_Group.Controls.Add(this.label1);
            this.SystemInfo_Group.Controls.Add(this.label4);
            this.SystemInfo_Group.Controls.Add(this.label2);
            this.SystemInfo_Group.Controls.Add(this.Contract_Txt);
            this.SystemInfo_Group.Controls.Add(this.Pay_Txt);
            this.SystemInfo_Group.Controls.Add(this.Reload_Btn);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.SystemInfo_Group.Location = new System.Drawing.Point(312, 11);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(396, 149);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "Search";
            // 
            // To_Txt
            // 
            this.To_Txt.Checked = false;
            this.To_Txt.CustomFormat = "dd/MM/yyyy";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(251, 85);
            this.To_Txt.MaxDate = new System.DateTime(2022, 1, 31, 0, 0, 0, 0);
            this.To_Txt.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.To_Txt.Name = "To_Txt";
            this.To_Txt.ShowCheckBox = true;
            this.To_Txt.Size = new System.Drawing.Size(113, 22);
            this.To_Txt.TabIndex = 17;
            this.To_Txt.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // From_Txt
            // 
            this.From_Txt.Checked = false;
            this.From_Txt.CustomFormat = "dd/MM/yyyy";
            this.From_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_Txt.Location = new System.Drawing.Point(99, 85);
            this.From_Txt.MaxDate = new System.DateTime(2022, 1, 31, 0, 0, 0, 0);
            this.From_Txt.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.From_Txt.Name = "From_Txt";
            this.From_Txt.ShowCheckBox = true;
            this.From_Txt.Size = new System.Drawing.Size(113, 22);
            this.From_Txt.TabIndex = 16;
            this.From_Txt.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(218, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contract :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pay Method :";
            // 
            // Contract_Txt
            // 
            this.Contract_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Contract_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Contract_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Contract_Txt.DataSource = this.T_ContractBindSour;
            this.Contract_Txt.DisplayMember = "CName";
            this.Contract_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contract_Txt.ForeColor = System.Drawing.Color.Black;
            this.Contract_Txt.FormattingEnabled = true;
            this.Contract_Txt.Location = new System.Drawing.Point(99, 51);
            this.Contract_Txt.Name = "Contract_Txt";
            this.Contract_Txt.Size = new System.Drawing.Size(265, 23);
            this.Contract_Txt.TabIndex = 15;
            this.Contract_Txt.ValueMember = "CName";
            // 
            // T_ContractBindSour
            // 
            this.T_ContractBindSour.DataMember = "T_Contract";
            this.T_ContractBindSour.DataSource = this.CoSet;
            // 
            // CoSet
            // 
            this.CoSet.DataSetName = "ChequerDataSet";
            this.CoSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pay_Txt
            // 
            this.Pay_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Pay_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Pay_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Pay_Txt.DataSource = this.T_PayBindSour;
            this.Pay_Txt.DisplayMember = "PayMethod";
            this.Pay_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Txt.ForeColor = System.Drawing.Color.Black;
            this.Pay_Txt.FormattingEnabled = true;
            this.Pay_Txt.Location = new System.Drawing.Point(99, 22);
            this.Pay_Txt.Name = "Pay_Txt";
            this.Pay_Txt.Size = new System.Drawing.Size(265, 23);
            this.Pay_Txt.TabIndex = 15;
            this.Pay_Txt.ValueMember = "PayMethod";
            // 
            // T_PayBindSour
            // 
            this.T_PayBindSour.DataMember = "T_Payment";
            this.T_PayBindSour.DataSource = this.CoSet;
            // 
            // Reload_Btn
            // 
            this.Reload_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Reload_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Reload_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Reload_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Reload_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload_Btn.ForeColor = System.Drawing.Color.Black;
            this.Reload_Btn.Image = global::Chequer.Properties.Resources.Dark_Print_18;
            this.Reload_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reload_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reload_Btn.Location = new System.Drawing.Point(215, 113);
            this.Reload_Btn.Name = "Reload_Btn";
            this.Reload_Btn.Size = new System.Drawing.Size(89, 30);
            this.Reload_Btn.TabIndex = 5;
            this.Reload_Btn.Text = "Print";
            this.Reload_Btn.UseVisualStyleBackColor = true;
            this.Reload_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Btn.Image = global::Chequer.Properties.Resources.Dark_Search_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(92, 113);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(89, 30);
            this.Save_Btn.TabIndex = 4;
            this.Save_Btn.Text = "Seach";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 25);
            this.panel1.TabIndex = 2;
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
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Report_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 195);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 405);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Patient List";
            // 
            // Report_Grid
            // 
            this.Report_Grid.AllowUserToAddRows = false;
            this.Report_Grid.AllowUserToDeleteRows = false;
            this.Report_Grid.AllowUserToResizeColumns = false;
            this.Report_Grid.AllowUserToResizeRows = false;
            this.Report_Grid.AutoGenerateColumns = false;
            this.Report_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Report_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Report_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Report_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.ptNameDataGridViewTextBoxColumn,
            this.Pay_Col,
            this.Contract_Col,
            this.Amount_Col,
            this.cDateDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.Gender,
            this.passportDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.PCR,
            this.Antibody,
            this.PDate,
            this.userNameDataGridViewTextBoxColumn,
            this.lockDataGridViewCheckBoxColumn});
            this.Report_Grid.DataSource = this.PtDataBindour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Report_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Report_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_Grid.EnableHeadersVisualStyles = false;
            this.Report_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Report_Grid.Location = new System.Drawing.Point(3, 18);
            this.Report_Grid.MultiSelect = false;
            this.Report_Grid.Name = "Report_Grid";
            this.Report_Grid.ReadOnly = true;
            this.Report_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Report_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Report_Grid.RowTemplate.DividerHeight = 4;
            this.Report_Grid.RowTemplate.Height = 25;
            this.Report_Grid.RowTemplate.ReadOnly = true;
            this.Report_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Report_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_Grid.ShowCellErrors = false;
            this.Report_Grid.ShowCellToolTips = false;
            this.Report_Grid.ShowEditingIcon = false;
            this.Report_Grid.ShowRowErrors = false;
            this.Report_Grid.Size = new System.Drawing.Size(1014, 384);
            this.Report_Grid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Pt ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 90;
            // 
            // ptNameDataGridViewTextBoxColumn
            // 
            this.ptNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptNameDataGridViewTextBoxColumn.DataPropertyName = "PtName";
            this.ptNameDataGridViewTextBoxColumn.FillWeight = 113.8144F;
            this.ptNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.ptNameDataGridViewTextBoxColumn.Name = "ptNameDataGridViewTextBoxColumn";
            this.ptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pay_Col
            // 
            this.Pay_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pay_Col.DataPropertyName = "Pay";
            this.Pay_Col.DataSource = this.T_PayBindSour;
            this.Pay_Col.DisplayMember = "PayMethod";
            this.Pay_Col.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Pay_Col.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pay_Col.HeaderText = "Pay";
            this.Pay_Col.Name = "Pay_Col";
            this.Pay_Col.ReadOnly = true;
            this.Pay_Col.ValueMember = "PayMethod";
            this.Pay_Col.Width = 150;
            // 
            // Contract_Col
            // 
            this.Contract_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Contract_Col.DataPropertyName = "Contract";
            this.Contract_Col.DataSource = this.T_ContractBindSour;
            this.Contract_Col.DisplayMember = "CName";
            this.Contract_Col.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Contract_Col.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contract_Col.HeaderText = "Contract";
            this.Contract_Col.Name = "Contract_Col";
            this.Contract_Col.ReadOnly = true;
            this.Contract_Col.ValueMember = "CName";
            this.Contract_Col.Width = 150;
            // 
            // Amount_Col
            // 
            this.Amount_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount_Col.DataPropertyName = "Amount";
            this.Amount_Col.HeaderText = "Amount";
            this.Amount_Col.Name = "Amount_Col";
            this.Amount_Col.ReadOnly = true;
            this.Amount_Col.Width = 150;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.FillWeight = 113.8144F;
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 30.92784F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Visible = false;
            this.birthdayDataGridViewTextBoxColumn.Width = 90;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 113.8144F;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Visible = false;
            this.phoneDataGridViewTextBoxColumn.Width = 90;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            this.Gender.Width = 90;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.FillWeight = 113.8144F;
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportDataGridViewTextBoxColumn.Visible = false;
            this.passportDataGridViewTextBoxColumn.Width = 90;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.FillWeight = 113.8144F;
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            this.nationalityDataGridViewTextBoxColumn.Visible = false;
            this.nationalityDataGridViewTextBoxColumn.Width = 90;
            // 
            // PCR
            // 
            this.PCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PCR.DataPropertyName = "PCR";
            this.PCR.HeaderText = "PCR";
            this.PCR.Name = "PCR";
            this.PCR.ReadOnly = true;
            this.PCR.Visible = false;
            this.PCR.Width = 90;
            // 
            // Antibody
            // 
            this.Antibody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Antibody.DataPropertyName = "Antibody";
            this.Antibody.HeaderText = "Antibody";
            this.Antibody.Name = "Antibody";
            this.Antibody.ReadOnly = true;
            this.Antibody.Visible = false;
            this.Antibody.Width = 90;
            // 
            // PDate
            // 
            this.PDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PDate.DataPropertyName = "PDate";
            this.PDate.HeaderText = "Pr. Date";
            this.PDate.Name = "PDate";
            this.PDate.ReadOnly = true;
            this.PDate.Visible = false;
            this.PDate.Width = 90;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lockDataGridViewCheckBoxColumn
            // 
            this.lockDataGridViewCheckBoxColumn.DataPropertyName = "Lock";
            this.lockDataGridViewCheckBoxColumn.HeaderText = "Lock";
            this.lockDataGridViewCheckBoxColumn.Name = "lockDataGridViewCheckBoxColumn";
            this.lockDataGridViewCheckBoxColumn.ReadOnly = true;
            this.lockDataGridViewCheckBoxColumn.Visible = false;
            // 
            // PtDataBindour
            // 
            this.PtDataBindour.DataMember = "PtData";
            this.PtDataBindour.DataSource = this.CoSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SystemInfo_Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 170);
            this.panel2.TabIndex = 0;
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1020, 600);
            this.Name = "Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Report_Load);
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_ContractBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_PayBindSour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtDataBindour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Report_Grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Button Reload_Btn;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Pay_Txt;
        private ChequerDataSet CoSet;
        private System.Windows.Forms.BindingSource PtDataBindour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Contract_Txt;
        private System.Windows.Forms.BindingSource T_PayBindSour;
        private System.Windows.Forms.BindingSource T_ContractBindSour;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Pay_Col;
        private System.Windows.Forms.DataGridViewComboBoxColumn Contract_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antibody;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockDataGridViewCheckBoxColumn;
    }
}