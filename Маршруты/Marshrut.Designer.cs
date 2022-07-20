namespace VKR.Маршруты
{
    partial class Marshrut
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.reis1DataGridView = new System.Windows.Forms.DataGridView();
            this.idreisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otkudaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kudaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateotpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeotpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timepribDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reis1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet1 = new VKR.aeroDataSet1();
            this.reis1TableAdapter = new VKR.aeroDataSet1TableAdapters.reis1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reis1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reis1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(393, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(259, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(123, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(612, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 40);
            this.button5.TabIndex = 30;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(751, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 40);
            this.button6.TabIndex = 31;
            this.button6.Text = "Закрыть";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // reis1DataGridView
            // 
            this.reis1DataGridView.AutoGenerateColumns = false;
            this.reis1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reis1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reis1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreisaDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.otkudaDataGridViewTextBoxColumn,
            this.kudaDataGridViewTextBoxColumn,
            this.dateotpDataGridViewTextBoxColumn,
            this.timeotpDataGridViewTextBoxColumn,
            this.datepribDataGridViewTextBoxColumn,
            this.timepribDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.mestostDataGridViewTextBoxColumn});
            this.reis1DataGridView.DataSource = this.reis1BindingSource;
            this.reis1DataGridView.Location = new System.Drawing.Point(12, 47);
            this.reis1DataGridView.Name = "reis1DataGridView";
            this.reis1DataGridView.Size = new System.Drawing.Size(853, 220);
            this.reis1DataGridView.TabIndex = 34;
            // 
            // idreisaDataGridViewTextBoxColumn
            // 
            this.idreisaDataGridViewTextBoxColumn.DataPropertyName = "id_reisa";
            this.idreisaDataGridViewTextBoxColumn.HeaderText = "id";
            this.idreisaDataGridViewTextBoxColumn.Name = "idreisaDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // otkudaDataGridViewTextBoxColumn
            // 
            this.otkudaDataGridViewTextBoxColumn.DataPropertyName = "otkuda";
            this.otkudaDataGridViewTextBoxColumn.HeaderText = "Откуда";
            this.otkudaDataGridViewTextBoxColumn.Name = "otkudaDataGridViewTextBoxColumn";
            // 
            // kudaDataGridViewTextBoxColumn
            // 
            this.kudaDataGridViewTextBoxColumn.DataPropertyName = "kuda";
            this.kudaDataGridViewTextBoxColumn.HeaderText = "Куда";
            this.kudaDataGridViewTextBoxColumn.Name = "kudaDataGridViewTextBoxColumn";
            // 
            // dateotpDataGridViewTextBoxColumn
            // 
            this.dateotpDataGridViewTextBoxColumn.DataPropertyName = "dateotp";
            this.dateotpDataGridViewTextBoxColumn.HeaderText = "Дата отправления";
            this.dateotpDataGridViewTextBoxColumn.Name = "dateotpDataGridViewTextBoxColumn";
            // 
            // timeotpDataGridViewTextBoxColumn
            // 
            this.timeotpDataGridViewTextBoxColumn.DataPropertyName = "timeotp";
            this.timeotpDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.timeotpDataGridViewTextBoxColumn.Name = "timeotpDataGridViewTextBoxColumn";
            // 
            // datepribDataGridViewTextBoxColumn
            // 
            this.datepribDataGridViewTextBoxColumn.DataPropertyName = "dateprib";
            this.datepribDataGridViewTextBoxColumn.HeaderText = "Дата прибытия";
            this.datepribDataGridViewTextBoxColumn.Name = "datepribDataGridViewTextBoxColumn";
            // 
            // timepribDataGridViewTextBoxColumn
            // 
            this.timepribDataGridViewTextBoxColumn.DataPropertyName = "timeprib";
            this.timepribDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.timepribDataGridViewTextBoxColumn.Name = "timepribDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // mestostDataGridViewTextBoxColumn
            // 
            this.mestostDataGridViewTextBoxColumn.DataPropertyName = "mestost";
            this.mestostDataGridViewTextBoxColumn.HeaderText = "Осталось мест";
            this.mestostDataGridViewTextBoxColumn.Name = "mestostDataGridViewTextBoxColumn";
            // 
            // reis1BindingSource
            // 
            this.reis1BindingSource.DataMember = "reis1";
            this.reis1BindingSource.DataSource = this.aeroDataSet1;
            // 
            // aeroDataSet1
            // 
            this.aeroDataSet1.DataSetName = "aeroDataSet1";
            this.aeroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reis1TableAdapter
            // 
            this.reis1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // Marshrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reis1DataGridView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Marshrut";
            this.Text = "Рейсы";
            this.Load += new System.EventHandler(this.Marshrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reis1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reis1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
       
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView reis1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private aeroDataSet1 aeroDataSet1;
        private System.Windows.Forms.BindingSource reis1BindingSource;
        private aeroDataSet1TableAdapters.reis1TableAdapter reis1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otkudaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kudaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateotpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeotpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepribDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timepribDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}