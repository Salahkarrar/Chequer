namespace Chequer
{
    partial class Users
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
            this.So = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_Group = new System.Windows.Forms.GroupBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Auth_Txt = new System.Windows.Forms.ComboBox();
            this.UsersBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.RolesBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.UserID_Txt = new System.Windows.Forms.TextBox();
            this.Password_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.User_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UsersTabAd = new Chequer.ChequerDataSetTableAdapters.T_UsersTableAdapter();
            this.RolesTabAd = new Chequer.ChequerDataSetTableAdapters.T_RolesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.User_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesBindSour)).BeginInit();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // So
            // 
            this.So.Location = new System.Drawing.Point(410, 260);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(200, 80);
            this.So.TabIndex = 8;
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
            this.Close_Btn.TabIndex = 1;
            this.Close_Btn.UseVisualStyleBackColor = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.User_Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 140);
            this.panel2.TabIndex = 0;
            // 
            // User_Group
            // 
            this.User_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Group.BackColor = System.Drawing.Color.Transparent;
            this.User_Group.Controls.Add(this.Delete_Btn);
            this.User_Group.Controls.Add(this.Auth_Txt);
            this.User_Group.Controls.Add(this.Name_Txt);
            this.User_Group.Controls.Add(this.UserID_Txt);
            this.User_Group.Controls.Add(this.Password_Txt);
            this.User_Group.Controls.Add(this.label4);
            this.User_Group.Controls.Add(this.label5);
            this.User_Group.Controls.Add(this.label1);
            this.User_Group.Controls.Add(this.label3);
            this.User_Group.Controls.Add(this.New_Btn);
            this.User_Group.Controls.Add(this.Edit_Btn);
            this.User_Group.Controls.Add(this.Save_Btn);
            this.User_Group.Controls.Add(this.Cancel_Btn);
            this.User_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.User_Group.Location = new System.Drawing.Point(276, 7);
            this.User_Group.Name = "User_Group";
            this.User_Group.Size = new System.Drawing.Size(468, 126);
            this.User_Group.TabIndex = 0;
            this.User_Group.TabStop = false;
            this.User_Group.Text = "Users Information";
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
            this.Delete_Btn.Location = new System.Drawing.Point(392, 91);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Auth_Txt
            // 
            this.Auth_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Auth_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Auth_Txt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.UsersBindSour, "RoleID", true));
            this.Auth_Txt.DataSource = this.RolesBindSour;
            this.Auth_Txt.DisplayMember = "RoleName";
            this.Auth_Txt.FormattingEnabled = true;
            this.Auth_Txt.Location = new System.Drawing.Point(341, 55);
            this.Auth_Txt.Name = "Auth_Txt";
            this.Auth_Txt.Size = new System.Drawing.Size(121, 23);
            this.Auth_Txt.TabIndex = 4;
            this.Auth_Txt.ValueMember = "RoleID";
            this.Auth_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // UsersBindSour
            // 
            this.UsersBindSour.DataMember = "T_Users";
            this.UsersBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RolesBindSour
            // 
            this.RolesBindSour.DataMember = "T_Roles";
            this.RolesBindSour.DataSource = this.ChequerSet;
            // 
            // Name_Txt
            // 
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindSour, "UserName", true));
            this.Name_Txt.Location = new System.Drawing.Point(57, 28);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(199, 22);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // UserID_Txt
            // 
            this.UserID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindSour, "UserID", true));
            this.UserID_Txt.Location = new System.Drawing.Point(57, 55);
            this.UserID_Txt.MaxLength = 10;
            this.UserID_Txt.Name = "UserID_Txt";
            this.UserID_Txt.Size = new System.Drawing.Size(199, 22);
            this.UserID_Txt.TabIndex = 3;
            this.UserID_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.UserID_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Password_Txt
            // 
            this.Password_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UsersBindSour, "Pword", true));
            this.Password_Txt.Location = new System.Drawing.Point(341, 28);
            this.Password_Txt.Name = "Password_Txt";
            this.Password_Txt.PasswordChar = '*';
            this.Password_Txt.Size = new System.Drawing.Size(121, 22);
            this.Password_Txt.TabIndex = 2;
            this.Password_Txt.UseSystemPasswordChar = true;
            this.Password_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(276, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Authority:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
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
            this.New_Btn.Location = new System.Drawing.Point(57, 91);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(70, 25);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
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
            this.Edit_Btn.Location = new System.Drawing.Point(209, 91);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 6;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
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
            this.Save_Btn.Image = global::Chequer.Properties.Resources.Dark_Save_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(133, 91);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
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
            this.Cancel_Btn.Location = new System.Drawing.Point(285, 91);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_Btn.TabIndex = 7;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.User_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 165);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 435);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Users List";
            // 
            // User_Grid
            // 
            this.User_Grid.AllowUserToAddRows = false;
            this.User_Grid.AllowUserToDeleteRows = false;
            this.User_Grid.AllowUserToResizeRows = false;
            this.User_Grid.AutoGenerateColumns = false;
            this.User_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.User_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.User_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.pwordDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn});
            this.User_Grid.DataSource = this.UsersBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.User_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Grid.EnableHeadersVisualStyles = false;
            this.User_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.User_Grid.Location = new System.Drawing.Point(3, 18);
            this.User_Grid.MultiSelect = false;
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.ReadOnly = true;
            this.User_Grid.RowHeadersVisible = false;
            this.User_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.User_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.User_Grid.RowTemplate.DividerHeight = 4;
            this.User_Grid.RowTemplate.Height = 25;
            this.User_Grid.RowTemplate.ReadOnly = true;
            this.User_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_Grid.ShowCellErrors = false;
            this.User_Grid.ShowCellToolTips = false;
            this.User_Grid.ShowEditingIcon = false;
            this.User_Grid.ShowRowErrors = false;
            this.User_Grid.Size = new System.Drawing.Size(1014, 414);
            this.User_Grid.TabIndex = 0;
            this.User_Grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.User_Grid_CellFormatting);
            this.User_Grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.User_Grid_DataBindingComplete);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pwordDataGridViewTextBoxColumn
            // 
            this.pwordDataGridViewTextBoxColumn.DataPropertyName = "Pword";
            this.pwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.pwordDataGridViewTextBoxColumn.Name = "pwordDataGridViewTextBoxColumn";
            this.pwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.DataSource = this.RolesBindSour;
            this.roleIDDataGridViewTextBoxColumn.DisplayMember = "RoleName";
            this.roleIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleIDDataGridViewTextBoxColumn.ValueMember = "RoleID";
            // 
            // UsersTabAd
            // 
            this.UsersTabAd.ClearBeforeFill = true;
            // 
            // RolesTabAd
            // 
            this.RolesTabAd.ClearBeforeFill = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.So);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.User_Group.ResumeLayout(false);
            this.User_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesBindSour)).EndInit();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Panel So;
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox User_Group;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.ComboBox Auth_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.TextBox UserID_Txt;
        private System.Windows.Forms.TextBox Password_Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView User_Grid;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.BindingSource UsersBindSour;
        private ChequerDataSetTableAdapters.T_UsersTableAdapter UsersTabAd;
        private System.Windows.Forms.BindingSource RolesBindSour;
        private ChequerDataSetTableAdapters.T_RolesTableAdapter RolesTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleIDDataGridViewTextBoxColumn;
    }
}