
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string gender = "";
            if(rbmale.Checked)
            {                 gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender= "Female";
            }
            else 
            {
                MessageBox.Show("Select Gender");
            }
            string connectionString = @"Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "INSERT INTO Signup ([Email], [Password], [Username], [AccountType], [Gender], [DateofBirth]) VALUES (@Email, @Password, @Username, @AccountType, @Gender, @DateOfBirth)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Password", txtpass.Text);
            cmd.Parameters.AddWithValue("@Username", txtusername.Text);
            cmd.Parameters.AddWithValue("@AccountType", cboxacctype.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@DateofBirth", dtb.Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sign up Successfull!");
            Form1 login = new Form1();
            login.Show();
            this.Hide();



        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtconpass.Text))
            {
                lblerror.Visible= false;
            }
            else if (txtpass.Text == txtconpass.Text)
            {
                lblerror.Visible = false;
            }
            else
            {
                lblerror.Visible = true;
            }
        }
    }
}
