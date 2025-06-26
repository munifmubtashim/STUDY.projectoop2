using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoop2
{
    public partial class Form9: Form
    {

        public string _username;
        
        public Form9(string username)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form9_Load);
            _username = username;
            
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username}  | {currentDateTime}";

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            string query = "SELECT * FROM Purchese";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;



        }
       

        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(_username);
            Form2.Show();
            this.Hide();
        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username);
            products.Show();
            this.Hide();
        }

        private void btnsales_Click_1(object sender, EventArgs e)
        {
            Form6 sales = new Form6(_username);
            sales.Show();
            this.Hide();

        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            Form7 customers = new Form7(_username);
            customers.Show();
            this.Hide();
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            Form8 suppliers = new Form8(_username);
            suppliers.Show();
            this.Hide();
        }

        private void btnpurcheses_Click_1(object sender, EventArgs e)
        {

           

        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            Form10 settings = new Form10(_username);
            settings.Show();
            this.Hide();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout and go to the login page?",
          "Logout Confirmation",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {

                this.Hide();
                Form1 loginForm = new Form1(_username);
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
         
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void pbrefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            string query = "SELECT * FROM Purchese";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            string query = "INSERT INTO Purchese ([ID], [Supplier],[Date], [Product],[Price]) VALUES (@ID, @Supplier, @Date, @Product,@Price)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Supplier", textBox2.Text);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Product", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));



            cmd.ExecuteNonQuery();
            MessageBox.Show("Purchese details added Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            try
            {
                conn.Open();
                string query = "UPDATE Purchese SET Supplier='" + textBox2.Text + "',Product='" + textBox4.Text + "',Price='" + textBox5.Text + "' where ID=" + textBox1.Text;



                SqlCommand cmd = new SqlCommand(query, conn);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Write the currect ID " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string q = "select * from Purchese where ID  LIKE '" + textBox6.Text + "%' " +
                "OR Supplier LIKE '" + textBox6.Text + "%'" +
                "OR Product LIKE '" + textBox6.Text + "%'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 profit = new Form12(_username);
            profit.Show();
            this.Hide();
        }
    }
}
