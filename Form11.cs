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
using System.Diagnostics.Eventing.Reader;

namespace projectoop2
{
    public partial class chgpass: Form
    {
        public chgpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1V76GGV;Initial Catalog=HUMSDb;Integrated Security=True");
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Signup WHERE Username=@Username AND Password=@OldPassword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@OldPassword", oldPassword);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    string updateQuery = "UPDATE Signup SET Password=@NewPassword WHERE Username=@Username";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@Username", username);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void piceye_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtOldPassword.UseSystemPasswordChar = true;

            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void piceye_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
            txtOldPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)|| txtNewPassword.Text == txtConfirmPassword.Text)
            {
                lblerror.Visible = false;
            }
            
            else
            {
                lblerror.Visible = true;
            }

        }
       
        private void chgpass_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }
    }
    }

