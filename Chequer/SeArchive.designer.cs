namespace Chequer
{
    partial class SeArchive
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Search_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_ArchiveBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.SystemInfo_Group = new System.Windows.Forms.GroupBox();
            this.Carton_Txt = new System.Windows.Forms.ComboBox();
            this.Type_Txt = new System.Windows.Forms.ComboBox();
            this.Archive_Txt = new System.Windows.Forms.ComboBox();
            this.UserID_Txt = new System.Windows.Forms.ComboBox();
            this.T_UsersBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Deal_Txt = new System.Windows.Forms.TextBox();
            this.CIF_Txt = new System.Windows.Forms.TextBox();
            this.To_Txt = new System.Windows.Forms.DateTimePicker();
            this.From_Txt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Lab = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.T_UsersTabAd = new Chequer.ChequerDataSetTableAdapters.T_UsersTableAdapter();
            this.T_ArchiveTabAd = new Chequer.ChequerDataSetTableAdapters.T_ArchiveTableAdapter();
            this.panel1.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ArchiveBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            this.SystemInfo_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_UsersBindSour)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.Grid_Group.Controls.Add(this.Search_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Grid_Group.Location = new System.Drawing.Point(0, 288);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 312);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Archive List";
            // 
            // Search_Grid
            // 
            this.Search_Grid.AllowUserToAddRows = false;
            this.Search_Grid.AllowUserToDeleteRows = false;
            this.Search_Grid.AllowUserToResizeRows = false;
            this.Search_Grid.AutoGenerateColumns = false;
            this.Search_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Search_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Search_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Search_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Search_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.cartonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.archiveNameDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.txDateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.Search_Grid.DataSource = this.T_ArchiveBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Search_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Search_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_Grid.EnableHeadersVisualStyles = false;
            this.Search_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Search_Grid.Location = new System.Drawing.Point(3, 18);
            this.Search_Grid.MultiSelect = false;
            this.Search_Grid.Name = "Search_Grid";
            this.Search_Grid.ReadOnly = true;
            this.Search_Grid.RowHeadersVisible = false;
            this.Search_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Search_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Search_Grid.RowTemplate.DividerHeight = 4;
            this.Search_Grid.RowTemplate.Height = 25;
            this.Search_Grid.RowTemplate.ReadOnly = true;
            this.Search_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Search_Grid.ShowCellErrors = false;
            this.Search_Grid.ShowCellToolTips = false;
            this.Search_Grid.ShowEditingIcon = false;
            this.Search_Grid.ShowRowErrors = false;
            this.Search_Grid.Size = new System.Drawing.Size(1014, 291);
            this.Search_Grid.TabIndex = 0;
            this.Search_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Search_Grid_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIFDataGridViewTextBoxColumn
            // 
            this.cIFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIFDataGridViewTextBoxColumn.Width = 80;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.ReadOnly = true;
            this.dealDataGridViewTextBoxColumn.Width = 60;
            // 
            // cartonDataGridViewTextBoxColumn
            // 
            this.cartonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cartonDataGridViewTextBoxColumn.DataPropertyName = "Carton";
            this.cartonDataGridViewTextBoxColumn.HeaderText = "Carton";
            this.cartonDataGridViewTextBoxColumn.Name = "cartonDataGridViewTextBoxColumn";
            this.cartonDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartonDataGridViewTextBoxColumn.Width = 60;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 120;
            // 
            // archiveNameDataGridViewTextBoxColumn
            // 
            this.archiveNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.archiveNameDataGridViewTextBoxColumn.DataPropertyName = "ArchiveName";
            this.archiveNameDataGridViewTextBoxColumn.HeaderText = "Ar.Name";
            this.archiveNameDataGridViewTextBoxColumn.Name = "archiveNameDataGridViewTextBoxColumn";
            this.archiveNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.archiveNameDataGridViewTextBoxColumn.Width = 85;
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
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 80;
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
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // T_ArchiveBindSour
            // 
            this.T_ArchiveBindSour.DataMember = "T_Archive";
            this.T_ArchiveBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 0);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(200, 100);
            this.Details_Pan.TabIndex = 3;
            // 
            // SystemInfo_Group
            // 
            this.SystemInfo_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SystemInfo_Group.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfo_Group.Controls.Add(this.Carton_Txt);
            this.SystemInfo_Group.Controls.Add(this.Type_Txt);
            this.SystemInfo_Group.Controls.Add(this.Archive_Txt);
            this.SystemInfo_Group.Controls.Add(this.UserID_Txt);
            this.SystemInfo_Group.Controls.Add(this.Deal_Txt);
            this.SystemInfo_Group.Controls.Add(this.CIF_Txt);
            this.SystemInfo_Group.Controls.Add(this.To_Txt);
            this.SystemInfo_Group.Controls.Add(this.From_Txt);
            this.SystemInfo_Group.Controls.Add(this.label3);
            this.SystemInfo_Group.Controls.Add(this.label1);
            this.SystemInfo_Group.Controls.Add(this.label5);
            this.SystemInfo_Group.Controls.Add(this.label6);
            this.SystemInfo_Group.Controls.Add(this.label7);
            this.SystemInfo_Group.Controls.Add(this.label4);
            this.SystemInfo_Group.Controls.Add(this.label2);
            this.SystemInfo_Group.Controls.Add(this.Name_Lab);
            this.SystemInfo_Group.Controls.Add(this.Save_Btn);
            this.SystemInfo_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemInfo_Group.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SystemInfo_Group.Location = new System.Drawing.Point(339, 6);
            this.SystemInfo_Group.Name = "SystemInfo_Group";
            this.SystemInfo_Group.Size = new System.Drawing.Size(343, 251);
            this.SystemInfo_Group.TabIndex = 0;
            this.SystemInfo_Group.TabStop = false;
            this.SystemInfo_Group.Text = "Search";
            // 
            // Carton_Txt
            // 
            this.Carton_Txt.DisplayMember = "UserID";
            this.Carton_Txt.FormattingEnabled = true;
            this.Carton_Txt.Location = new System.Drawing.Point(69, 74);
            this.Carton_Txt.Name = "Carton_Txt";
            this.Carton_Txt.Size = new System.Drawing.Size(265, 23);
            this.Carton_Txt.TabIndex = 2;
            this.Carton_Txt.ValueMember = "UserID";
            // 
            // Type_Txt
            // 
            this.Type_Txt.DisplayMember = "UserID";
            this.Type_Txt.FormattingEnabled = true;
            this.Type_Txt.Items.AddRange(new object[] {
            "",
            "Corperate",
            "AUTO",
            "Durable",
            "Home",
            "Education",
            "Constraction",
            "Wedding"});
            this.Type_Txt.Location = new System.Drawing.Point(69, 103);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(265, 23);
            this.Type_Txt.TabIndex = 3;
            this.Type_Txt.ValueMember = "UserID";
            // 
            // Archive_Txt
            // 
            this.Archive_Txt.FormattingEnabled = true;
            this.Archive_Txt.Items.AddRange(new object[] {
            "",
            "HQ",
            "Gmhoria",
            "Murda",
            "Sug Shabi",
            "Bahri"});
            this.Archive_Txt.Location = new System.Drawing.Point(69, 132);
            this.Archive_Txt.Name = "Archive_Txt";
            this.Archive_Txt.Size = new System.Drawing.Size(265, 23);
            this.Archive_Txt.TabIndex = 4;
            // 
            // UserID_Txt
            // 
            this.UserID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.T_UsersBindSour, "UserID", true));
            this.UserID_Txt.DataSource = this.T_UsersBindSour;
            this.UserID_Txt.DisplayMember = "UserID";
            this.UserID_Txt.FormattingEnabled = true;
            this.UserID_Txt.Location = new System.Drawing.Point(69, 161);
            this.UserID_Txt.Name = "UserID_Txt";
            this.UserID_Txt.Size = new System.Drawing.Size(265, 23);
            this.UserID_Txt.TabIndex = 5;
            this.UserID_Txt.ValueMember = "UserID";
            // 
            // T_UsersBindSour
            // 
            this.T_UsersBindSour.DataMember = "T_Users";
            this.T_UsersBindSour.DataSource = this.ChequerSet;
            // 
            // Deal_Txt
            // 
            this.Deal_Txt.Location = new System.Drawing.Point(69, 46);
            this.Deal_Txt.Name = "Deal_Txt";
            this.Deal_Txt.Size = new System.Drawing.Size(265, 22);
            this.Deal_Txt.TabIndex = 1;
            this.Deal_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CIF_Txt
            // 
            this.CIF_Txt.Location = new System.Drawing.Point(69, 18);
            this.CIF_Txt.Name = "CIF_Txt";
            this.CIF_Txt.Size = new System.Drawing.Size(265, 22);
            this.CIF_Txt.TabIndex = 0;
            this.CIF_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // To_Txt
            // 
            this.To_Txt.Checked = false;
            this.To_Txt.CustomFormat = "dd/MM/yyyy";
            this.To_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_Txt.Location = new System.Drawing.Point(221, 189);
            this.To_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.To_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.To_Txt.Name = "To_Txt";
            this.To_Txt.ShowCheckBox = true;
            this.To_Txt.Size = new System.Drawing.Size(113, 22);
            this.To_Txt.TabIndex = 7;
            this.To_Txt.Value = new System.DateTime(2022, 1, 14, 0, 0, 0, 0);
            // 
            // From_Txt
            // 
            this.From_Txt.Checked = false;
            this.From_Txt.CustomFormat = "dd/MM/yyyy";
            this.From_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_Txt.Location = new System.Drawing.Point(69, 189);
            this.From_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.From_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.From_Txt.Name = "From_Txt";
            this.From_Txt.ShowCheckBox = true;
            this.From_Txt.Size = new System.Drawing.Size(113, 22);
            this.From_Txt.TabIndex = 6;
            this.From_Txt.Value = new System.DateTime(2022, 1, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Carton :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Archive :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "CIF :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "UserID :";
            // 
            // Name_Lab
            // 
            this.Name_Lab.AutoSize = true;
            this.Name_Lab.ForeColor = System.Drawing.Color.Black;
            this.Name_Lab.Location = new System.Drawing.Point(26, 50);
            this.Name_Lab.Name = "Name_Lab";
            this.Name_Lab.Size = new System.Drawing.Size(37, 15);
            this.Name_Lab.TabIndex = 13;
            this.Name_Lab.Text = "Deal :";
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
            this.Save_Btn.Location = new System.Drawing.Point(121, 216);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(100, 30);
            this.Save_Btn.TabIndex = 8;
            this.Save_Btn.Text = "Seach";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SystemInfo_Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 263);
            this.panel2.TabIndex = 0;
            // 
            // T_UsersTabAd
            // 
            this.T_UsersTabAd.ClearBeforeFill = true;
            // 
            // T_ArchiveTabAd
            // 
            this.T_ArchiveTabAd.ClearBeforeFill = true;
            // 
            // SeArchive
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
            this.Name = "SeArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Archive";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ArchiveBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            this.SystemInfo_Group.ResumeLayout(false);
            this.SystemInfo_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_UsersBindSour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Search_Grid;
        private System.Windows.Forms.Button Close_Btn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel Details_Pan;
        private System.Windows.Forms.GroupBox SystemInfo_Group;
        private System.Windows.Forms.DateTimePicker To_Txt;
        private System.Windows.Forms.DateTimePicker From_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_Lab;
        private System.Windows.Forms.Button Save_Btn;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CIF_Txt;
        private System.Windows.Forms.Label label4;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.ComboBox UserID_Txt;
        private System.Windows.Forms.TextBox Deal_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource T_UsersBindSour;
        private ChequerDataSetTableAdapters.T_UsersTableAdapter T_UsersTabAd;
        private System.Windows.Forms.BindingSource T_ArchiveBindSour;
        private ChequerDataSetTableAdapters.T_ArchiveTableAdapter T_ArchiveTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox Carton_Txt;
        private System.Windows.Forms.ComboBox Type_Txt;
        private System.Windows.Forms.ComboBox Archive_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}