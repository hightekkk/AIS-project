namespace VKR.Автобус
{
    partial class RedAvto
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label id_avtoLabel;
            System.Windows.Forms.Label avtoLabel;
            System.Windows.Forms.Label nomerLabel1;
            System.Windows.Forms.Label mestaLabel1;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.avtobus1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet1 = new VKR.aeroDataSet1();
            this.avtoTextBox = new System.Windows.Forms.TextBox();
            this.nomerTextBox = new System.Windows.Forms.TextBox();
            this.mestaTextBox = new System.Windows.Forms.TextBox();
            this.avtobus1TableAdapter = new VKR.aeroDataSet1TableAdapters.avtobus1TableAdapter();
            this.tableAdapterManager = new VKR.aeroDataSet1TableAdapters.TableAdapterManager();
            label1 = new System.Windows.Forms.Label();
            id_avtoLabel = new System.Windows.Forms.Label();
            avtoLabel = new System.Windows.Forms.Label();
            nomerLabel1 = new System.Windows.Forms.Label();
            mestaLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtobus1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            label1.Location = new System.Drawing.Point(58, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 25);
            label1.TabIndex = 12;
            label1.Text = "Редактирование";
            // 
            // id_avtoLabel
            // 
            id_avtoLabel.AutoSize = true;
            id_avtoLabel.Location = new System.Drawing.Point(30, 30);
            id_avtoLabel.Name = "id_avtoLabel";
            id_avtoLabel.Size = new System.Drawing.Size(42, 13);
            id_avtoLabel.TabIndex = 11;
            id_avtoLabel.Text = "id avto:";
            id_avtoLabel.Visible = false;
            // 
            // avtoLabel
            // 
            avtoLabel.AutoSize = true;
            avtoLabel.Location = new System.Drawing.Point(30, 56);
            avtoLabel.Name = "avtoLabel";
            avtoLabel.Size = new System.Drawing.Size(31, 13);
            avtoLabel.TabIndex = 13;
            avtoLabel.Text = "avto:";
            // 
            // nomerLabel1
            // 
            nomerLabel1.AutoSize = true;
            nomerLabel1.Location = new System.Drawing.Point(30, 82);
            nomerLabel1.Name = "nomerLabel1";
            nomerLabel1.Size = new System.Drawing.Size(39, 13);
            nomerLabel1.TabIndex = 15;
            nomerLabel1.Text = "nomer:";
            // 
            // mestaLabel1
            // 
            mestaLabel1.AutoSize = true;
            mestaLabel1.Location = new System.Drawing.Point(30, 108);
            mestaLabel1.Name = "mestaLabel1";
            mestaLabel1.Size = new System.Drawing.Size(38, 13);
            mestaLabel1.TabIndex = 17;
            mestaLabel1.Text = "mesta:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(33, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(166, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(id_avtoLabel);
            this.groupBox1.Controls.Add(avtoLabel);
            this.groupBox1.Controls.Add(this.avtoTextBox);
            this.groupBox1.Controls.Add(nomerLabel1);
            this.groupBox1.Controls.Add(this.nomerTextBox);
            this.groupBox1.Controls.Add(mestaLabel1);
            this.groupBox1.Controls.Add(this.mestaTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 210);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.avtobus1BindingSource;
            this.comboBox1.DisplayMember = "id_avto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Visible = false;
            // 
            // avtobus1BindingSource
            // 
            this.avtobus1BindingSource.DataMember = "avtobus1";
            this.avtobus1BindingSource.DataSource = this.aeroDataSet1;
            // 
            // aeroDataSet1
            // 
            this.aeroDataSet1.DataSetName = "aeroDataSet1";
            this.aeroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtoTextBox
            // 
            this.avtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtobus1BindingSource, "avto", true));
            this.avtoTextBox.Location = new System.Drawing.Point(96, 53);
            this.avtoTextBox.Name = "avtoTextBox";
            this.avtoTextBox.Size = new System.Drawing.Size(145, 20);
            this.avtoTextBox.TabIndex = 14;
            // 
            // nomerTextBox
            // 
            this.nomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtobus1BindingSource, "nomer", true));
            this.nomerTextBox.Location = new System.Drawing.Point(96, 79);
            this.nomerTextBox.Name = "nomerTextBox";
            this.nomerTextBox.Size = new System.Drawing.Size(145, 20);
            this.nomerTextBox.TabIndex = 16;
            // 
            // mestaTextBox
            // 
            this.mestaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtobus1BindingSource, "mesta", true));
            this.mestaTextBox.Location = new System.Drawing.Point(96, 105);
            this.mestaTextBox.Name = "mestaTextBox";
            this.mestaTextBox.Size = new System.Drawing.Size(145, 20);
            this.mestaTextBox.TabIndex = 18;
            // 
            // avtobus1TableAdapter
            // 
            this.avtobus1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.avtobus1TableAdapter = this.avtobus1TableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.marshrut1TableAdapter = null;
            this.tableAdapterManager.reis1TableAdapter = null;
            this.tableAdapterManager.ticket1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VKR.aeroDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditeli1TableAdapter = null;
            // 
            // RedAvto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Name = "RedAvto";
            this.Text = "RedAvto";
            this.Load += new System.EventHandler(this.RedAvto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtobus1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private aeroDataSet1 aeroDataSet1;
        private System.Windows.Forms.BindingSource avtobus1BindingSource;
        private aeroDataSet1TableAdapters.avtobus1TableAdapter avtobus1TableAdapter;
        private aeroDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox avtoTextBox;
        private System.Windows.Forms.TextBox nomerTextBox;
        private System.Windows.Forms.TextBox mestaTextBox;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}