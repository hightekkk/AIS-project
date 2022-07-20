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

namespace VKR.Автобус
{
    public partial class Avtobuss : Form
    {
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

        public SD.DataSet ds;

        private void Avtobuss_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.avtobus1". При необходимости она может быть перемещена или удалена.
            this.avtobus1TableAdapter.Fill(this.aeroDataSet1.avtobus1);


        }

        private void button2_Click(object sender, EventArgs e)//dobavit
        {
            Автобус.DobavAvto form = new Автобус.DobavAvto();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)//redak
        {
            Автобус.RedAvto form = new Автобус.RedAvto();
            form.Show();
            string d = avtobus1DataGridView.CurrentRow.Cells[0].Value.ToString();
            form.comboBox1.Text = d;
        }

        private void button3_Click(object sender, EventArgs e)//delet
        {
            /*CurrentCell.Value.ToString()*/
            label2.Text = avtobus1DataGridView.CurrentRow.Cells[0].Value.ToString();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM marshrut1 WHERE id_avt = @idd1", db.getConnection());
            command.Parameters.AddWithValue("@idd1", label2.Text);

            MySqlCommand command1 = new MySqlCommand("DELETE FROM avtobus1 WHERE id_avto = @idd", db.getConnection());
            command1.Parameters.AddWithValue("@idd", MySqlDbType.VarChar).Value = label2.Text;
            command1.ExecuteNonQuery();
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e) //obnov
        {
            try
            {
                this.avtobus1TableAdapter.Fill(this.aeroDataSet1.avtobus1);
            }
            catch
            {
                MessageBox.Show("Ошибка, База данных не подключена");
            }
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

        public Avtobuss()
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://s226348.h1n.ru");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
