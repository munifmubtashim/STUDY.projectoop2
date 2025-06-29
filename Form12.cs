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
    public partial class Form12 : Form
    {
        public string _username;
        public Form12(string username)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form12_Load);
            _username = username;
        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {

            Form2 Form2 = new Form2(_username);
            Form2.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username}  | {currentDateTime}";
            ShowTotalProfit();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username);
            products.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            Form6 sales = new Form6(_username);
            sales.Show();
            this.Hide();

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            Form7 customers = new Form7(_username);
            customers.Show();
            this.Hide();
        }

        private void btnsuppliers_Click(object sender, EventArgs e)
        {
            Form8 suppliers = new Form8(_username);
            suppliers.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Form10 settings = new Form10(_username);
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
                Form1 loginForm = new Form1(_username);
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }

        private void btnpurcheses_Click(object sender, EventArgs e)
        {
            Form9 purchese = new Form9(_username);
            purchese.Show();
            this.Hide();
        }
        private void ShowTotalProfit()
        {
            string connectionString = "Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";

            decimal totalCost = 0;
            decimal totalRevenue = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Query 1: Total Cost from Product table
                string costQuery = "SELECT SUM(Price) FROM Product";
                SqlCommand costCmd = new SqlCommand(costQuery, conn);
                object costResult = costCmd.ExecuteScalar();
                totalCost = costResult != DBNull.Value ? Convert.ToDecimal(costResult) : 0;

                // Query 2: Total Revenue from Sales table
                string revenueQuery = "SELECT SUM(Amount) FROM Sales";
                SqlCommand revenueCmd = new SqlCommand(revenueQuery, conn);
                object revenueResult = revenueCmd.ExecuteScalar();
                totalRevenue = revenueResult != DBNull.Value ? Convert.ToDecimal(revenueResult) : 0;

                conn.Close();
            }

            // Calculate Profit
            decimal totalProfit = totalRevenue - totalCost;

            // Show in Label
            label11.Text = $"{totalProfit:C}";

            // Show in Chart
            ShowChart(totalCost, totalRevenue, totalProfit);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void ShowChart(decimal totalCost, decimal totalRevenue, decimal totalProfit)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Profit Summary");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Values");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            series.Points.AddXY("Total Cost", totalCost);
            series.Points.AddXY("Total Revenue", totalRevenue);
            series.Points.AddXY("Total Profit", totalProfit);

            chart1.Series.Add(series);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
