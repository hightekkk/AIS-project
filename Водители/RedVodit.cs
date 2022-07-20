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

namespace VKR.Водители
{
    public partial class RedVodit : Form
    {
        public RedVodit()
        {
            InitializeComponent();
        }
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";
        public SD.DataSet ds;

        private void RedVodit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.voditeli1". При необходимости она может быть перемещена или удалена.
            this.voditeli1TableAdapter.Fill(this.aeroDataSet1.voditeli1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE voditeli1 SET name = @first, lastname = @last, passport = @pp WHERE id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@first", MySqlDbType.VarChar).Value = nameTextBox.Text;
            command.Parameters.Add("@last", MySqlDbType.VarChar).Value = lastnameTextBox.Text;
            command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = passportTextBox.Text;
            command.ExecuteNonQuery();


            db.closeConnection();
        }
    }
}
