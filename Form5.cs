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

namespace projectoop2
{
    public partial class Form5: Form
    {
        private string _username;
        private string _role;
        public Form5(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form5_Load);
            _username = username;
            _role = role;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {
            
            string username = _username;
            string role = _role;
            Form2 Form2 = new Form2(username, role);
            Form2.Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
          
        }


        private void btnsales_Click_1(object sender, EventArgs e)
        {
            Form6 sales = new Form6(_username, _role);
            sales.Show();
            this.Hide();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            Form7 customers = new Form7(_username, _role);
            customers.Show();
            this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            Form8 suppliers = new Form8(_username, _role);
            suppliers.Show();
            this.Hide();
        }

        private void btnpurcheses_Click(object sender, EventArgs e)
        {
            Form9 purchese = new Form9(_username, _role);
            purchese.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Form10 settings = new Form10(_username, _role);
            settings.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout and go to the login page?",
        "Logout Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
         );

            if (result == DialogResult.Yes)
            {

                this.Hide();
                Form1 loginForm = new Form1(_username, _role);
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            string query = "SELECT * FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            string query = "INSERT INTO Product ([ID], [Name], [Catagory], [Quantity], [Price]) VALUES (@ID, @Name, @Catagory, @Quantity, @Price)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Catagory", textBox3.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", textBox5.Text);

            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Product added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }
        }
    }
}
