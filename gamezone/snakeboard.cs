﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gamezone
{
    public partial class snakeboard : Form
    {
        string nickname_ss;
        public snakeboard(string nickname_ss)
        {
            InitializeComponent();
            this.nickname_ss = nickname_ss;
        }

        private void snakeboard_Load(object sender, EventArgs e)
        {
            // database part of scoreboard (staring ....)

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=gamezone;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            con.Open();

           //  for nickname in a score board
            string query = "select nickname from snakeboard order by score desc";
            SqlCommand cmdf = new SqlCommand(query,con);

            SqlDataReader sr3 = cmdf.ExecuteReader();

            int x = 0;
            while (sr3.Read()) {
                if (x == 0) {
                    n1.Text = sr3["nickname"].ToString();
                }
                if (x == 1)
                {
                    n2.Text = sr3["nickname"].ToString();
                }
                if (x == 2)
                {
                    n3.Text = sr3["nickname"].ToString();
                }
                x++;
                
            }
            sr3.Close();


            //for score in a score board
            string query1 = "select score from snakeboard order by score desc";
            SqlCommand cmdg = new SqlCommand(query1, con);

            SqlDataReader sr4 = cmdg.ExecuteReader();

            int y = 0;
            while (sr4.Read())
            {
                if (y == 0)
                {
                    s1.Text = sr4["score"].ToString();
                }
                if (y == 1)
                {
                    s2.Text = sr4["score"].ToString();
                }
                if (y == 2)
                {
                    s3.Text = sr4["score"].ToString();
                }
                y++;

            }
            sr4.Close();

            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            gpanel gb = new gpanel(nickname_ss);
            gb.Show();
            this.Close();
        }
    }
}
