﻿using System;
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
    public partial class Form7: Form
    {
        private string _username;
        private string _role;
        public Form7(string username, string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form7_Load);
            _username = username;
            _role = role;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";




        }

        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(_username, _role);
            Form2.Show();
            this.Hide();
        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            Form5 products = new Form5(_username, _role);
            products.Show();
            this.Hide();
        }

        private void btnsales_Click_1(object sender, EventArgs e)
        {
            Form6 sales = new Form6(_username, _role);
            sales.Show();
            this.Hide();
        }

        private void btncustomers_Click_1(object sender, EventArgs e)
        {
            Form7 customers = new Form7(_username, _role);
            customers.Show();
            this.Hide();
        }

        private void btnsuppliers_Click_1(object sender, EventArgs e)
        {
            Form8 suppliers = new Form8(_username, _role);
            suppliers.Show();
            this.Hide();
        }

        private void btnpurcheses_Click_1(object sender, EventArgs e)
        {

            Form9 purchese = new Form9(_username, _role);
            purchese.Show();
            this.Hide();
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            Form10 settings = new Form10(_username, _role);
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
                Form1 loginForm = new Form1(_username, _role);
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

                Application.Exit();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
