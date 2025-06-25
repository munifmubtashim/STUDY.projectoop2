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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;

namespace projectoop2
{
    public partial class Form2 : Form
    {
        private string _username;
        private string _role;


        public Form2(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
            _username = username;
            _role = role;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";
            LoadTotalPrice();
            LoadTotalrevenue();
            LoadTotalsuppliers();
            LoadTotalcustomers();
            LoadTotalPurchese();
            LoadTotalstock();
        }







        private void pn1TotalProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username, _role);
            products.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
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

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void LoadTotalPrice()
        {


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");

            string query = "SELECT SUM(Price) FROM Product";

            try
            {
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal total = Convert.ToDecimal(result);
                            label7.Text = $"{total:C}";
                        }
                        else
                        {
                            label7.Text = "Total: $0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label7.Text = "Error";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadTotalrevenue()
        {


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");

            string query = "SELECT SUM(Amount) FROM Sales";

            try
            {
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal total = Convert.ToDecimal(result);
                            label11.Text = $"{total:C}";
                        }
                        else
                        {
                            label11.Text = "Total: $0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label11.Text = "Error";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void LoadTotalsuppliers()
        {
            string connectionString = "Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(ID) FROM Supplier";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    int total = (int)cmd.ExecuteScalar();
                    label15.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void LoadTotalcustomers()
        {
            string connectionString = "Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(No) FROM Customer";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    int total = (int)cmd.ExecuteScalar();
                    label9.Text =   total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }
        private void LoadTotalstock()
        {

            string connectionString = "Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";
            string query = "SELECT SUM(Quantity) FROM Sales"; // Adjust "Stock" to your actual column name
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int totalStock = Convert.ToInt32(result);
                            label2.Text = $"Total Stock: {totalStock}";
                        }
                        else
                        {
                            label2.Text = "Total Stock: 0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label2.Text = "Error loading stock.";
                MessageBox.Show("Error: " + ex.Message);
            }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadTotalPurchese()
        {


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");

            string query = "SELECT SUM(Price) FROM Purchese";

            try
            {
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal total = Convert.ToDecimal(result);
                            label13.Text = $"{total:C}";
                        }
                        else
                        {
                            label13.Text = "Total: $0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                label7.Text = "Error";
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }





        }
