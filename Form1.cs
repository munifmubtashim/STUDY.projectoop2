
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

        public Form1()
        {
            InitializeComponent();
       
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
            Signup Form4 = new Signup();
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

#pragma warning disable CS8321 // Local function is declared but never used
private void pictureeye_MouseUp(object sender, MouseEventArgs e)
{
    textpassword.UseSystemPasswordChar = true;
}
#pragma warning restore CS8321 // Local function is declared but never used

private void pictureeye_MouseDown(object sender, MouseEventArgs e)
{
    textpassword.UseSystemPasswordChar = false;
}
    }
}
