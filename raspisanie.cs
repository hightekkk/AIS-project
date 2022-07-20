using MySql.Data.MySqlClient;
using System;
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
    public partial class raspisanie : Form
    {
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

        public SD.DataSet ds;
        public raspisanie()
        {
            InitializeComponent();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            
            MySqlCommand command = new MySqlCommand("DELETE FROM marshrut1 WHERE id_marsh = @idd", db.getConnection());
            command.Parameters.AddWithValue("@idd", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void raspisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.voditeli1". При необходимости она может быть перемещена или удалена.
            this.voditeli1TableAdapter.Fill(this.aeroDataSet1.voditeli1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.avtobus1". При необходимости она может быть перемещена или удалена.
            this.avtobus1TableAdapter.Fill(this.aeroDataSet1.avtobus1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.reis1". При необходимости она может быть перемещена или удалена.
            this.reis1TableAdapter.Fill(this.aeroDataSet1.reis1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `marshrut1` (`id_reis`, `id_avt`, `id_vod`) VALUES (@id,@avto,@vodit)", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = comboBox1.SelectedValue;
            command.Parameters.Add("@avto", MySqlDbType.VarChar).Value = comboBox2.SelectedValue;
            command.Parameters.Add("@vodit", MySqlDbType.VarChar).Value = comboBox3.SelectedValue;
            command.ExecuteNonQuery();

        }

        private void reis1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            //string sql = "SELECT Zac.NumProt, Zac.Familia, Zac.Name, Zac.FirstName, Zac.Mesto, Zac.NameProb, Zac.DataPost, Zac.DataProv, Zac.Object  FROM Zac " +
            //        "WHERE  (Zac.NumProt = '" + zacListBox.Text + "' AND Zac.IdZac = '" + zacListBox.SelectedValue.ToString() + "')";
            ////Vod(sql);
            //comm.CommandText = sql;
            //comm.Connection.Open();
            //SqlDataReader da = comm.ExecuteReader();
            //while (da.Read())
            //{
            //    textBox1.Text = "Номер протокола - " + da.GetValue(0).ToString() + "\r\n"
            //        + "Заказчик - " + da.GetValue(1).ToString() + " "
            //        + da.GetValue(2).ToString()
            //        + da.GetValue(3).ToString() + "\r\n"
            //        + "Место отбора - " + da.GetValue(4).ToString() + "\r\n"
            //        + "Наименование пробы - " + da.GetValue(5).ToString() + "\r\n"
            //        + "Дата поступления пробы - " + da.GetValue(6).ToString() + "\r\n"
            //        + "Дата проведения анализа - " + da.GetValue(7).ToString() + "\r\n"
            //        + "Цель отбора - " + da.GetValue(8).ToString();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, reis1.number, reis1.otkuda, reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия', avtobus1.avto AS 'Автобус', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.number = " + comboBox1.Text + "", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;


            MySqlDataReader da = command.ExecuteReader();
            
                while (da.Read())
                {
                    textBox1.Text = "Номер рейса - " + da.GetValue(4).ToString() + "\r\n"
                        + "Пункт отправления - " + da.GetValue(5).ToString() + "\r\n"
                        + "Пункт прибытия - " + da.GetValue(6).ToString() + "\r\n"
                        + "Дата отправления - " + da.GetMySqlDateTime(7).ToString() + "\r\n"
                        + "Время отправления - " + da.GetValue(8).ToString() + "\r\n"
                        + "Дата прибытия - " + da.GetMySqlDateTime(9).ToString() + "\r\n"
                        + "Время прибытия - " + da.GetValue(10).ToString();


                }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            db.closeConnection();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.number = " + comboBox4.Text + "", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            db.closeConnection();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda, reis1.kuda, reis1.dateotp, reis1.timeotp, reis1.dateprib, reis1.timeprib," +
                "avtobus1.avto, voditeli1.lastname FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.dateotp = " + dateTimePicker1.Value + "", db.getConnection());
            command.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            db.closeConnection();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda, reis1.kuda, reis1.dateotp, reis1.timeotp, reis1.dateprib, reis1.timeprib," +
                "avtobus1.avto, voditeli1.lastname FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.otkuda = " + textBox3.Text + "", db.getConnection());
            command1.ExecuteNonQuery();
            MySqlDataAdapter dataAdp = new MySqlDataAdapter(command1);
            DataTable ds = new DataTable("marshrut1");
            dataAdp.Fill(ds);
            dataGridView1.DataSource = ds.DefaultView;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[8].Visible = false;
            db.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите причину отмены");
                return;
            }
            DB db = new DB();
            db.openConnection();
            MySqlCommand command2 = new MySqlCommand("UPDATE marshrut1 SET status = 'Отменён', description = @descr WHERE id_marsh = @idd1", db.getConnection());
            command2.Parameters.Add("@descr", MySqlDbType.VarChar).Value = textBox2.Text;
            command2.Parameters.AddWithValue("@idd1", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            command2.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                DB db = new DB();
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.otkuda = '" + textBox3.Text + "'", db.getConnection());
                command1.ExecuteNonQuery();
                MySqlDataAdapter dataAdp1 = new MySqlDataAdapter(command1);
                DataTable ds1 = new DataTable("marshrut2");
                dataAdp1.Fill(ds1);
                dataGridView1.DataSource = ds1.DefaultView;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                db.closeConnection();
            }
            if (textBox3.Text == "")
            {
                DB db = new DB();
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.kuda = '" + textBox4.Text + "'", db.getConnection());
                command1.ExecuteNonQuery();
                MySqlDataAdapter dataAdp1 = new MySqlDataAdapter(command1);
                DataTable ds1 = new DataTable("marshrut2");
                dataAdp1.Fill(ds1);
                dataGridView1.DataSource = ds1.DefaultView;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                db.closeConnection();
            }
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                DB db = new DB();
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT marshrut1.id_marsh, reis1.id_reisa, avtobus1.id_avto, voditeli1.id, " +
                "reis1.number AS 'Номер рейса', reis1.otkuda AS 'Пункт отправления', reis1.kuda AS 'Пункт прибытия', reis1.dateotp AS 'Дата отправления', reis1.timeotp AS 'Время отправления', reis1.dateprib AS 'Дата прибытия', reis1.timeprib AS 'Время прибытия'," +
                "avtobus1.avto AS 'Модель автобуса', voditeli1.lastname AS 'Фамилия водителя' FROM avtobus1, marshrut1, reis1, voditeli1 WHERE marshrut1.id_reis = reis1.id_reisa AND marshrut1.id_avt = avtobus1.id_avto AND marshrut1.id_vod = voditeli1.id AND reis1.kuda = '" + textBox4.Text + "' AND reis1.otkuda = '" + textBox3.Text + "'", db.getConnection());
                command1.ExecuteNonQuery();
                MySqlDataAdapter dataAdp1 = new MySqlDataAdapter(command1);
                DataTable ds1 = new DataTable("marshrut2");
                dataAdp1.Fill(ds1);
                dataGridView1.DataSource = ds1.DefaultView;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                //dataGridView1.Columns[8].Visible = false;
                db.closeConnection();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StartForm f = new StartForm();
            f.Show();
            this.Close();
        }
    }
}
