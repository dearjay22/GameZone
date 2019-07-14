using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Snake;
using gamezone;

namespace gamezone
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup f2 = new signup();
            f2.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nickname_h.Text == "") {
                MessageBox.Show("Enter The Nickname");
                return;
            }
            if (password_h.Text == "")
            {
                MessageBox.Show("Enter The password");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=gamezone;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();
           
            string nickname = nickname_h.Text;
            string password = password_h.Text;

            string q1 = "select * from signup where nickname='" + nickname + "' and password='" + password + "' ";


            SqlCommand cmdb = new SqlCommand(q1, con);
            SqlDataReader sr = cmdb.ExecuteReader();
            if (!sr.Read())
            {
                MessageBox.Show("Nickname OR Password Wrong !");
                return;
            }
            else {
               
                gpanel gp = new gpanel(nickname);
                gp.Show();
                this.Hide();
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
            this.Hide();
        }
    }
}
