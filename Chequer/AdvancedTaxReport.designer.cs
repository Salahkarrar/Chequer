namespace Chequer
{
    partial class AdvancedTaxReport
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
            this.Type_Txt = new System.Windows.Forms.ComboBox();
            this.Reload_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.AdvancedTaxReport_Grid = new System.Windows.Forms.DataGridView();
            this.T_AdTaxBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.T_AdTaxTabAd = new Chequer.ChequerDataSetTableAdapters.T_AdvancedTaxTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAuto_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemInfo_Group.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedTaxReport_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_AdTaxBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
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
            this.SystemInfo_Group.Controls.Add(this.label2);
            this.SystemInfo_Group.Controls.Add(this.Type_Txt);
            this.SystemInfo_Group.Controls.Add(this.Reload_Btn);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.SystemInfo_Group.Location = new System.Drawing.Point(344, 4);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(332, 114);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "Search";
            // 
            // To_Txt
            // 
            this.To_Txt.Checked = false;
            this.To_Txt.CustomFormat = "dd/MM/yyyy";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(209, 46);
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
            this.From_Txt.Location = new System.Drawing.Point(57, 46);
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
            this.label3.Location = new System.Drawing.Point(176, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 50);
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
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type :";
            // 
            // Type_Txt
            // 
            this.Type_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_Txt.BackColor = System.Drawing.SystemColors.Window;
            this.Type_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Txt.ForeColor = System.Drawing.Color.Black;
            this.Type_Txt.FormattingEnabled = true;
            this.Type_Txt.Items.AddRange(new object[] {
            "",
            "Durable Finance",
            "Corporate Finance",
            "Auto Finance",
            "Construction",
            "SME",
            "Eduction"});
            this.Type_Txt.Location = new System.Drawing.Point(57, 17);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(265, 23);
            this.Type_Txt.TabIndex = 15;
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
            this.Reload_Btn.Location = new System.Drawing.Point(209, 74);
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
            this.Save_Btn.Location = new System.Drawing.Point(57, 74);
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
            this.Grid_Group.Controls.Add(this.AdvancedTaxReport_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 147);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 453);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Advanced Tax List";
            // 
            // AdvancedTaxReport_Grid
            // 
            this.AdvancedTaxReport_Grid.AllowUserToAddRows = false;
            this.AdvancedTaxReport_Grid.AllowUserToDeleteRows = false;
            this.AdvancedTaxReport_Grid.AllowUserToResizeRows = false;
            this.AdvancedTaxReport_Grid.AutoGenerateColumns = false;
            this.AdvancedTaxReport_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdvancedTaxReport_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.AdvancedTaxReport_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdvancedTaxReport_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdvancedTaxReport_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvancedTaxReport_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.IDAuto_Col,
            this.custNameDataGridViewTextBoxColumn,
            this.dealerNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.taxIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.invoiceAmountDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.cDate2DataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.txDateDataGridViewTextBoxColumn});
            this.AdvancedTaxReport_Grid.DataSource = this.T_AdTaxBindSour;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdvancedTaxReport_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AdvancedTaxReport_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedTaxReport_Grid.EnableHeadersVisualStyles = false;
            this.AdvancedTaxReport_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.AdvancedTaxReport_Grid.Location = new System.Drawing.Point(3, 18);
            this.AdvancedTaxReport_Grid.MultiSelect = false;
            this.AdvancedTaxReport_Grid.Name = "AdvancedTaxReport_Grid";
            this.AdvancedTaxReport_Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdvancedTaxReport_Grid.RowHeadersVisible = false;
            this.AdvancedTaxReport_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.AdvancedTaxReport_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AdvancedTaxReport_Grid.RowTemplate.DividerHeight = 4;
            this.AdvancedTaxReport_Grid.RowTemplate.Height = 25;
            this.AdvancedTaxReport_Grid.RowTemplate.ReadOnly = true;
            this.AdvancedTaxReport_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdvancedTaxReport_Grid.ShowCellErrors = false;
            this.AdvancedTaxReport_Grid.ShowCellToolTips = false;
            this.AdvancedTaxReport_Grid.ShowEditingIcon = false;
            this.AdvancedTaxReport_Grid.ShowRowErrors = false;
            this.AdvancedTaxReport_Grid.Size = new System.Drawing.Size(1014, 432);
            this.AdvancedTaxReport_Grid.TabIndex = 0;
            // 
            // T_AdTaxBindSour
            // 
            this.T_AdTaxBindSour.DataMember = "T_AdvancedTax";
            this.T_AdTaxBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SystemInfo_Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 122);
            this.panel2.TabIndex = 0;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 0);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(146, 100);
            this.Details_Pan.TabIndex = 4;
            // 
            // T_AdTaxTabAd
            // 
            this.T_AdTaxTabAd.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // IDAuto_Col
            // 
            this.IDAuto_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDAuto_Col.DataPropertyName = "IDAuto";
            this.IDAuto_Col.HeaderText = "ID";
            this.IDAuto_Col.Name = "IDAuto_Col";
            this.IDAuto_Col.Width = 50;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // dealerNameDataGridViewTextBoxColumn
            // 
            this.dealerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dealerNameDataGridViewTextBoxColumn.DataPropertyName = "DealerName";
            this.dealerNameDataGridViewTextBoxColumn.HeaderText = "Dealer Name";
            this.dealerNameDataGridViewTextBoxColumn.Name = "dealerNameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 66;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.Width = 63;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.Width = 64;
            // 
            // taxIDDataGridViewTextBoxColumn
            // 
            this.taxIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.taxIDDataGridViewTextBoxColumn.DataPropertyName = "TaxID";
            this.taxIDDataGridViewTextBoxColumn.HeaderText = "TaxID";
            this.taxIDDataGridViewTextBoxColumn.Name = "taxIDDataGridViewTextBoxColumn";
            this.taxIDDataGridViewTextBoxColumn.Visible = false;
            this.taxIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 83;
            // 
            // invoiceAmountDataGridViewTextBoxColumn
            // 
            this.invoiceAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.invoiceAmountDataGridViewTextBoxColumn.DataPropertyName = "InvoiceAmount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.invoiceAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoiceAmountDataGridViewTextBoxColumn.HeaderText = "In. Amt";
            this.invoiceAmountDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.invoiceAmountDataGridViewTextBoxColumn.Name = "invoiceAmountDataGridViewTextBoxColumn";
            this.invoiceAmountDataGridViewTextBoxColumn.Width = 80;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.taxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            this.taxDataGridViewTextBoxColumn.Width = 57;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Inv. No";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.Width = 85;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Width = 86;
            // 
            // cDate2DataGridViewTextBoxColumn
            // 
            this.cDate2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDate2DataGridViewTextBoxColumn.DataPropertyName = "CDate2";
            this.cDate2DataGridViewTextBoxColumn.HeaderText = "CDate2";
            this.cDate2DataGridViewTextBoxColumn.Name = "cDate2DataGridViewTextBoxColumn";
            this.cDate2DataGridViewTextBoxColumn.Visible = false;
            this.cDate2DataGridViewTextBoxColumn.Width = 78;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 64;
            // 
            // txDateDataGridViewTextBoxColumn
            // 
            this.txDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txDateDataGridViewTextBoxColumn.DataPropertyName = "TxDate";
            this.txDateDataGridViewTextBoxColumn.HeaderText = "TxDate";
            this.txDateDataGridViewTextBoxColumn.Name = "txDateDataGridViewTextBoxColumn";
            this.txDateDataGridViewTextBoxColumn.Visible = false;
            this.txDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // AdvancedTaxReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Details_Pan);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvancedTaxReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.AdvancedTaxReport_Load);
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedTaxReport_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_AdTaxBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView AdvancedTaxReport_Grid;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Button Reload_Btn;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Type_Txt;
        protected internal System.Windows.Forms.Panel Details_Pan;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel2;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.BindingSource T_AdTaxBindSour;
        private ChequerDataSetTableAdapters.T_AdvancedTaxTableAdapter T_AdTaxTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAuto_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDateDataGridViewTextBoxColumn;
    }
}