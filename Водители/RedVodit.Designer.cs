namespace VKR.Водители
{
    partial class RedVodit
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label passportLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voditeli1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroDataSet1 = new VKR.aeroDataSet1();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.voditeli1TableAdapter = new VKR.aeroDataSet1TableAdapters.voditeli1TableAdapter();
            this.tableAdapterManager = new VKR.aeroDataSet1TableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voditeli1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(57, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 9;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(48, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Имя:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(25, 105);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(59, 13);
            lastnameLabel.TabIndex = 13;
            lastnameLabel.Text = "Фамилия:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(25, 131);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(53, 13);
            passportLabel.TabIndex = 15;
            passportLabel.Text = "Паспорт:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(143, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Редактирование водителей";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(lastnameLabel);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Controls.Add(passportLabel);
            this.groupBox1.Controls.Add(this.passportTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(30, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.voditeli1BindingSource;
            this.comboBox1.DisplayMember = "id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Visible = false;
            // 
            // voditeli1BindingSource
            // 
            this.voditeli1BindingSource.DataMember = "voditeli1";
            this.voditeli1BindingSource.DataSource = this.aeroDataSet1;
            // 
            // aeroDataSet1
            // 
            this.aeroDataSet1.DataSetName = "aeroDataSet1";
            this.aeroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voditeli1BindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voditeli1BindingSource, "lastname", true));
            this.lastnameTextBox.Location = new System.Drawing.Point(90, 102);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 14;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voditeli1BindingSource, "passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(90, 128);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportTextBox.TabIndex = 16;
            // 
            // voditeli1TableAdapter
            // 
            this.voditeli1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminsTableAdapter = null;
            this.tableAdapterManager.avtobus1TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.marshrut1TableAdapter = null;
            this.tableAdapterManager.reis1TableAdapter = null;
            this.tableAdapterManager.ticket1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VKR.aeroDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditeli1TableAdapter = this.voditeli1TableAdapter;
            // 
            // RedVodit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RedVodit";
            this.Text = "RedVodit";
            this.Load += new System.EventHandler(this.RedVodit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voditeli1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private aeroDataSet1 aeroDataSet1;
        private System.Windows.Forms.BindingSource voditeli1BindingSource;
        private aeroDataSet1TableAdapters.voditeli1TableAdapter voditeli1TableAdapter;
        private aeroDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}