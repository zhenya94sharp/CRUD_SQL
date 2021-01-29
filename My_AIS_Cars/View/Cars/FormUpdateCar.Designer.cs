namespace My_AIS_Cars.View.Cars
{
    partial class FormUpdateCar
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
            this.comboBoxModelsCars = new System.Windows.Forms.ComboBox();
            this.checkBoxCredit = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDt = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxBalance = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxModelsCars
            // 
            this.comboBoxModelsCars.FormattingEnabled = true;
            this.comboBoxModelsCars.Location = new System.Drawing.Point(40, 40);
            this.comboBoxModelsCars.Name = "comboBoxModelsCars";
            this.comboBoxModelsCars.Size = new System.Drawing.Size(192, 21);
            this.comboBoxModelsCars.TabIndex = 64;
            // 
            // checkBoxCredit
            // 
            this.checkBoxCredit.AutoSize = true;
            this.checkBoxCredit.Location = new System.Drawing.Point(456, 64);
            this.checkBoxCredit.Name = "checkBoxCredit";
            this.checkBoxCredit.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCredit.TabIndex = 63;
            this.checkBoxCredit.Text = "Автокредит";
            this.checkBoxCredit.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDt
            // 
            this.dateTimePickerDt.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDt.Location = new System.Drawing.Point(40, 96);
            this.dateTimePickerDt.Name = "dateTimePickerDt";
            this.dateTimePickerDt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDt.TabIndex = 62;
            // 
            // maskedTextBoxBalance
            // 
            this.maskedTextBoxBalance.Location = new System.Drawing.Point(256, 96);
            this.maskedTextBoxBalance.Mask = "000";
            this.maskedTextBoxBalance.Name = "maskedTextBoxBalance";
            this.maskedTextBoxBalance.Size = new System.Drawing.Size(52, 20);
            this.maskedTextBoxBalance.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Кол-во";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Год выпуска";
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(336, 96);
            this.maskedTextBoxPrice.Mask = "0000000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPrice.TabIndex = 57;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(248, 40);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(192, 20);
            this.textBoxBody.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Кузов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Модель";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(152, 144);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(208, 40);
            this.buttonUpdate.TabIndex = 65;
            this.buttonUpdate.Text = "Обновить данные";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // FormUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 215);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxModelsCars);
            this.Controls.Add(this.checkBoxCredit);
            this.Controls.Add(this.dateTimePickerDt);
            this.Controls.Add(this.maskedTextBoxBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUpdateCar";
            this.Text = "FormUpdateCar";
            this.Load += new System.EventHandler(this.UpdateCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxModelsCars;
        public System.Windows.Forms.CheckBox checkBoxCredit;
        public System.Windows.Forms.DateTimePicker dateTimePickerDt;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        public System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
    }
}