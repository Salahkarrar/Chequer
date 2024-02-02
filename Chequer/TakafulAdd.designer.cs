namespace Chequer
{
    partial class TakafulAdd
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
            this.So = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Takaful_Group = new System.Windows.Forms.GroupBox();
            this.Date_Txt = new System.Windows.Forms.DateTimePicker();
            this.T_TakafulBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.ChequerSet = new Chequer.ChequerDataSet();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Type_Txt = new System.Windows.Forms.ComboBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.Deal_Txt = new System.Windows.Forms.TextBox();
            this.Takaful_Txt = new System.Windows.Forms.TextBox();
            this.Tenor_Txt = new System.Windows.Forms.TextBox();
            this.Balance_Txt = new System.Windows.Forms.TextBox();
            this.CIF_Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Takaful_Grid = new System.Windows.Forms.DataGridView();
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
            this.T_TakafulTabAd = new Chequer.ChequerDataSetTableAdapters.T_TakafulTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Takaful_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).BeginInit();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Takaful_Grid)).BeginInit();
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
            this.panel2.Controls.Add(this.Takaful_Group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 134);
            this.panel2.TabIndex = 0;
            // 
            // Takaful_Group
            // 
            this.Takaful_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Takaful_Group.BackColor = System.Drawing.Color.Transparent;
            this.Takaful_Group.Controls.Add(this.Date_Txt);
            this.Takaful_Group.Controls.Add(this.Delete_Btn);
            this.Takaful_Group.Controls.Add(this.Type_Txt);
            this.Takaful_Group.Controls.Add(this.Name_Txt);
            this.Takaful_Group.Controls.Add(this.Deal_Txt);
            this.Takaful_Group.Controls.Add(this.Takaful_Txt);
            this.Takaful_Group.Controls.Add(this.Tenor_Txt);
            this.Takaful_Group.Controls.Add(this.Balance_Txt);
            this.Takaful_Group.Controls.Add(this.CIF_Txt);
            this.Takaful_Group.Controls.Add(this.label8);
            this.Takaful_Group.Controls.Add(this.label6);
            this.Takaful_Group.Controls.Add(this.label5);
            this.Takaful_Group.Controls.Add(this.label7);
            this.Takaful_Group.Controls.Add(this.label2);
            this.Takaful_Group.Controls.Add(this.label9);
            this.Takaful_Group.Controls.Add(this.label1);
            this.Takaful_Group.Controls.Add(this.label3);
            this.Takaful_Group.Controls.Add(this.New_Btn);
            this.Takaful_Group.Controls.Add(this.Edit_Btn);
            this.Takaful_Group.Controls.Add(this.Save_Btn);
            this.Takaful_Group.Controls.Add(this.Cancel_Btn);
            this.Takaful_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Takaful_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Takaful_Group.Location = new System.Drawing.Point(165, 4);
            this.Takaful_Group.Name = "Takaful_Group";
            this.Takaful_Group.Size = new System.Drawing.Size(691, 127);
            this.Takaful_Group.TabIndex = 0;
            this.Takaful_Group.TabStop = false;
            this.Takaful_Group.Text = "Takaful Information";
            // 
            // Date_Txt
            // 
            this.Date_Txt.Checked = false;
            this.Date_Txt.CustomFormat = "dd/MM/yyyyy";
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "CDate", true));
            this.Date_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Txt.Location = new System.Drawing.Point(304, 56);
            this.Date_Txt.MaxDate = new System.DateTime(2299, 12, 31, 0, 0, 0, 0);
            this.Date_Txt.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.Size = new System.Drawing.Size(93, 22);
            this.Date_Txt.TabIndex = 7;
            this.Date_Txt.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // T_TakafulBindSour
            // 
            this.T_TakafulBindSour.DataMember = "T_Takaful";
            this.T_TakafulBindSour.DataSource = this.ChequerSet;
            // 
            // ChequerSet
            // 
            this.ChequerSet.DataSetName = "ChequerDataSet";
            this.ChequerSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Delete_Btn.Location = new System.Drawing.Point(478, 91);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 12;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Type_Txt
            // 
            this.Type_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "Type", true));
            this.Type_Txt.FormattingEnabled = true;
            this.Type_Txt.Items.AddRange(new object[] {
            "",
            "Education",
            "Wedding",
            "Constraction",
            "Home"});
            this.Type_Txt.Location = new System.Drawing.Point(448, 56);
            this.Type_Txt.Name = "Type_Txt";
            this.Type_Txt.Size = new System.Drawing.Size(121, 23);
            this.Type_Txt.TabIndex = 8;
            this.Type_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Name_Txt
            // 
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "CutName", true));
            this.Name_Txt.Location = new System.Drawing.Point(57, 28);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(199, 22);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Deal_Txt
            // 
            this.Deal_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "Deal", true));
            this.Deal_Txt.Location = new System.Drawing.Point(174, 56);
            this.Deal_Txt.Name = "Deal_Txt";
            this.Deal_Txt.Size = new System.Drawing.Size(82, 22);
            this.Deal_Txt.TabIndex = 6;
            this.Deal_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Deal_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Takaful_Txt
            // 
            this.Takaful_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "Takaful", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.Takaful_Txt.Location = new System.Drawing.Point(595, 28);
            this.Takaful_Txt.Name = "Takaful_Txt";
            this.Takaful_Txt.Size = new System.Drawing.Size(88, 22);
            this.Takaful_Txt.TabIndex = 4;
            this.Takaful_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Takaful_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Tenor_Txt
            // 
            this.Tenor_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "Tenor", true));
            this.Tenor_Txt.Location = new System.Drawing.Point(57, 56);
            this.Tenor_Txt.Name = "Tenor_Txt";
            this.Tenor_Txt.Size = new System.Drawing.Size(70, 22);
            this.Tenor_Txt.TabIndex = 5;
            this.Tenor_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Tenor_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Balance_Txt
            // 
            this.Balance_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "Balance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.Balance_Txt.Location = new System.Drawing.Point(443, 28);
            this.Balance_Txt.Name = "Balance_Txt";
            this.Balance_Txt.Size = new System.Drawing.Size(88, 22);
            this.Balance_Txt.TabIndex = 3;
            this.Balance_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.Balance_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // CIF_Txt
            // 
            this.CIF_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_TakafulBindSour, "CIF", true));
            this.CIF_Txt.Location = new System.Drawing.Point(304, 28);
            this.CIF_Txt.Name = "CIF_Txt";
            this.CIF_Txt.Size = new System.Drawing.Size(71, 22);
            this.CIF_Txt.TabIndex = 2;
            this.CIF_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            this.CIF_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(134, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Deal :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(537, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Takaful :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(401, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tenor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(382, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Balance :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(260, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "CIF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name :";
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
            this.New_Btn.Location = new System.Drawing.Point(143, 91);
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
            this.Edit_Btn.Location = new System.Drawing.Point(295, 91);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 10;
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
            this.Save_Btn.Location = new System.Drawing.Point(219, 91);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 9;
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
            this.Cancel_Btn.Location = new System.Drawing.Point(371, 91);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_Btn.TabIndex = 11;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Takaful_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 159);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Size = new System.Drawing.Size(1020, 441);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Takaful_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Takaful_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Takaful_Grid.EnableHeadersVisualStyles = false;
            this.Takaful_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Takaful_Grid.Location = new System.Drawing.Point(3, 18);
            this.Takaful_Grid.MultiSelect = false;
            this.Takaful_Grid.Name = "Takaful_Grid";
            this.Takaful_Grid.ReadOnly = true;
            this.Takaful_Grid.RowHeadersVisible = false;
            this.Takaful_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Takaful_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Takaful_Grid.RowTemplate.DividerHeight = 4;
            this.Takaful_Grid.RowTemplate.Height = 25;
            this.Takaful_Grid.RowTemplate.ReadOnly = true;
            this.Takaful_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Takaful_Grid.ShowCellErrors = false;
            this.Takaful_Grid.ShowCellToolTips = false;
            this.Takaful_Grid.ShowEditingIcon = false;
            this.Takaful_Grid.ShowRowErrors = false;
            this.Takaful_Grid.Size = new System.Drawing.Size(1014, 420);
            this.Takaful_Grid.TabIndex = 0;
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
            dataGridViewCellStyle4.NullValue = null;
            this.dealDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            // T_TakafulTabAd
            // 
            this.T_TakafulTabAd.ClearBeforeFill = true;
            // 
            // TakafulAdd
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
            this.Name = "TakafulAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dealers";
            this.Load += new System.EventHandler(this.TakafulAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Takaful_Group.ResumeLayout(false);
            this.Takaful_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_TakafulBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChequerSet)).EndInit();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Takaful_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Panel So;
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Takaful_Group;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.ComboBox Type_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.TextBox CIF_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Takaful_Grid;
        private ChequerDataSet ChequerSet;
        private System.Windows.Forms.BindingSource T_TakafulBindSour;
        private ChequerDataSetTableAdapters.T_TakafulTableAdapter T_TakafulTabAd;
        private System.Windows.Forms.TextBox Balance_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Deal_Txt;
        private System.Windows.Forms.TextBox Takaful_Txt;
        private System.Windows.Forms.TextBox Tenor_Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Date_Txt;
        private System.Windows.Forms.Label label9;
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