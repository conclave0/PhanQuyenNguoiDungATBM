namespace ATBMN28_Login
{
    partial class OLSAdminManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username_Label = new System.Windows.Forms.Label();
            this.ID_Cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Level_Cbb = new System.Windows.Forms.ComboBox();
            this.Execute_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(25, 64);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(18, 13);
            this.Username_Label.TabIndex = 1;
            this.Username_Label.Text = "ID";
            // 
            // ID_Cbb
            // 
            this.ID_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_Cbb.FormattingEnabled = true;
            this.ID_Cbb.Location = new System.Drawing.Point(107, 61);
            this.ID_Cbb.Name = "ID_Cbb";
            this.ID_Cbb.Size = new System.Drawing.Size(121, 21);
            this.ID_Cbb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level";
            // 
            // Level_Cbb
            // 
            this.Level_Cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Level_Cbb.FormattingEnabled = true;
            this.Level_Cbb.Location = new System.Drawing.Point(106, 126);
            this.Level_Cbb.Name = "Level_Cbb";
            this.Level_Cbb.Size = new System.Drawing.Size(121, 21);
            this.Level_Cbb.TabIndex = 10;
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(107, 326);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(121, 23);
            this.Execute_Btn.TabIndex = 9;
            this.Execute_Btn.Text = "Execute";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(739, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // OLSAdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Level_Cbb);
            this.Controls.Add(this.Execute_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Cbb);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OLSAdminManager";
            this.Text = "OLSAdminManager";
            this.Load += new System.EventHandler(this.OLSAdminManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.ComboBox ID_Cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Level_Cbb;
        private System.Windows.Forms.Button Execute_Btn;
        private System.Windows.Forms.Label label2;
    }
}