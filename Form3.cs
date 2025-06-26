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
    public partial class wlc: Form
    {
        public string _username;
        
        public wlc(string username)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form3_Load);
            _username = username;
            
        }

     

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1(_username);
            Form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
