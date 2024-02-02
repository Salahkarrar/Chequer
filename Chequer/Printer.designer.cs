namespace Chequer
{
    partial class Printer
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
            this.So = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_Group = new System.Windows.Forms.GroupBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Default_Txt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_PrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoSet = new Chequer.ChequerDataSet();
            this.t_PrinterTableAdapter = new Chequer.ChequerDataSetTableAdapters.T_PrinterTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.User_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_PrinterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).BeginInit();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 575);
            this.panel2.TabIndex = 0;
            // 
            // User_Group
            // 
            this.User_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Group.BackColor = System.Drawing.Color.Transparent;
            this.User_Group.Controls.Add(this.Delete_Btn);
            this.User_Group.Controls.Add(this.Save_Btn);
            this.User_Group.Controls.Add(this.Default_Txt);
            this.User_Group.Controls.Add(this.label3);
            this.User_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.User_Group.Location = new System.Drawing.Point(356, 221);
            this.User_Group.Name = "User_Group";
            this.User_Group.Size = new System.Drawing.Size(308, 132);
            this.User_Group.TabIndex = 0;
            this.User_Group.TabStop = false;
            this.User_Group.Text = "Printers Information";
            // 
            // Delete_Btn
            // 
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
            this.Delete_Btn.Location = new System.Drawing.Point(192, 88);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(70, 25);
            this.Delete_Btn.TabIndex = 15;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
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
            this.Save_Btn.Location = new System.Drawing.Point(82, 88);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_Btn.TabIndex = 14;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Default_Txt
            // 
            this.Default_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Default_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Default_Txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default_Txt.FormattingEnabled = true;
            this.Default_Txt.Location = new System.Drawing.Point(67, 37);
            this.Default_Txt.Name = "Default_Txt";
            this.Default_Txt.Size = new System.Drawing.Size(235, 23);
            this.Default_Txt.TabIndex = 4;
            this.Default_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Default";
            // 
            // t_PrinterBindingSource
            // 
            this.t_PrinterBindingSource.DataMember = "T_Printer";
            this.t_PrinterBindingSource.DataSource = this.CoSet;
            // 
            // CoSet
            // 
            this.CoSet.DataSetName = "ChequerDataSet";
            this.CoSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_PrinterTableAdapter
            // 
            this.t_PrinterTableAdapter.ClearBeforeFill = true;
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1020, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.So);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Printer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Printer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.User_Group.ResumeLayout(false);
            this.User_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_PrinterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Panel So;
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox User_Group;
        private ChequerDataSet CoSet;
        private System.Windows.Forms.ComboBox Default_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.BindingSource t_PrinterBindingSource;
        private ChequerDataSetTableAdapters.T_PrinterTableAdapter t_PrinterTableAdapter;
        private System.Windows.Forms.Button Delete_Btn;
    }
}