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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=gamezone;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            if (nickname_r.Text == "") {
                MessageBox.Show("Please type unique NickName !");
                return;
            }
            con.Open();
            string a = nickname_r.Text;
            string q1 = "select * from signup where nickname='" + a + "'";


            SqlCommand cmda = new SqlCommand(q1, con);
            SqlDataReader sr = cmda.ExecuteReader();
            if (sr.Read())
            {
                MessageBox.Show("This Nickname is Already choosen ! please select unique nickname  ! ");
                return;
            }
            con.Close();
            if (email_r.Text == "") {
                MessageBox.Show("Please type your email !");
                return;
            }
            if (password_r.Text == "") {
                MessageBox.Show("Please type your password !");
                return;
            }
            if (password_r.Text != cpassword_r.Text) {
                MessageBox.Show("Both Password does not match with each other !");
                return;
            }
                    string query = "insert into signup(nickname,email,password) values('"+nickname_r.Text+"','"+email_r.Text+"','"+password_r.Text+"')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() != 0) {
                        MessageBox.Show("Account Successfully created  ! ");
                        nickname_r.Clear();
                        email_r.Clear();
                        password_r.Clear();
                        cpassword_r.Clear();
                    }
                    con.Close();
                    login l = new login();
                    l.Show();
                    this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            f1.Show();
            this.Hide();
        }
    }
}
