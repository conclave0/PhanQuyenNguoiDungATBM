namespace ATBMN28_Login
{
    partial class ControlUserRole
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
            this.Execute_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_Cbb = new System.Windows.Forms.ComboBox();
            this.Role_Cbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Syntax_Cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(118, 347);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(121, 23);
            this.Execute_Btn.TabIndex = 20;
            this.Execute_Btn.Text = "Execute";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 339);
            this.dataGridView1.TabIndex = 19;
            // 
            // User_Cbb
            // 
            this.User_Cbb.FormattingEnabled = true;
            this.User_Cbb.Location = new System.Drawing.Point(118, 179);
            this.User_Cbb.Name = "User_Cbb";
            this.User_Cbb.Size = new System.Drawing.Size(121, 21);
            this.User_Cbb.TabIndex = 18;
            // 
            // Role_Cbb
            // 
            this.Role_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role_Cbb.FormattingEnabled = true;
            this.Role_Cbb.Location = new System.Drawing.Point(120, 109);
            this.Role_Cbb.Name = "Role_Cbb";
            this.Role_Cbb.Size = new System.Drawing.Size(121, 21);
            this.Role_Cbb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = " Role";
            // 
            // Syntax_Cbb
            // 
            this.Syntax_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Syntax_Cbb.FormattingEnabled = true;
            this.Syntax_Cbb.Location = new System.Drawing.Point(118, 38);
            this.Syntax_Cbb.Name = "Syntax_Cbb";
            this.Syntax_Cbb.Size = new System.Drawing.Size(121, 21);
            this.Syntax_Cbb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Syntax";
            // 
            // ControlUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 403);
            this.Controls.Add(this.Execute_Btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.User_Cbb);
            this.Controls.Add(this.Role_Cbb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Syntax_Cbb);
            this.Controls.Add(this.label1);
            this.Name = "ControlUserRole";
            this.Text = "ControlUserRole";
            this.Load += new System.EventHandler(this.ControlUserRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox User_Cbb;
        private System.Windows.Forms.ComboBox Role_Cbb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Syntax_Cbb;
        private System.Windows.Forms.Label label1;
    }
}