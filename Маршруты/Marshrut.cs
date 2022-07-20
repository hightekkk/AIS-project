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

namespace VKR.Маршруты
{
    public partial class Marshrut : Form
    {
        public Marshrut()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";
        public SD.DataSet ds;

        private void Marshrut_Load(object sender, EventArgs e)
        {
            this.reis1TableAdapter.Fill(this.aeroDataSet1.reis1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.reis1TableAdapter.Fill(this.aeroDataSet1.reis1);
            }
            catch
            {
                MessageBox.Show("Ошибка, База данных не подключена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DobavMarsh form = new DobavMarsh();
            form.Show();           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM marshrut1 WHERE id_reis = @idd1", db.getConnection());
            command.Parameters.AddWithValue("@idd1", reis1DataGridView.CurrentRow.Cells[0].Value.ToString());

            MySqlCommand command1 = new MySqlCommand("DELETE FROM reis1 WHERE id_reisa = @idd", db.getConnection());
            command1.Parameters.AddWithValue("@idd", MySqlDbType.VarChar).Value = reis1DataGridView.CurrentRow.Cells[0].Value.ToString();
            command1.ExecuteNonQuery();
            db.closeConnection();

            db.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            RedMarsh form = new RedMarsh();
            form.Show();
            string d = reis1DataGridView.CurrentRow.Cells[0].Value.ToString();
            form.comboBox1.Text = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://s226348.h1n.ru");
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
    
}
