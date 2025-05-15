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

        private void Dashboardbutton_Click(object sender, EventArgs e)
        { string username = _username;
            string role = _role;    
            Form2 Form2= new Form2(username,role);
            Form2.Show();
            this.Hide();
        }
    }
}
