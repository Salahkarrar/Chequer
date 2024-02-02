namespace Chequer
{
    partial class Archive
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
            this.Type_Txt = new System.Windows.Forms.ComboBox();
            this.T_ArchiveBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerData = new Chequer.ChequerDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SDeal_Txt = new System.Windows.Forms.TextBox();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Cheque_Group = new System.Windows.Forms.GroupBox();
            this.Note_Txt = new System.Windows.Forms.TextBox();
            this.Archive_Txt = new System.Windows.Forms.ComboBox();
            this.Status_Txt = new System.Windows.Forms.ComboBox();
            this.Date_Lab = new System.Windows.Forms.Label();
            this.Date_Txt = new System.Windows.Forms.DateTimePicker();
            this.ContactNumber_Lab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Lab = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Deal_Txt = new System.Windows.Forms.TextBox();
            this.CIF_Txt = new System.Windows.Forms.TextBox();
            this.Carton_Txt = new System.Windows.Forms.TextBox();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.ID_Lab = new System.Windows.Forms.Label();
            this.Name_Txt = new System.Windows.Forms.ComboBox();
            this.ID_Txt = new System.Windows.Forms.TextBox();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Cheque_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details_Pan = new System.Windows.Forms.Panel();
            this.T_ArchiveTabAd = new Chequer.ChequerDataSetTableAdapters.T_ArchiveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T_ArchiveBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Cheque_Group.SuspendLayout();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cheque_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Type_Txt
            // 
            this.Type_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "Type", true));
            this.Type_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Type_Txt.ForeColor = System.Drawing.Color.Black;
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
            this.Type_Txt.Location = new System.Drawing.Point(350, 52);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(85, 23);
            this.Type_Txt.TabIndex = 6;
            this.Type_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // T_ArchiveBindSour
            // 
            this.T_ArchiveBindSour.DataMember = "T_Archive";
            this.T_ArchiveBindSour.DataSource = this.ChequerData;
            // 
            // ChequerData
            // 
            this.ChequerData.DataSetName = "ChequerDataSet";
            this.ChequerData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Cheque_Group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 178);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.SDeal_Txt);
            this.panel2.Controls.Add(this.Search_Btn);
            this.panel2.Location = new System.Drawing.Point(807, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 99);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Deal :";
            // 
            // SDeal_Txt
            // 
            this.SDeal_Txt.Location = new System.Drawing.Point(9, 34);
            this.SDeal_Txt.MaxLength = 15;
            this.SDeal_Txt.Name = "SDeal_Txt";
            this.SDeal_Txt.Size = new System.Drawing.Size(94, 21);
            this.SDeal_Txt.TabIndex = 12;
            this.SDeal_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search_Btn
            // 
            this.Search_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.ForeColor = System.Drawing.Color.Black;
            this.Search_Btn.Image = global::Chequer.Properties.Resources.Dark_Search_18;
            this.Search_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_Btn.Location = new System.Drawing.Point(21, 61);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(70, 25);
            this.Search_Btn.TabIndex = 11;
            this.Search_Btn.Text = "Search";
            this.Search_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // Cheque_Group
            // 
            this.Cheque_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cheque_Group.BackColor = System.Drawing.Color.Transparent;
            this.Cheque_Group.Controls.Add(this.Note_Txt);
            this.Cheque_Group.Controls.Add(this.Archive_Txt);
            this.Cheque_Group.Controls.Add(this.Status_Txt);
            this.Cheque_Group.Controls.Add(this.Type_Txt);
            this.Cheque_Group.Controls.Add(this.Date_Lab);
            this.Cheque_Group.Controls.Add(this.Date_Txt);
            this.Cheque_Group.Controls.Add(this.ContactNumber_Lab);
            this.Cheque_Group.Controls.Add(this.label5);
            this.Cheque_Group.Controls.Add(this.label4);
            this.Cheque_Group.Controls.Add(this.label1);
            this.Cheque_Group.Controls.Add(this.Delete_Btn);
            this.Cheque_Group.Controls.Add(this.label6);
            this.Cheque_Group.Controls.Add(this.label3);
            this.Cheque_Group.Controls.Add(this.Name_Lab);
            this.Cheque_Group.Controls.Add(this.New_Btn);
            this.Cheque_Group.Controls.Add(this.label2);
            this.Cheque_Group.Controls.Add(this.Deal_Txt);
            this.Cheque_Group.Controls.Add(this.CIF_Txt);
            this.Cheque_Group.Controls.Add(this.Carton_Txt);
            this.Cheque_Group.Controls.Add(this.Edit_Btn);
            this.Cheque_Group.Controls.Add(this.Cancel_Btn);
            this.Cheque_Group.Controls.Add(this.Save_Btn);
            this.Cheque_Group.Controls.Add(this.ID_Lab);
            this.Cheque_Group.Controls.Add(this.Name_Txt);
            this.Cheque_Group.Controls.Add(this.ID_Txt);
            this.Cheque_Group.Controls.Add(this.Print_Btn);
            this.Cheque_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheque_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cheque_Group.Location = new System.Drawing.Point(220, 15);
            this.Cheque_Group.Name = "Cheque_Group";
            this.Cheque_Group.Size = new System.Drawing.Size(581, 149);
            this.Cheque_Group.TabIndex = 0;
            this.Cheque_Group.TabStop = false;
            this.Cheque_Group.Text = "Information ";
            // 
            // Note_Txt
            // 
            this.Note_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "Notes", true));
            this.Note_Txt.Location = new System.Drawing.Point(64, 81);
            this.Note_Txt.MaxLength = 15;
            this.Note_Txt.Name = "Note_Txt";
            this.Note_Txt.Size = new System.Drawing.Size(371, 21);
            this.Note_Txt.TabIndex = 8;
            this.Note_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Archive_Txt
            // 
            this.Archive_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "ArchiveName", true));
            this.Archive_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Archive_Txt.ForeColor = System.Drawing.Color.Black;
            this.Archive_Txt.FormattingEnabled = true;
            this.Archive_Txt.Items.AddRange(new object[] {
            "",
            "HQ",
            "Gmhoria",
            "Murda",
            "Sug Shabi",
            "Bahri"});
            this.Archive_Txt.Location = new System.Drawing.Point(64, 50);
            this.Archive_Txt.Name = "Archive_Txt";
            this.Archive_Txt.Size = new System.Drawing.Size(100, 23);
            this.Archive_Txt.TabIndex = 4;
            this.Archive_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Status_Txt
            // 
            this.Status_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "Status", true));
            this.Status_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Status_Txt.ForeColor = System.Drawing.Color.Black;
            this.Status_Txt.FormattingEnabled = true;
            this.Status_Txt.Items.AddRange(new object[] {
            "",
            "In Archive",
            "Out Archive"});
            this.Status_Txt.Location = new System.Drawing.Point(487, 79);
            this.Status_Txt.Name = "Status_Txt";
            this.Status_Txt.Size = new System.Drawing.Size(85, 23);
            this.Status_Txt.TabIndex = 9;
            this.Status_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Date_Lab
            // 
            this.Date_Lab.AutoSize = true;
            this.Date_Lab.ForeColor = System.Drawing.Color.Black;
            this.Date_Lab.Location = new System.Drawing.Point(445, 56);
            this.Date_Lab.Name = "Date_Lab";
            this.Date_Lab.Size = new System.Drawing.Size(36, 15);
            this.Date_Lab.TabIndex = 21;
            this.Date_Lab.Text = "Date :";
            // 
            // Date_Txt
            // 
            this.Date_Txt.Checked = false;
            this.Date_Txt.CustomFormat = "dd/MM/yyyyy";
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "C_Date", true));
            this.Date_Txt.Enabled = false;
            this.Date_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Txt.Location = new System.Drawing.Point(487, 50);
            this.Date_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.Date_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.Size = new System.Drawing.Size(85, 22);
            this.Date_Txt.TabIndex = 7;
            this.Date_Txt.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // ContactNumber_Lab
            // 
            this.ContactNumber_Lab.AutoSize = true;
            this.ContactNumber_Lab.ForeColor = System.Drawing.Color.Black;
            this.ContactNumber_Lab.Location = new System.Drawing.Point(312, 25);
            this.ContactNumber_Lab.Name = "ContactNumber_Lab";
            this.ContactNumber_Lab.Size = new System.Drawing.Size(32, 15);
            this.ContactNumber_Lab.TabIndex = 22;
            this.ContactNumber_Lab.Text = "CIF :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(438, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Note :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Archive :";
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
            this.Delete_Btn.Location = new System.Drawing.Point(389, 114);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 14;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Visible = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(305, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(170, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Carton :";
            // 
            // Name_Lab
            // 
            this.Name_Lab.AutoSize = true;
            this.Name_Lab.ForeColor = System.Drawing.Color.Black;
            this.Name_Lab.Location = new System.Drawing.Point(15, 25);
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
            this.New_Btn.Location = new System.Drawing.Point(85, 114);
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
            this.label2.Location = new System.Drawing.Point(446, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deal :";
            // 
            // Deal_Txt
            // 
            this.Deal_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "Deal", true));
            this.Deal_Txt.Location = new System.Drawing.Point(487, 22);
            this.Deal_Txt.MaxLength = 15;
            this.Deal_Txt.Name = "Deal_Txt";
            this.Deal_Txt.Size = new System.Drawing.Size(85, 21);
            this.Deal_Txt.TabIndex = 3;
            this.Deal_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Deal_Txt.DoubleClick += new System.EventHandler(this.Deal_Txt_DoubleClick);
            this.Deal_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Deal_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // CIF_Txt
            // 
            this.CIF_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "CIF", true));
            this.CIF_Txt.Location = new System.Drawing.Point(350, 22);
            this.CIF_Txt.MaxLength = 15;
            this.CIF_Txt.Name = "CIF_Txt";
            this.CIF_Txt.Size = new System.Drawing.Size(85, 21);
            this.CIF_Txt.TabIndex = 2;
            this.CIF_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CIF_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.CIF_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Carton_Txt
            // 
            this.Carton_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "Carton", true));
            this.Carton_Txt.Location = new System.Drawing.Point(224, 53);
            this.Carton_Txt.MaxLength = 100;
            this.Carton_Txt.Name = "Carton_Txt";
            this.Carton_Txt.Size = new System.Drawing.Size(77, 21);
            this.Carton_Txt.TabIndex = 5;
            this.Carton_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Carton_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Carton_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
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
            this.Edit_Btn.Location = new System.Drawing.Point(237, 114);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 13;
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
            this.Cancel_Btn.Location = new System.Drawing.Point(313, 114);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_Btn.TabIndex = 11;
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
            this.Save_Btn.Location = new System.Drawing.Point(161, 114);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 10;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
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
            this.ID_Lab.Visible = false;
            // 
            // Name_Txt
            // 
            this.Name_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Name_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "CustName", true));
            this.Name_Txt.DisplayMember = "PtName";
            this.Name_Txt.Enabled = false;
            this.Name_Txt.FormattingEnabled = true;
            this.Name_Txt.Location = new System.Drawing.Point(64, 21);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(237, 23);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.ValueMember = "PtName";
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // ID_Txt
            // 
            this.ID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ArchiveBindSour, "ID", true));
            this.ID_Txt.Location = new System.Drawing.Point(64, 22);
            this.ID_Txt.MaxLength = 15;
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.ReadOnly = true;
            this.ID_Txt.Size = new System.Drawing.Size(113, 21);
            this.ID_Txt.TabIndex = 0;
            this.ID_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Print_Btn.Location = new System.Drawing.Point(465, 114);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(70, 25);
            this.Print_Btn.TabIndex = 12;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Print_Btn.UseVisualStyleBackColor = true;
            this.Print_Btn.Visible = false;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Cheque_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 203);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 420);
            this.Grid_Group.TabIndex = 9;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Archive List";
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
            this.iDDataGridViewTextBoxColumn,
            this.dealDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.archiveNameDataGridViewTextBoxColumn,
            this.cartonDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.Notes,
            this.Status,
            this.txDateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.Cheque_Grid.DataSource = this.T_ArchiveBindSour;
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
            this.Cheque_Grid.Size = new System.Drawing.Size(1014, 399);
            this.Cheque_Grid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dealDataGridViewTextBoxColumn
            // 
            this.dealDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dealDataGridViewTextBoxColumn.DataPropertyName = "Deal";
            this.dealDataGridViewTextBoxColumn.HeaderText = "Deal";
            this.dealDataGridViewTextBoxColumn.Name = "dealDataGridViewTextBoxColumn";
            this.dealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Name";
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
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // archiveNameDataGridViewTextBoxColumn
            // 
            this.archiveNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.archiveNameDataGridViewTextBoxColumn.DataPropertyName = "ArchiveName";
            this.archiveNameDataGridViewTextBoxColumn.HeaderText = "Archive Name";
            this.archiveNameDataGridViewTextBoxColumn.Name = "archiveNameDataGridViewTextBoxColumn";
            this.archiveNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.archiveNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // cartonDataGridViewTextBoxColumn
            // 
            this.cartonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cartonDataGridViewTextBoxColumn.DataPropertyName = "Carton";
            this.cartonDataGridViewTextBoxColumn.HeaderText = "Carton";
            this.cartonDataGridViewTextBoxColumn.Name = "cartonDataGridViewTextBoxColumn";
            this.cartonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "C_Date";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "C_Date";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 145;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // txDateDataGridViewTextBoxColumn
            // 
            this.txDateDataGridViewTextBoxColumn.DataPropertyName = "TxDate";
            this.txDateDataGridViewTextBoxColumn.HeaderText = "TxDate";
            this.txDateDataGridViewTextBoxColumn.Name = "txDateDataGridViewTextBoxColumn";
            this.txDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.txDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Details_Pan
            // 
            this.Details_Pan.Location = new System.Drawing.Point(0, 3);
            this.Details_Pan.Name = "Details_Pan";
            this.Details_Pan.Size = new System.Drawing.Size(146, 100);
            this.Details_Pan.TabIndex = 3;
            // 
            // T_ArchiveTabAd
            // 
            this.T_ArchiveTabAd.ClearBeforeFill = true;
            // 
            // Archive
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
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheque";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_ArchiveBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Cheque_Group.ResumeLayout(false);
            this.Cheque_Group.PerformLayout();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cheque_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_Txt;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox Cheque_Group;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.ComboBox Name_Txt;
        private System.Windows.Forms.Label Date_Lab;
        private System.Windows.Forms.DateTimePicker Date_Txt;
        private System.Windows.Forms.Label ContactNumber_Lab;
        protected internal System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label ID_Lab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name_Lab;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Deal_Txt;
        private System.Windows.Forms.TextBox CIF_Txt;
        private System.Windows.Forms.TextBox Carton_Txt;
        private System.Windows.Forms.TextBox ID_Txt;
        protected internal System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Cheque_Grid;
        protected internal System.Windows.Forms.Panel Details_Pan;
        private ChequerDataSet ChequerData;
        private System.Windows.Forms.BindingSource T_ArchiveBindSour;
        private ChequerDataSetTableAdapters.T_ArchiveTableAdapter T_ArchiveTabAd;
        private System.Windows.Forms.ComboBox Archive_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Note_Txt;
        private System.Windows.Forms.ComboBox Status_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiveNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SDeal_Txt;
        private System.Windows.Forms.Button Search_Btn;
    }
}

