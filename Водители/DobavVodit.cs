﻿using System;
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

namespace VKR.Водители
{
    public partial class DobavVodit : Form
    {
        public DobavVodit()
        {
            InitializeComponent();
        }
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";
        public SD.DataSet ds;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите Имя");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите Фамилию");
                return;
            }
           

            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `voditeli1` (`name`, `lastname`, `passport`) VALUES (@first, @last, @pp)", db.getConnection());
            command.Parameters.Add("@first", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@last", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = textBox3.Text;

            command.ExecuteNonQuery();


            db.closeConnection();
        }
    }
}
