
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
    public partial class Form1 : Form
    {
        private string _username;
        private string _role;
       
        public Form1(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Login_Load);
            _username = username;
            _role = role;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup Form4 = new Signup(_username,_role);
            Form4.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM Signup WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@Username", textusername.Text);
            cmd.Parameters.AddWithValue("@Password", textpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Successfull!!");

                Form2 Form2 = new Form2(_username, _role);
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!,Try again.");

            }

        }



private void Form1_Click(object sender, EventArgs e)
{

}

private void textusername_Click(object sender, EventArgs e)
{
    if (textusername.Text == " Username")
    {
        textusername.Clear();
        textusername.ForeColor = Color.Black;
    }



}

private void label5_Click(object sender, EventArgs e)
{

}

private void textusername_TextChanged(object sender, EventArgs e)
{
            
        }

private void label7_Click(object sender, EventArgs e)
{

}

private void textpassword_Click(object sender, EventArgs e)
{
    if (textpassword.Text == " Password")
    {
        textpassword.Clear();
        textpassword.UseSystemPasswordChar = true;
        textpassword.ForeColor = Color.Black;
    }



}

private void textpassword_TextChanged(object sender, EventArgs e)
{

}

private void pictureeye_Click(object sender, EventArgs e)
{

}

private void panel3_Click(object sender, EventArgs e)
{

}

#pragma warning disable CS8321 
private void pictureeye_MouseUp(object sender, MouseEventArgs e)
{
    textpassword.UseSystemPasswordChar = true;
}
#pragma warning restore CS8321 

private void pictureeye_MouseDown(object sender, MouseEventArgs e)
{
    textpassword.UseSystemPasswordChar = false;
}
    }
}
