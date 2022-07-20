namespace VKR
{
    partial class RedMarsh
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
            System.Windows.Forms.Label otkudaLabel;
            System.Windows.Forms.Label dateotpLabel;
            System.Windows.Forms.Label datepribLabel;
            System.Windows.Forms.Label avtoLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label kudaLabel;
            System.Windows.Forms.Label id_reisaLabel;
            System.Windows.Forms.Label timeotpLabel1;
            System.Windows.Forms.Label timepribLabel1;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timepribDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reis1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet1 = new VKR.aeroDataSet1();
            this.timeotpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.otkudaTextBox = new System.Windows.Forms.TextBox();
            this.kudaTextBox = new System.Windows.Forms.TextBox();
            this.dateotpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datepribDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reis1TableAdapter = new VKR.aeroDataSet1TableAdapters.reis1TableAdapter();
            this.tableAdapterManager = new VKR.aeroDataSet1TableAdapters.TableAdapterManager();
            otkudaLabel = new System.Windows.Forms.Label();
            dateotpLabel = new System.Windows.Forms.Label();
            datepribLabel = new System.Windows.Forms.Label();
            avtoLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            kudaLabel = new System.Windows.Forms.Label();
            id_reisaLabel = new System.Windows.Forms.Label();
            timeotpLabel1 = new System.Windows.Forms.Label();
            timepribLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reis1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // otkudaLabel
            // 
            otkudaLabel.AutoSize = true;
            otkudaLabel.Location = new System.Drawing.Point(77, 71);
            otkudaLabel.Name = "otkudaLabel";
            otkudaLabel.Size = new System.Drawing.Size(105, 13);
            otkudaLabel.TabIndex = 3;
            otkudaLabel.Text = "Пункт отправления";
            // 
            // dateotpLabel
            // 
            dateotpLabel.AutoSize = true;
            dateotpLabel.Location = new System.Drawing.Point(83, 126);
            dateotpLabel.Name = "dateotpLabel";
            dateotpLabel.Size = new System.Drawing.Size(101, 13);
            dateotpLabel.TabIndex = 7;
            dateotpLabel.Text = "Дата отправления";
            // 
            // datepribLabel
            // 
            datepribLabel.AutoSize = true;
            datepribLabel.Location = new System.Drawing.Point(97, 181);
            datepribLabel.Name = "datepribLabel";
            datepribLabel.Size = new System.Drawing.Size(85, 13);
            datepribLabel.TabIndex = 9;
            datepribLabel.Text = "Дата прибытия";
            // 
            // avtoLabel
            // 
            avtoLabel.AutoSize = true;
            avtoLabel.Location = new System.Drawing.Point(108, 45);
            avtoLabel.Name = "avtoLabel";
            avtoLabel.Size = new System.Drawing.Size(74, 13);
            avtoLabel.TabIndex = 13;
            avtoLabel.Text = "Номер рейса";
            avtoLabel.Click += new System.EventHandler(this.avtoLabel_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(142, 230);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Цена";
            // 
            // kudaLabel
            // 
            kudaLabel.AutoSize = true;
            kudaLabel.Location = new System.Drawing.Point(83, 97);
            kudaLabel.Name = "kudaLabel";
            kudaLabel.Size = new System.Drawing.Size(99, 13);
            kudaLabel.TabIndex = 5;
            kudaLabel.Text = "Пункт назначения";
            // 
            // id_reisaLabel
            // 
            id_reisaLabel.AutoSize = true;
            id_reisaLabel.Location = new System.Drawing.Point(142, 22);
            id_reisaLabel.Name = "id_reisaLabel";
            id_reisaLabel.Size = new System.Drawing.Size(43, 13);
            id_reisaLabel.TabIndex = 20;
            id_reisaLabel.Text = "id reisa:";
            id_reisaLabel.Visible = false;
            // 
            // timeotpLabel1
            // 
            timeotpLabel1.AutoSize = true;
            timeotpLabel1.Location = new System.Drawing.Point(76, 153);
            timeotpLabel1.Name = "timeotpLabel1";
            timeotpLabel1.Size = new System.Drawing.Size(108, 13);
            timeotpLabel1.TabIndex = 40;
            timeotpLabel1.Text = "Время отправления";
            // 
            // timepribLabel1
            // 
            timepribLabel1.AutoSize = true;
            timepribLabel1.Location = new System.Drawing.Point(90, 205);
            timepribLabel1.Name = "timepribLabel1";
            timepribLabel1.Size = new System.Drawing.Size(92, 13);
            timepribLabel1.TabIndex = 41;
            timepribLabel1.Text = "Время прибытия";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(81, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(207, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(timepribLabel1);
            this.groupBox1.Controls.Add(this.timepribDateTimePicker);
            this.groupBox1.Controls.Add(timeotpLabel1);
            this.groupBox1.Controls.Add(this.timeotpDateTimePicker);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(id_reisaLabel);
            this.groupBox1.Controls.Add(this.numberTextBox);
            this.groupBox1.Controls.Add(this.otkudaTextBox);
            this.groupBox1.Controls.Add(this.kudaTextBox);
            this.groupBox1.Controls.Add(this.dateotpDateTimePicker);
            this.groupBox1.Controls.Add(this.datepribDateTimePicker);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(kudaLabel);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(avtoLabel);
            this.groupBox1.Controls.Add(datepribLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(dateotpLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(otkudaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 336);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // timepribDateTimePicker
            // 
            this.timepribDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reis1BindingSource, "timeprib", true));
            this.timepribDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepribDateTimePicker.Location = new System.Drawing.Point(196, 201);
            this.timepribDateTimePicker.Name = "timepribDateTimePicker";
            this.timepribDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timepribDateTimePicker.TabIndex = 42;
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
            // timeotpDateTimePicker
            // 
            this.timeotpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reis1BindingSource, "timeotp", true));
            this.timeotpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeotpDateTimePicker.Location = new System.Drawing.Point(196, 149);
            this.timeotpDateTimePicker.Name = "timeotpDateTimePicker";
            this.timeotpDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timeotpDateTimePicker.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.reis1BindingSource;
            this.comboBox1.DisplayMember = "id_reisa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.Visible = false;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reis1BindingSource, "number", true));
            this.numberTextBox.Location = new System.Drawing.Point(196, 45);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberTextBox.TabIndex = 23;
            // 
            // otkudaTextBox
            // 
            this.otkudaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reis1BindingSource, "otkuda", true));
            this.otkudaTextBox.Location = new System.Drawing.Point(196, 71);
            this.otkudaTextBox.Name = "otkudaTextBox";
            this.otkudaTextBox.Size = new System.Drawing.Size(200, 20);
            this.otkudaTextBox.TabIndex = 25;
            // 
            // kudaTextBox
            // 
            this.kudaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reis1BindingSource, "kuda", true));
            this.kudaTextBox.Location = new System.Drawing.Point(196, 97);
            this.kudaTextBox.Name = "kudaTextBox";
            this.kudaTextBox.Size = new System.Drawing.Size(200, 20);
            this.kudaTextBox.TabIndex = 27;
            // 
            // dateotpDateTimePicker
            // 
            this.dateotpDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reis1BindingSource, "dateotp", true));
            this.dateotpDateTimePicker.Location = new System.Drawing.Point(196, 123);
            this.dateotpDateTimePicker.Name = "dateotpDateTimePicker";
            this.dateotpDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateotpDateTimePicker.TabIndex = 29;
            // 
            // datepribDateTimePicker
            // 
            this.datepribDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reis1BindingSource, "dateprib", true));
            this.datepribDateTimePicker.Location = new System.Drawing.Point(196, 175);
            this.datepribDateTimePicker.Name = "datepribDateTimePicker";
            this.datepribDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datepribDateTimePicker.TabIndex = 33;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reis1BindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(196, 227);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Редактирование рейса";
            // 
            // reis1TableAdapter
            // 
            this.reis1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.avtobus1TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.marshrut1TableAdapter = null;
            this.tableAdapterManager.reis1TableAdapter = this.reis1TableAdapter;
            this.tableAdapterManager.ticket1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VKR.aeroDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditeli1TableAdapter = null;
            // 
            // RedMarsh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RedMarsh";
            this.Text = "RedMarsh";
            this.Load += new System.EventHandler(this.RedMarsh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reis1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private aeroDataSet1 aeroDataSet1;
        private System.Windows.Forms.BindingSource reis1BindingSource;
        private aeroDataSet1TableAdapters.reis1TableAdapter reis1TableAdapter;
        private aeroDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox otkudaTextBox;
        private System.Windows.Forms.TextBox kudaTextBox;
        private System.Windows.Forms.DateTimePicker dateotpDateTimePicker;
        private System.Windows.Forms.DateTimePicker datepribDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker timepribDateTimePicker;
        private System.Windows.Forms.DateTimePicker timeotpDateTimePicker;
    }
}