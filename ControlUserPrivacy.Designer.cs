namespace ATBMN28_Login
{
    partial class ControlUserPrivacy
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
            this.label1 = new System.Windows.Forms.Label();
            this.Syntax_Cbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Type_Cbb = new System.Windows.Forms.ComboBox();
            this.TS_Cbb = new System.Windows.Forms.ComboBox();
            this.User_Cbb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Execute_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Syntax";
            // 
            // Syntax_Cbb
            // 
            this.Syntax_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Syntax_Cbb.FormattingEnabled = true;
            this.Syntax_Cbb.Location = new System.Drawing.Point(124, 36);
            this.Syntax_Cbb.Name = "Syntax_Cbb";
            this.Syntax_Cbb.Size = new System.Drawing.Size(121, 21);
            this.Syntax_Cbb.TabIndex = 1;
            this.Syntax_Cbb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Table/Store";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "User";
            // 
            // Type_Cbb
            // 
            this.Type_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Cbb.FormattingEnabled = true;
            this.Type_Cbb.Location = new System.Drawing.Point(124, 222);
            this.Type_Cbb.Name = "Type_Cbb";
            this.Type_Cbb.Size = new System.Drawing.Size(121, 21);
            this.Type_Cbb.TabIndex = 5;
            // 
            // TS_Cbb
            // 
            this.TS_Cbb.FormattingEnabled = true;
            this.TS_Cbb.Location = new System.Drawing.Point(124, 269);
            this.TS_Cbb.Name = "TS_Cbb";
            this.TS_Cbb.Size = new System.Drawing.Size(121, 21);
            this.TS_Cbb.TabIndex = 6;
            this.TS_Cbb.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // User_Cbb
            // 
            this.User_Cbb.FormattingEnabled = true;
            this.User_Cbb.Location = new System.Drawing.Point(124, 177);
            this.User_Cbb.Name = "User_Cbb";
            this.User_Cbb.Size = new System.Drawing.Size(121, 21);
            this.User_Cbb.TabIndex = 7;
            this.User_Cbb.SelectedIndexChanged += new System.EventHandler(this.User_Cbb_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 339);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(124, 351);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(121, 23);
            this.Execute_Btn.TabIndex = 9;
            this.Execute_Btn.Text = "Execute";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(45, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Role";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(45, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // ControlUserPrivacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Execute_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.User_Cbb);
            this.Controls.Add(this.TS_Cbb);
            this.Controls.Add(this.Type_Cbb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Syntax_Cbb);
            this.Controls.Add(this.label1);
            this.Name = "ControlUserPrivacy";
            this.Text = "ControlUserPrivacy";
            this.Load += new System.EventHandler(this.ControlUserPrivacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Syntax_Cbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Type_Cbb;
        private System.Windows.Forms.ComboBox TS_Cbb;
        private System.Windows.Forms.ComboBox User_Cbb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Execute_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
