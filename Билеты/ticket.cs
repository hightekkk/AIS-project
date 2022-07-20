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
using System.Data.Common;
using System.Data.SqlClient;

namespace VKR.Билеты
{
    public partial class ticket : Form
    {
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

        public SD.DataSet ds;

        public ticket()
        {
            InitializeComponent();
            
        }
        //public Ticket()
        //{

        //}

        private void ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.reis1". При необходимости она может быть перемещена или удалена.
            this.reis1TableAdapter.Fill(this.aeroDataSet1.reis1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.ticket1". При необходимости она может быть перемещена или удалена.
            this.ticket1TableAdapter.Fill(this.aeroDataSet1.ticket1);
            DB db = new DB();
            db.openConnection();
            label5.Text = "";
            mestostLabel1.Text = "";
            MySqlCommand command = new MySqlCommand("SELECT ticket1.id_ticket, ticket1.id_mar, " +
                "ticket1.mesto AS 'Место', ticket1.last_name AS 'Фамилия', ticket1.first_name AS 'Имя', ticket1.email AS 'Почта', marshrut1.id_marsh, marshrut1.id_reis, reis1.id_reisa, reis1.number AS 'Номер рейса' " +
                "FROM ticket1, marshrut1, reis1  WHERE ticket1.id_mar = marshrut1.id_marsh AND marshrut1.id_reis = reis1.id_reisa", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("ticket1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;



            MySqlCommand command1 = new MySqlCommand("SELECT ticket1.id_ticket, ticket1.id_mar, " +
                "ticket1.mesto AS 'Место', ticket1.last_name AS 'Фамилия', ticket1.first_name AS 'Имя', ticket1.email AS 'Почта', marshrut1.id_marsh, marshrut1.id_reis, reis1.id_reisa, reis1.number AS 'Номер рейса', ticket1.status " +
                "FROM ticket1, marshrut1, reis1  WHERE ticket1.id_mar = marshrut1.id_marsh AND marshrut1.id_reis = reis1.id_reisa AND ticket1.status = 1", db.getConnection());
            command1.ExecuteNonQuery();
            MySqlDataAdapter dataAdp1 = new MySqlDataAdapter(command1);
            DataTable ds1 = new DataTable("ticket2");
            dataAdp1.Fill(ds1);
            dataGridView2.DataSource = ds1.DefaultView;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[10].Visible = false;


            MySqlCommand command2 = new MySqlCommand("SELECT marshrut1.id_marsh, marshrut1.status, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия', " +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя', marshrut1.description AS 'Причина' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND marshrut1.status = 'Отменён'", db.getConnection());
            command2.ExecuteNonQuery();
            MySqlDataAdapter dataAdp2 = new MySqlDataAdapter(command2);
            DataTable ds2 = new DataTable("ticket3");
            dataAdp2.Fill(ds2);
            dataGridView3.DataSource = ds2.DefaultView;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            db.closeConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void mestostLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT ticket1.id_ticket, ticket1.id_mar, " +
                "ticket1.mesto, ticket1.last_name, ticket1.first_name, ticket1.email, marshrut1.id_marsh, " +
                "marshrut1.id_reis, reis1.id_reisa, reis1.number " +
                "FROM ticket1, marshrut1, reis1  WHERE ticket1.id_mar = marshrut1.id_marsh AND " +
                "marshrut1.id_reis = reis1.id_reisa AND reis1.number = " + comboBox1.Text + "", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("ticket1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            MySqlCommand command1 = new MySqlCommand("SELECT reis1.price FROM reis1 WHERE reis1.number = '" + comboBox1.Text + "'", db.getConnection());
            command1.ExecuteNonQuery();
            
        
            int rows = dataGridView1.Rows.Count;
            
            mestostLabel1.Text = rows.ToString();
            int a = Convert.ToInt32(command1.ExecuteScalar()) * Convert.ToInt32(rows);
            label5.Text = a.ToString();
            db.closeConnection();
        }

        private void mestostLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
