using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoop2
{
    public partial class Signup: Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void connect()
        {
            string connectionString = @"Data Source=DESKTOP-OCNS2DA\SQLEXPRESS;InitialCatalog=HUMSDb;Integrated Security=True";
            
            Catalog = HUMSDb; Integrated Security = True; Trust Server Certificate = True";
SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //string query = "INSERT INTO FACULTY VALUES(101,'SADIA','sadia@aiub.edu',50000.0,'CS')";
            string query = "INSERT INTO FACULTY VALUES('"+txtemail.Text+"', '"+txtpass.Text+"', +'"+txtusername.Text+"', '"+cboxacctype.Text+"')";
SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

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
    }
}
