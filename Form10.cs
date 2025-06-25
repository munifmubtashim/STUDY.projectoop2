using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoop2
{
    public partial class Form10: Form
    {
        private string _username;
        private string _role;
        public Form10(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form10_Load);
            _username = username;
            _role = role;
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";




        }
      


        

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            Form10 settings = new Form10(_username, _role);
            settings.Show();
            this.Hide();
        }

        private void btnpurcheses_Click_1(object sender, EventArgs e)
        {
            Form9 purchese = new Form9(_username, _role);
            purchese.Show();
            this.Hide();

        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {

            Form8 suppliers = new Form8(_username, _role);
            suppliers.Show();
            this.Hide();
        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            Form7 customers = new Form7(_username, _role);
            customers.Show();
            this.Hide();
        }

        private void btnsales_Click_1(object sender, EventArgs e)
        {
            Form6 sales = new Form6(_username, _role);
            sales.Show();
            this.Hide();

        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username, _role);
            products.Show();
            this.Hide();
        }

        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {
          
        
            
            Form2 Form2 = new Form2(_username,_role);
            Form2.Show();
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
                Form1 loginForm = new Form1(_username,_role);
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact us at:\n\nstoretrack@gmail.com", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True";
            string outputDirectory = @"C:\Backups\";

            // Table 1
            BackupTable(connectionString, "SELECT * FROM Customers", Path.Combine(outputDirectory, "Customers_Backup.csv"));

            // Table 2
            BackupTable(connectionString, "SELECT * FROM Sales", Path.Combine(outputDirectory, "Orders_Backup.csv"));

            // Table 3
            BackupTable(connectionString, "SELECT * FROM Product", Path.Combine(outputDirectory, "Products_Backup.csv"));
            // Table 4
            BackupTable(connectionString, "SELECT * FROM Supplier", Path.Combine(outputDirectory, "Suppliers_Backup.csv"));

            Console.WriteLine("✅ All hardcoded table backups completed.");
        }

        static void BackupTable(string connectionString, string query, string outputPath)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        // Write header
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader.GetName(i));
                            if (i < reader.FieldCount - 1) writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write rows
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var value = reader[i].ToString().Replace(",", " ");
                                writer.Write(value);
                                if (i < reader.FieldCount - 1) writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }

                    Console.WriteLine($"✅ Backup complete for: {outputPath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error in query '{query}': {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available , Right Now!!!", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chgpass changeForm = new chgpass();
            changeForm.ShowDialog();
            
        }
    
    }
    
    
}
