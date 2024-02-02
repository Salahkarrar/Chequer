namespace Chequer
{
    partial class TakafulReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SystemInfo_Group = new System.Windows.Forms.GroupBox();
            this.To_Txt = new System.Windows.Forms.DateTimePicker();
            this.From_Txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reload_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Takaful_Grid = new System.Windows.Forms.DataGridView();
            this.T_TakafulBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.T_TakafulTabAd = new Chequer.ChequerDataSetTableAdapters.T_TakafulTableAdapter();
            this.Type_Txt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takafulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemInfo_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Takaful_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemInfo_Group
            // 
            this.SystemInfo_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SystemInfo_Group.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfo_Group.Controls.Add(this.Type_Txt);
            this.SystemInfo_Group.Controls.Add(this.label5);
            this.SystemInfo_Group.Controls.Add(this.To_Txt);
            this.SystemInfo_Group.Controls.Add(this.From_Txt);
            this.SystemInfo_Group.Controls.Add(this.label3);
            this.SystemInfo_Group.Controls.Add(this.label1);
            this.SystemInfo_Group.Controls.Add(this.Reload_Btn);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.SystemInfo_Group.Location = new System.Drawing.Point(345, 5);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(330, 117);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "Search";
            // 
            // To_Txt
            // 
            this.To_Txt.Checked = false;
            this.To_Txt.CustomFormat = "dd/MM/yyyy";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(206, 47);
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
            this.From_Txt.Location = new System.Drawing.Point(54, 47);
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
            this.label3.Location = new System.Drawing.Point(173, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "From :";
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
            this.Reload_Btn.Location = new System.Drawing.Point(206, 75);
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
            this.Save_Btn.Location = new System.Drawing.Point(54, 75);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(113, 30);
            this.Save_Btn.TabIndex = 4;
            this.Save_Btn.Text = "Seach";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Grid_Group.Controls.Add(this.Takaful_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 151);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 449);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Takaful List";
            // 
            // Takaful_Grid
            // 
            this.Takaful_Grid.AllowUserToAddRows = false;
            this.Takaful_Grid.AllowUserToDeleteRows = false;
            this.Takaful_Grid.AllowUserToResizeRows = false;
            this.Takaful_Grid.AutoGenerateColumns = false;
            this.Takaful_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Takaful_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Takaful_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Takaful_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Takaful_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Takaful_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cutNameDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.takafulDataGridViewTextBoxColumn,
            this.tenorDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.Type_Col,
            this.cDateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.Takaful_Grid.DataSource = this.T_TakafulBindSour;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Takaful_Grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.Takaful_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Takaful_Grid.EnableHeadersVisualStyles = false;
            this.Takaful_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Takaful_Grid.Location = new System.Drawing.Point(3, 18);
            this.Takaful_Grid.MultiSelect = false;
            this.Takaful_Grid.Name = "Takaful_Grid";
            this.Takaful_Grid.ReadOnly = true;
            this.Takaful_Grid.RowHeadersVisible = false;
            this.Takaful_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Takaful_Grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Takaful_Grid.RowTemplate.DividerHeight = 4;
            this.Takaful_Grid.RowTemplate.Height = 25;
            this.Takaful_Grid.RowTemplate.ReadOnly = true;
            this.Takaful_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Takaful_Grid.ShowCellErrors = false;
            this.Takaful_Grid.ShowCellToolTips = false;
            this.Takaful_Grid.ShowEditingIcon = false;
            this.Takaful_Grid.ShowRowErrors = false;
            this.Takaful_Grid.Size = new System.Drawing.Size(1014, 428);
            this.Takaful_Grid.TabIndex = 0;
            // 
            // T_TakafulBindSour
            // 
            this.T_TakafulBindSour.DataMember = "T_Takaful";
            this.T_TakafulBindSour.DataSource = this.ChequerSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SystemInfo_Group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 126);
            this.panel3.TabIndex = 0;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 0);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(146, 100);
            this.Details_Pan.TabIndex = 4;
            // 
            // T_TakafulTabAd
            // 
            this.T_TakafulTabAd.ClearBeforeFill = true;
            // 
            // Type_Txt
            // 
            this.Type_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_Txt.FormattingEnabled = true;
            this.Type_Txt.Items.AddRange(new object[] {
            "",
            "Durable Finance",
            "Education",
            "Wedding",
            "Constraction",
            "Home"});
            this.Type_Txt.Location = new System.Drawing.Point(54, 18);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(265, 23);
            this.Type_Txt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Type :";
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
            this.cutNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
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
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.balanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 81;
            // 
            // takafulDataGridViewTextBoxColumn
            // 
            this.takafulDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.takafulDataGridViewTextBoxColumn.DataPropertyName = "Takaful";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.takafulDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.takafulDataGridViewTextBoxColumn.HeaderText = "Takaful";
            this.takafulDataGridViewTextBoxColumn.Name = "takafulDataGridViewTextBoxColumn";
            this.takafulDataGridViewTextBoxColumn.ReadOnly = true;
            this.takafulDataGridViewTextBoxColumn.Width = 78;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            this.tenorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            this.tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            this.tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            this.tenorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenorDataGridViewTextBoxColumn.Width = 70;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealDataGridViewTextBoxColumn.Width = 63;
            // 
            // Type_Col
            // 
            this.Type_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Type_Col.DataPropertyName = "Type";
            this.Type_Col.HeaderText = "Type";
            this.Type_Col.Name = "Type_Col";
            this.Type_Col.ReadOnly = true;
            this.Type_Col.Width = 66;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "CDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Width = 64;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 64;
            // 
            // TakafulReport
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
            this.Name = "TakafulReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.TakafulReport_Load);
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Takaful_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Takaful_Grid;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Button Reload_Btn;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ChequerDataSet ChequerSet;
        protected internal System.Windows.Forms.Panel Details_Pan;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource T_TakafulBindSour;
        private ChequerDataSetTableAdapters.T_TakafulTableAdapter T_TakafulTabAd;
        private System.Windows.Forms.ComboBox Type_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takafulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}