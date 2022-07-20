using System;
using MySql.Data.MySqlClient;
using SD = System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR
{
    public partial class RedMarsh : Form
    {
        public RedMarsh()
        {
            InitializeComponent();
            dateotpDateTimePicker.Format = DateTimePickerFormat.Custom;
            dateotpDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            datepribDateTimePicker.Format = DateTimePickerFormat.Custom;
            datepribDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //label2.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";
        public SD.DataSet ds;
        

        private void RedMarsh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.reis1". При необходимости она может быть перемещена или удалена.
            this.reis1TableAdapter.Fill(this.aeroDataSet1.reis1);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE reis1 SET number = @number, otkuda = @otkuda, " +
                "kuda = @kuda, dateotp = @dateotp, timeotp = @timeotp, dateprib = @dateprib, " +
                "timeprib = @timeprib, price = @price WHERE id_reisa = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = numberTextBox.Text;
            command.Parameters.Add("@otkuda", MySqlDbType.VarChar).Value = otkudaTextBox.Text;
            command.Parameters.Add("@kuda", MySqlDbType.VarChar).Value = kudaTextBox.Text;
            command.Parameters.AddWithValue("@dateotp", dateotpDateTimePicker.Value);
            command.Parameters.AddWithValue("@dateprib", datepribDateTimePicker.Value);
            command.Parameters.AddWithValue("@timeotp", timeotpDateTimePicker.Value);
            command.Parameters.AddWithValue("@timeprib", timepribDateTimePicker.Value);
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = priceTextBox.Text;

            command.ExecuteNonQuery();


            db.closeConnection();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void avtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void reis1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reis1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aeroDataSet1);

        }
    }
}
