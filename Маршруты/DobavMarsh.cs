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
    public partial class DobavMarsh : Form
    {
        public DobavMarsh()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "HH:mm";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //label8.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";
        public SD.DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Пункт отправления");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите Пункт назначения");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите цену");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите номер рейса");
                return;
            }

            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `reis1` (`number`, `otkuda`, `kuda`, `dateotp`, `timeotp`, `dateprib`, `timeprib`,`price`) VALUES (@number1, @otkuda1, @kuda1, @dateotp1 ,@timeotp1, @dateprib1, @timeprib1, @price1)", db.getConnection());
            command.Parameters.Add("@number1", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@otkuda1", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@kuda1", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.AddWithValue("dateotp1", dateTimePicker1.Value);
            command.Parameters.AddWithValue("timeotp1", dateTimePicker1.Value);
            command.Parameters.AddWithValue("dateprib1", dateTimePicker2.Value);
            command.Parameters.AddWithValue("timeprib1", dateTimePicker1.Value);
            command.Parameters.Add("@price1", MySqlDbType.VarChar).Value = textBox3.Text;
            command.ExecuteNonQuery();


            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DobavMarsh_Load(object sender, EventArgs e)
        {
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
