namespace LearnWinForms
{
    partial class Inventory
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonCommitDatabase = new System.Windows.Forms.Button();
            this.buttonDeleteData = new System.Windows.Forms.Button();
            this.ButtonInsertData = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.ButtonGetData = new System.Windows.Forms.Button();
            this.panelInputControls = new System.Windows.Forms.Panel();
            this.datetimepickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.labelMfgDate = new System.Windows.Forms.Label();
            this.textboxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textboxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            this.panelInputControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(505, 182);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProduct_CellValueChanged);
            this.dataGridViewProduct.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridViewProduct_UserDeletingRow);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonCommitDatabase);
            this.groupBoxControls.Controls.Add(this.buttonDeleteData);
            this.groupBoxControls.Controls.Add(this.ButtonInsertData);
            this.groupBoxControls.Controls.Add(this.buttonUpdateData);
            this.groupBoxControls.Controls.Add(this.ButtonGetData);
            this.groupBoxControls.Location = new System.Drawing.Point(533, 58);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(160, 181);
            this.groupBoxControls.TabIndex = 1;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Data Operations";
            // 
            // buttonCommitDatabase
            // 
            this.buttonCommitDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCommitDatabase.Location = new System.Drawing.Point(32, 137);
            this.buttonCommitDatabase.Name = "buttonCommitDatabase";
            this.buttonCommitDatabase.Size = new System.Drawing.Size(98, 23);
            this.buttonCommitDatabase.TabIndex = 4;
            this.buttonCommitDatabase.Text = "Commit Database";
            this.buttonCommitDatabase.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteData
            // 
            this.buttonDeleteData.Location = new System.Drawing.Point(32, 110);
            this.buttonDeleteData.Name = "buttonDeleteData";
            this.buttonDeleteData.Size = new System.Drawing.Size(98, 23);
            this.buttonDeleteData.TabIndex = 3;
            this.buttonDeleteData.Text = "Delete Data";
            this.buttonDeleteData.UseVisualStyleBackColor = true;
            this.buttonDeleteData.Click += new System.EventHandler(this.ButtonDeleteData_Click);
            // 
            // ButtonInsertData
            // 
            this.ButtonInsertData.Location = new System.Drawing.Point(32, 82);
            this.ButtonInsertData.Name = "ButtonInsertData";
            this.ButtonInsertData.Size = new System.Drawing.Size(98, 23);
            this.ButtonInsertData.TabIndex = 2;
            this.ButtonInsertData.Text = "Insert Data";
            this.ButtonInsertData.UseVisualStyleBackColor = true;
            this.ButtonInsertData.Click += new System.EventHandler(this.ButtonInsertData_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(32, 54);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdateData.TabIndex = 1;
            this.buttonUpdateData.Text = "Update Data";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.ButtonUpdateData_Click);
            // 
            // ButtonGetData
            // 
            this.ButtonGetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonGetData.Location = new System.Drawing.Point(32, 26);
            this.ButtonGetData.Name = "ButtonGetData";
            this.ButtonGetData.Size = new System.Drawing.Size(98, 23);
            this.ButtonGetData.TabIndex = 0;
            this.ButtonGetData.Text = "Get Data";
            this.ButtonGetData.UseVisualStyleBackColor = false;
            this.ButtonGetData.Click += new System.EventHandler(this.ButtonGetData_Click);
            // 
            // panelInputControls
            // 
            this.panelInputControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInputControls.Controls.Add(this.buttonToggle);
            this.panelInputControls.Controls.Add(this.datetimepickerMfgDate);
            this.panelInputControls.Controls.Add(this.labelMfgDate);
            this.panelInputControls.Controls.Add(this.textboxCost);
            this.panelInputControls.Controls.Add(this.labelCost);
            this.panelInputControls.Controls.Add(this.textboxProductName);
            this.panelInputControls.Controls.Add(this.labelProductName);
            this.panelInputControls.Location = new System.Drawing.Point(12, 8);
            this.panelInputControls.Name = "panelInputControls";
            this.panelInputControls.Size = new System.Drawing.Size(681, 43);
            this.panelInputControls.TabIndex = 2;
            // 
            // datetimepickerMfgDate
            // 
            this.datetimepickerMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepickerMfgDate.Location = new System.Drawing.Point(460, 11);
            this.datetimepickerMfgDate.Name = "datetimepickerMfgDate";
            this.datetimepickerMfgDate.Size = new System.Drawing.Size(135, 20);
            this.datetimepickerMfgDate.TabIndex = 8;
            this.datetimepickerMfgDate.Value = new System.DateTime(2019, 5, 2, 6, 29, 16, 0);
            this.datetimepickerMfgDate.ValueChanged += new System.EventHandler(this.DatetimepickerMfgDate_ValueChanged);
            // 
            // labelMfgDate
            // 
            this.labelMfgDate.AutoSize = true;
            this.labelMfgDate.Location = new System.Drawing.Point(401, 14);
            this.labelMfgDate.Name = "labelMfgDate";
            this.labelMfgDate.Size = new System.Drawing.Size(60, 13);
            this.labelMfgDate.TabIndex = 6;
            this.labelMfgDate.Text = "Mfg Date : ";
            // 
            // textboxCost
            // 
            this.textboxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxCost.Location = new System.Drawing.Point(309, 12);
            this.textboxCost.MaxLength = 50;
            this.textboxCost.Name = "textboxCost";
            this.textboxCost.Size = new System.Drawing.Size(77, 20);
            this.textboxCost.TabIndex = 5;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(245, 15);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(63, 13);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Cost (in $) : ";
            // 
            // textboxProductName
            // 
            this.textboxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxProductName.Location = new System.Drawing.Point(96, 12);
            this.textboxProductName.MaxLength = 50;
            this.textboxProductName.Name = "textboxProductName";
            this.textboxProductName.Size = new System.Drawing.Size(136, 20);
            this.textboxProductName.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(13, 15);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(84, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name : ";
            // 
            // buttonToggle
            // 
            this.buttonToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToggle.Location = new System.Drawing.Point(606, 12);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(57, 20);
            this.buttonToggle.TabIndex = 9;
            this.buttonToggle.Text = "Hide";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.ButtonToggle_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 248);
            this.Controls.Add(this.panelInputControls);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.dataGridViewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory :: DataSet and DataAdaptor";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.panelInputControls.ResumeLayout(false);
            this.panelInputControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonDeleteData;
        private System.Windows.Forms.Button ButtonInsertData;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Button ButtonGetData;
        private System.Windows.Forms.Panel panelInputControls;
        private System.Windows.Forms.Label labelMfgDate;
        private System.Windows.Forms.TextBox textboxCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textboxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.DateTimePicker datetimepickerMfgDate;
        private System.Windows.Forms.Button buttonCommitDatabase;
        private System.Windows.Forms.Button buttonToggle;
    }
}