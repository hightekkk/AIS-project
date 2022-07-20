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
    public partial class RedAvto : Form
    {
        public RedAvto()
        {
            InitializeComponent();
        }
        public MySqlConnection connect2;
        public MySqlCommand connect1;
        public string connect = "server = 81.90.181.100; port=3306;username=hightekk;password=Aa9346936;database=aero";

        public SD.DataSet ds;

        private void RedAvto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aeroDataSet1.avtobus1". При необходимости она может быть перемещена или удалена.
            this.avtobus1TableAdapter.Fill(this.aeroDataSet1.avtobus1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE avtobus1 SET avto = @avt, mesta = @mesta, nomer = @nomer WHERE id_avto = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@avt", MySqlDbType.VarChar).Value = avtoTextBox.Text;
            command.Parameters.Add("@mesta", MySqlDbType.VarChar).Value = mestaTextBox.Text;
            command.Parameters.Add("@nomer", MySqlDbType.VarChar).Value = nomerTextBox.Text;
            command.ExecuteNonQuery();


            db.closeConnection();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
