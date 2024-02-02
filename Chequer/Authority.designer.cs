namespace Chequer
{
    partial class Authority
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MAuthority_Txt = new System.Windows.Forms.ComboBox();
            this.T_RolesBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.CoSet = new Chequer.ChequerDataSet();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.FunRole_Grid = new System.Windows.Forms.DataGridView();
            this.functionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T_FunBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_FunRoleBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Fun_Grid = new System.Windows.Forms.DataGridView();
            this.functionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_RolesTabAd = new Chequer.ChequerDataSetTableAdapters.T_RolesTableAdapter();
            this.T_FunTabAd = new Chequer.ChequerDataSetTableAdapters.T_FunctionTableAdapter();
            this.T_FunRoleTabAd = new Chequer.ChequerDataSetTableAdapters.T_FunctionRoleTableAdapter();
            this.FunBindSour2 = new System.Windows.Forms.BindingSource(this.components);
            this.FunTabAd2 = new Chequer.ChequerDataSetTableAdapters.T_FunctionTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 25);
            this.panel1.TabIndex = 9;
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
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MAuthority_Txt);
            this.panel2.Location = new System.Drawing.Point(568, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 33);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Authority:";
            // 
            // MAuthority_Txt
            // 
            this.MAuthority_Txt.BackColor = System.Drawing.Color.White;
            this.MAuthority_Txt.DataSource = this.T_RolesBindSour;
            this.MAuthority_Txt.DisplayMember = "RoleName";
            this.MAuthority_Txt.ForeColor = System.Drawing.Color.Black;
            this.MAuthority_Txt.FormattingEnabled = true;
            this.MAuthority_Txt.Location = new System.Drawing.Point(75, 5);
            this.MAuthority_Txt.Name = "MAuthority_Txt";
            this.MAuthority_Txt.Size = new System.Drawing.Size(165, 23);
            this.MAuthority_Txt.TabIndex = 0;
            this.MAuthority_Txt.ValueMember = "RoleID";
            this.MAuthority_Txt.SelectedIndexChanged += new System.EventHandler(this.MAuthority_Txt_SelectedIndexChanged);
            // 
            // T_RolesBindSour
            // 
            this.T_RolesBindSour.DataMember = "T_Roles";
            this.T_RolesBindSour.DataSource = this.CoSet;
            // 
            // CoSet
            // 
            this.CoSet.DataSetName = "ChequerDataSet";
            this.CoSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add_Btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Btn.Image = global::Chequer.Properties.Resources.Dark_Arrow_Right_36;
            this.Add_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_Btn.Location = new System.Drawing.Point(525, 269);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(37, 62);
            this.Add_Btn.TabIndex = 12;
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Remove_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Remove_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Remove_Btn.ForeColor = System.Drawing.Color.Black;
            this.Remove_Btn.Image = global::Chequer.Properties.Resources.Dark_Arrow_Left_36;
            this.Remove_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Remove_Btn.Location = new System.Drawing.Point(458, 269);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(37, 62);
            this.Remove_Btn.TabIndex = 14;
            this.Remove_Btn.UseVisualStyleBackColor = false;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // FunRole_Grid
            // 
            this.FunRole_Grid.AllowUserToAddRows = false;
            this.FunRole_Grid.AllowUserToDeleteRows = false;
            this.FunRole_Grid.AllowUserToResizeColumns = false;
            this.FunRole_Grid.AllowUserToResizeRows = false;
            this.FunRole_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunRole_Grid.AutoGenerateColumns = false;
            this.FunRole_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FunRole_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.FunRole_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FunRole_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FunRole_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FunRole_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionIDDataGridViewTextBoxColumn1});
            this.FunRole_Grid.DataSource = this.T_FunRoleBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FunRole_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FunRole_Grid.EnableHeadersVisualStyles = false;
            this.FunRole_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.FunRole_Grid.Location = new System.Drawing.Point(568, 85);
            this.FunRole_Grid.Name = "FunRole_Grid";
            this.FunRole_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.FunRole_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FunRole_Grid.RowTemplate.DividerHeight = 4;
            this.FunRole_Grid.RowTemplate.Height = 25;
            this.FunRole_Grid.RowTemplate.ReadOnly = true;
            this.FunRole_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FunRole_Grid.ShowCellErrors = false;
            this.FunRole_Grid.ShowCellToolTips = false;
            this.FunRole_Grid.ShowEditingIcon = false;
            this.FunRole_Grid.ShowRowErrors = false;
            this.FunRole_Grid.Size = new System.Drawing.Size(243, 505);
            this.FunRole_Grid.TabIndex = 13;
            this.FunRole_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FunRole_Grid_CellDoubleClick);
            // 
            // functionIDDataGridViewTextBoxColumn1
            // 
            this.functionIDDataGridViewTextBoxColumn1.DataPropertyName = "FunctionID";
            this.functionIDDataGridViewTextBoxColumn1.DataSource = this.T_FunBindSour;
            this.functionIDDataGridViewTextBoxColumn1.DisplayMember = "FunctionName";
            this.functionIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.functionIDDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.functionIDDataGridViewTextBoxColumn1.HeaderText = "Add Function";
            this.functionIDDataGridViewTextBoxColumn1.Name = "functionIDDataGridViewTextBoxColumn1";
            this.functionIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.functionIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.functionIDDataGridViewTextBoxColumn1.ValueMember = "FunctionID";
            // 
            // T_FunBindSour
            // 
            this.T_FunBindSour.DataMember = "T_Function";
            this.T_FunBindSour.DataSource = this.CoSet;
            // 
            // T_FunRoleBindSour
            // 
            this.T_FunRoleBindSour.DataMember = "T_FunctionRole";
            this.T_FunRoleBindSour.DataSource = this.CoSet;
            // 
            // Fun_Grid
            // 
            this.Fun_Grid.AllowUserToAddRows = false;
            this.Fun_Grid.AllowUserToDeleteRows = false;
            this.Fun_Grid.AllowUserToResizeColumns = false;
            this.Fun_Grid.AllowUserToResizeRows = false;
            this.Fun_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fun_Grid.AutoGenerateColumns = false;
            this.Fun_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Fun_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Fun_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Fun_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Fun_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fun_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionNameDataGridViewTextBoxColumn});
            this.Fun_Grid.DataSource = this.T_FunBindSour;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Fun_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fun_Grid.EnableHeadersVisualStyles = false;
            this.Fun_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Fun_Grid.Location = new System.Drawing.Point(209, 82);
            this.Fun_Grid.Name = "Fun_Grid";
            this.Fun_Grid.ReadOnly = true;
            this.Fun_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Fun_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Fun_Grid.RowTemplate.DividerHeight = 4;
            this.Fun_Grid.RowTemplate.Height = 25;
            this.Fun_Grid.RowTemplate.ReadOnly = true;
            this.Fun_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fun_Grid.ShowCellErrors = false;
            this.Fun_Grid.ShowCellToolTips = false;
            this.Fun_Grid.ShowEditingIcon = false;
            this.Fun_Grid.ShowRowErrors = false;
            this.Fun_Grid.Size = new System.Drawing.Size(243, 505);
            this.Fun_Grid.TabIndex = 11;
            this.Fun_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Fun_Grid_CellDoubleClick);
            // 
            // functionNameDataGridViewTextBoxColumn
            // 
            this.functionNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.HeaderText = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.Name = "functionNameDataGridViewTextBoxColumn";
            this.functionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // T_RolesTabAd
            // 
            this.T_RolesTabAd.ClearBeforeFill = true;
            // 
            // T_FunTabAd
            // 
            this.T_FunTabAd.ClearBeforeFill = true;
            // 
            // T_FunRoleTabAd
            // 
            this.T_FunRoleTabAd.ClearBeforeFill = true;
            // 
            // FunBindSour2
            // 
            this.FunBindSour2.DataMember = "T_Function";
            this.FunBindSour2.DataSource = this.CoSet;
            // 
            // FunTabAd2
            // 
            this.FunTabAd2.ClearBeforeFill = true;
            // 
            // Authority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.FunRole_Grid);
            this.Controls.Add(this.Fun_Grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authority";
            this.Load += new System.EventHandler(this.Authority_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MAuthority_Txt;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.DataGridView FunRole_Grid;
        private System.Windows.Forms.DataGridView Fun_Grid;
        private ChequerDataSet CoSet;
        private System.Windows.Forms.BindingSource T_RolesBindSour;
        private ChequerDataSetTableAdapters.T_RolesTableAdapter T_RolesTabAd;
        private System.Windows.Forms.BindingSource T_FunBindSour;
        private ChequerDataSetTableAdapters.T_FunctionTableAdapter T_FunTabAd;
        private System.Windows.Forms.BindingSource T_FunRoleBindSour;
        private ChequerDataSetTableAdapters.T_FunctionRoleTableAdapter T_FunRoleTabAd;
        private System.Windows.Forms.BindingSource FunBindSour2;
        private ChequerDataSetTableAdapters.T_FunctionTableAdapter FunTabAd2;
        private System.Windows.Forms.DataGridViewComboBoxColumn functionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionNameDataGridViewTextBoxColumn;
    }
}