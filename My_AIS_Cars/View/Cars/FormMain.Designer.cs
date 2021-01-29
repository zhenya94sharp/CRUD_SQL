namespace My_AIS_Cars.View
{
    partial class FormMain
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxBalance = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDt = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCredit = new System.Windows.Forms.CheckBox();
            this.comboBoxModelsCars = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(744, 16);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 32);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.Text = "Очистить таблицу";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(704, 264);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(152, 40);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Обновить выбранный автомобиль";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(704, 320);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 40);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Удалить выбранный автомобиль";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(528, 264);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(152, 40);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить автомобиль";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AccessibleName = "";
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(8, 56);
            this.dataGridViewCars.MultiSelect = false;
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.ShowEditingIcon = false;
            this.dataGridViewCars.ShowRowErrors = false;
            this.dataGridViewCars.Size = new System.Drawing.Size(848, 184);
            this.dataGridViewCars.TabIndex = 22;
            this.dataGridViewCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellClick);
            this.dataGridViewCars.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCars_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Список автомобилей";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(16, 16);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 32);
            this.buttonRefresh.TabIndex = 39;
            this.buttonRefresh.Text = "Обновить таблицу";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(528, 320);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 40);
            this.buttonSearch.TabIndex = 41;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(240, 360);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 35;
            this.textBoxId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Кузов";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(216, 272);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(192, 20);
            this.textBoxBody.TabIndex = 26;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(304, 320);
            this.maskedTextBoxPrice.Mask = "0000000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPrice.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Год выпуска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Цена";
            // 
            // maskedTextBoxBalance
            // 
            this.maskedTextBoxBalance.Location = new System.Drawing.Point(224, 320);
            this.maskedTextBoxBalance.Mask = "000";
            this.maskedTextBoxBalance.Name = "maskedTextBoxBalance";
            this.maskedTextBoxBalance.Size = new System.Drawing.Size(52, 20);
            this.maskedTextBoxBalance.TabIndex = 31;
            // 
            // dateTimePickerDt
            // 
            this.dateTimePickerDt.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDt.Location = new System.Drawing.Point(8, 328);
            this.dateTimePickerDt.Name = "dateTimePickerDt";
            this.dateTimePickerDt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDt.TabIndex = 37;
            // 
            // checkBoxCredit
            // 
            this.checkBoxCredit.AutoSize = true;
            this.checkBoxCredit.Location = new System.Drawing.Point(424, 296);
            this.checkBoxCredit.Name = "checkBoxCredit";
            this.checkBoxCredit.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCredit.TabIndex = 40;
            this.checkBoxCredit.Text = "Автокредит";
            this.checkBoxCredit.UseVisualStyleBackColor = true;
            // 
            // comboBoxModelsCars
            // 
            this.comboBoxModelsCars.FormattingEnabled = true;
            this.comboBoxModelsCars.Location = new System.Drawing.Point(8, 272);
            this.comboBoxModelsCars.Name = "comboBoxModelsCars";
            this.comboBoxModelsCars.Size = new System.Drawing.Size(192, 21);
            this.comboBoxModelsCars.TabIndex = 42;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 386);
            this.Controls.Add(this.comboBoxModelsCars);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxCredit);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dateTimePickerDt);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIS CARS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxBody;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxBalance;
        public System.Windows.Forms.DateTimePicker dateTimePickerDt;
        public System.Windows.Forms.CheckBox checkBoxCredit;
        public System.Windows.Forms.ComboBox comboBoxModelsCars;
    }
}