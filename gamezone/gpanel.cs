using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake;
using gamezone;
using Microsoft.VisualBasic.PowerPacks;
using BrickOut;



namespace gamezone
{
    public partial class gpanel : Form
    {
        string nickname_g;
        public gpanel(string nickname_g)
        {
            
            InitializeComponent();
            nickname_indicator.Text = "Welcome  "+nickname_g;
            this.nickname_g = nickname_g;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Form1 fn = new Form1(nickname_g);
            fn.Show();
            this.Hide();
        }

        private void gpanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            snakeboard s1 = new snakeboard(nickname_g);
            s1.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ping p = new ping(nickname_g);
            p.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pingpongboard pb = new pingpongboard(nickname_g);
            pb.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
