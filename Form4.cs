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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace projectoop2
{
    public partial class Signup: Form
    {
        private string connectionString;

        public Signup()
        {
            InitializeComponent();
        }
    


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void piceye_Click(object sender, EventArgs e)
        {

        }

        private void piceye_MouseUp(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            txtconpass.UseSystemPasswordChar = true;
        }

        private void piceye_MouseDown(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            txtconpass.UseSystemPasswordChar = false;
        }

        private void lbllogin_Click_1(object sender, EventArgs e)
        {

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Signup VALUES (@Email,@Password,@Username,@[Account Type],@Gender,@[Date of Birth])";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            cmd.Parameters.AddWithValue("@[Account Type]", cboxacctype.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender", lblgender.Text);
            cmd.Parameters.AddWithValue("@[Date of Birth]", dtb.Value);
            cmd.ExecuteNonQuery();



        }
    }
}
