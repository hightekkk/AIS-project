using MySql.Data.MySqlClient;
using SD = System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKR.Водители
{
    public partial class voditeli : Form
    {
        public voditeli()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

        public SD.DataSet ds;

        private void voditeli_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.voditeli1". При необходимости она может быть перемещена или удалена.
            this.voditeli1TableAdapter.Fill(this.aeroDataSet1.voditeli1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.voditeli1TableAdapter.Fill(this.aeroDataSet1.voditeli1);
            }
            catch
            {
                MessageBox.Show("Ошибка, База данных не подключена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Водители.DobavVodit form = new Водители.DobavVodit();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Водители.RedVodit form = new Водители.RedVodit();
            form.Show();
            string d = voditeli1DataGridView.CurrentRow.Cells[0].Value.ToString();
            form.comboBox1.Text = d;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            //MySqlCommand command1 = new MySqlCommand("DELETE FROM marshrut1 WHERE id_vod = @idd1", db.getConnection());
            //command1.Parameters.AddWithValue("@idd1", voditeli1DataGridView.CurrentCell.Value.ToString());

            MySqlCommand command = new MySqlCommand("DELETE FROM voditeli1 WHERE id = @idd", db.getConnection());
            command.Parameters.AddWithValue("@idd", MySqlDbType.VarChar).Value = voditeli1DataGridView.CurrentRow.Cells[0].Value.ToString();
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://s226348.h1n.ru");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartForm f = new StartForm();
            f.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
