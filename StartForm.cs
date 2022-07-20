using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data;

namespace VKR
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            Водители.voditeli form = new Водители.voditeli();
            form.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Маршруты.Marshrut form = new Маршруты.Marshrut();
            form.Show();
            //this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Билеты.ticket form = new Билеты.ticket();
            form.Show();
            //this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://s226348.h1n.ru");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Автобус.Avtobuss form = new Автобус.Avtobuss();
            form.Show();
            //this.Close();
        }
    }
}
