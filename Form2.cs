﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projectoop2
{
    public partial class Form2: Form
    { private string _username;
        private string _role;
        

        public Form2(string username,string role)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);
            _username = username;
            _role = role;
        }
        private void Form2_Load(object sender, EventArgs e)
        {  string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy");
            label1.Text = $"{_username} ({_role}) | {currentDateTime}";
           
          

            
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
            Form5 products = new Form5 (_username,_role);
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
    }
}
