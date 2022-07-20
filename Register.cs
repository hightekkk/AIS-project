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

namespace VKR
{
        public partial class Register : Form
        {
            public Register()
            {
                InitializeComponent();
            }
            public MySqlConnection connect2;
            public MySqlCommand connect1;
            public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

            public SD.DataSet ds;

            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите Логин");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите Пароль");
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Подтвердите пароль");
                    return;
                }


                DB db = new DB();
                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `admins` (`login`, `password`) VALUES (@login, @password)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox2.Text;

                command.ExecuteNonQuery();


                db.closeConnection();

                this.Close();
            }

            private void button1_MouseEnter(object sender, EventArgs e)
            {
                button1.BackColor = Color.LightGray;
            }

            private void button1_MouseLeave(object sender, EventArgs e)
            {
                button1.BackColor = Color.White;
            }
        }
}
