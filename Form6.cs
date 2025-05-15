using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoop2
{
    public partial class Form6 : Form
    {

        private string _username;
        private string _role;
        public Form6(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form6_Load);
            _username = username;
            _role = role;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";




        }

        private void Dashboardbutton_Click(object sender, EventArgs e)
        {
            string username = _username;
            string role = _role;
            Form2 Form2 = new Form2(username, role);
            Form2.Show();
            this.Hide();
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username, _role);
            products.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {

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
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }
    }   
}
