namespace LearnWinForms
{
    partial class frmHome
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
            this.btnGetDatabaseInformation = new System.Windows.Forms.Button();
            this.txtStudentInformation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetDatabaseInformation
            // 
            this.btnGetDatabaseInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGetDatabaseInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDatabaseInformation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDatabaseInformation.Location = new System.Drawing.Point(180, 44);
            this.btnGetDatabaseInformation.Name = "btnGetDatabaseInformation";
            this.btnGetDatabaseInformation.Size = new System.Drawing.Size(163, 30);
            this.btnGetDatabaseInformation.TabIndex = 0;
            this.btnGetDatabaseInformation.Text = "Get Student Information";
            this.btnGetDatabaseInformation.UseVisualStyleBackColor = false;
            this.btnGetDatabaseInformation.Click += new System.EventHandler(this.btnGetDatabaseInformation_Click);
            // 
            // txtStudentInformation
            // 
            this.txtStudentInformation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentInformation.Location = new System.Drawing.Point(75, 103);
            this.txtStudentInformation.Multiline = true;
            this.txtStudentInformation.Name = "txtStudentInformation";
            this.txtStudentInformation.Size = new System.Drawing.Size(375, 104);
            this.txtStudentInformation.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 261);
            this.Controls.Add(this.txtStudentInformation);
            this.Controls.Add(this.btnGetDatabaseInformation);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Windows Forms Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDatabaseInformation;
        private System.Windows.Forms.TextBox txtStudentInformation;
    }
}

