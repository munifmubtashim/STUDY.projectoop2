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
    }
}
