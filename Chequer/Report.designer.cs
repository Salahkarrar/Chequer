namespace Chequer
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SystemInfo_Group = new System.Windows.Forms.GroupBox();
            this.To_Txt = new System.Windows.Forms.DateTimePicker();
            this.From_Txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID_Txt = new System.Windows.Forms.ComboBox();
            this.T_UsersBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.Reload_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Report_Grid = new System.Windows.Forms.DataGridView();
            this.T_ChequeBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.T_UsersTabAd = new Chequer.ChequerDataSetTableAdapters.T_UsersTableAdapter();
            this.T_ChequeTabAd = new Chequer.ChequerDataSetTableAdapters.T_ChequeTableAdapter();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountArDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemInfo_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_UsersBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindSour)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.SystemInfo_Group.Controls.Add(this.label2);
            this.SystemInfo_Group.Controls.Add(this.UserID_Txt);
            this.SystemInfo_Group.Controls.Add(this.Reload_Btn);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.SystemInfo_Group.Location = new System.Drawing.Point(338, 7);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(344, 111);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "Search";
            // 
            // To_Txt
            // 
            this.To_Txt.Checked = false;
            this.To_Txt.CustomFormat = "dd/MM/yyyy";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(220, 46);
            this.To_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.To_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.To_Txt.Name = "To_Txt";
            this.To_Txt.ShowCheckBox = true;
            this.To_Txt.Size = new System.Drawing.Size(113, 22);
            this.To_Txt.TabIndex = 17;
            this.To_Txt.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // From_Txt
            // 
            this.From_Txt.Checked = false;
            this.From_Txt.CustomFormat = "dd/MM/yyyy";
            this.From_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_Txt.Location = new System.Drawing.Point(68, 46);
            this.From_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.From_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.From_Txt.Name = "From_Txt";
            this.From_Txt.ShowCheckBox = true;
            this.From_Txt.Size = new System.Drawing.Size(113, 22);
            this.From_Txt.TabIndex = 16;
            this.From_Txt.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(187, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "UserID :";
            // 
            // UserID_Txt
            // 
            this.UserID_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UserID_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserID_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.UserID_Txt.DataSource = this.T_UsersBindSour;
            this.UserID_Txt.DisplayMember = "UserID";
            this.UserID_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_Txt.ForeColor = System.Drawing.Color.Black;
            this.UserID_Txt.FormattingEnabled = true;
            this.UserID_Txt.Location = new System.Drawing.Point(68, 17);
            this.UserID_Txt.Name = "UserID_Txt";
            this.UserID_Txt.Size = new System.Drawing.Size(265, 23);
            this.UserID_Txt.TabIndex = 15;
            this.UserID_Txt.ValueMember = "UserID";
            // 
            // T_UsersBindSour
            // 
            this.T_UsersBindSour.DataMember = "T_Users";
            this.T_UsersBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Reload_Btn.Location = new System.Drawing.Point(220, 74);
            this.Reload_Btn.Name = "Reload_Btn";
            this.Reload_Btn.Size = new System.Drawing.Size(113, 30);
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
            this.Save_Btn.Location = new System.Drawing.Point(68, 74);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(113, 30);
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
            this.Grid_Group.Location = new System.Drawing.Point(0, 150);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 450);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Deals List";
            // 
            // Report_Grid
            // 
            this.Report_Grid.AllowUserToAddRows = false;
            this.Report_Grid.AllowUserToDeleteRows = false;
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
            this.cutNameDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.tenorDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.DAmount,
            this.FirstPay,
            this.amountDataGridViewTextBoxColumn,
            this.Dealer,
            this.currancyDataGridViewTextBoxColumn,
            this.amountArDataGridViewTextBoxColumn,
            this.txDateDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.Report_Grid.DataSource = this.T_ChequeBindSour;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Report_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Report_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report_Grid.EnableHeadersVisualStyles = false;
            this.Report_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Report_Grid.Location = new System.Drawing.Point(3, 18);
            this.Report_Grid.MultiSelect = false;
            this.Report_Grid.Name = "Report_Grid";
            this.Report_Grid.ReadOnly = true;
            this.Report_Grid.RowHeadersVisible = false;
            this.Report_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Report_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Report_Grid.RowTemplate.DividerHeight = 4;
            this.Report_Grid.RowTemplate.Height = 25;
            this.Report_Grid.RowTemplate.ReadOnly = true;
            this.Report_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_Grid.ShowCellErrors = false;
            this.Report_Grid.ShowCellToolTips = false;
            this.Report_Grid.ShowEditingIcon = false;
            this.Report_Grid.ShowRowErrors = false;
            this.Report_Grid.Size = new System.Drawing.Size(1014, 429);
            this.Report_Grid.TabIndex = 0;
            this.Report_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Report_Grid_CellContentClick);
            // 
            // T_ChequeBindSour
            // 
            this.T_ChequeBindSour.DataMember = "T_Cheque";
            this.T_ChequeBindSour.DataSource = this.ChequerSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SystemInfo_Group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 125);
            this.panel3.TabIndex = 0;
            // 
            // T_UsersTabAd
            // 
            this.T_UsersTabAd.ClearBeforeFill = true;
            // 
            // T_ChequeTabAd
            // 
            this.T_ChequeTabAd.ClearBeforeFill = true;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 0);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(146, 100);
            this.Details_Pan.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
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
            this.cIFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIFDataGridViewTextBoxColumn.Width = 58;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealDataGridViewTextBoxColumn.Width = 50;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            this.tenorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            this.tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            this.tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            this.tenorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenorDataGridViewTextBoxColumn.Width = 50;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Width = 50;
            // 
            // DAmount
            // 
            this.DAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DAmount.DataPropertyName = "DAmount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.DAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.DAmount.HeaderText = "D.Amount";
            this.DAmount.Name = "DAmount";
            this.DAmount.ReadOnly = true;
            this.DAmount.Width = 95;
            // 
            // FirstPay
            // 
            this.FirstPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirstPay.DataPropertyName = "FirstPay";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.FirstPay.DefaultCellStyle = dataGridViewCellStyle3;
            this.FirstPay.HeaderText = "FirstPay";
            this.FirstPay.Name = "FirstPay";
            this.FirstPay.ReadOnly = true;
            this.FirstPay.Width = 83;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Monthly";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 86;
            // 
            // Dealer
            // 
            this.Dealer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dealer.DataPropertyName = "Dealer";
            this.Dealer.HeaderText = "Dealer";
            this.Dealer.Name = "Dealer";
            this.Dealer.ReadOnly = true;
            this.Dealer.Width = 73;
            // 
            // currancyDataGridViewTextBoxColumn
            // 
            this.currancyDataGridViewTextBoxColumn.DataPropertyName = "Currancy";
            this.currancyDataGridViewTextBoxColumn.HeaderText = "Currancy";
            this.currancyDataGridViewTextBoxColumn.Name = "currancyDataGridViewTextBoxColumn";
            this.currancyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currancyDataGridViewTextBoxColumn.Visible = false;
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
            this.txDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txDateDataGridViewTextBoxColumn.DataPropertyName = "TxDate";
            this.txDateDataGridViewTextBoxColumn.HeaderText = "Tx. Date";
            this.txDateDataGridViewTextBoxColumn.Name = "txDateDataGridViewTextBoxColumn";
            this.txDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.txDateDataGridViewTextBoxColumn.Width = 83;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "C_Date";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Installment";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Width = 75;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Details_Pan);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_UsersBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ChequeBindSour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Report_Grid;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Button Reload_Btn;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UserID_Txt;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.BindingSource T_UsersBindSour;
        private ChequerDataSetTableAdapters.T_UsersTableAdapter T_UsersTabAd;
        private System.Windows.Forms.BindingSource T_ChequeBindSour;
        private ChequerDataSetTableAdapters.T_ChequeTableAdapter T_ChequeTabAd;
        protected internal System.Windows.Forms.Panel Details_Pan;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn currancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountArDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}