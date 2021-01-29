namespace My_AIS_Cars.View.Cars
{
    partial class FormMainSearch
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
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.checkBoxCredit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Максимальная цена";
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(248, 32);
            this.maskedTextBoxPrice.Mask = "0000000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBoxPrice.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Модель";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(232, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 32);
            this.buttonSearch.TabIndex = 53;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(16, 32);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModel.TabIndex = 55;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 152);
            this.dataGridViewSearch.MultiSelect = false;
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearch.Size = new System.Drawing.Size(632, 304);
            this.dataGridViewSearch.TabIndex = 56;
            // 
            // checkBoxCredit
            // 
            this.checkBoxCredit.AutoSize = true;
            this.checkBoxCredit.Location = new System.Drawing.Point(432, 32);
            this.checkBoxCredit.Name = "checkBoxCredit";
            this.checkBoxCredit.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCredit.TabIndex = 57;
            this.checkBoxCredit.Text = "Автокредит";
            this.checkBoxCredit.UseVisualStyleBackColor = true;
            // 
            // FormMainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 469);
            this.Controls.Add(this.checkBoxCredit);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.label2);
            this.Name = "FormMainSearch";
            this.Text = "FormMainSearch";
            this.Load += new System.EventHandler(this.FormMainSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.DataGridView dataGridViewSearch;
        public System.Windows.Forms.ComboBox comboBoxModel;
        public System.Windows.Forms.CheckBox checkBoxCredit;
    }
}