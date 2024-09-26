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

namespace igsit
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This section has not been developed yet ...");
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            using (conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM T_Login WHERE UserName=@Username AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");
                        Form Form1 = new Form1();
                        Form1.ShowDialog();
                        this.Hide();
                        Form1.WindowState = FormWindowState.Maximized;
                        
                    }
                    else
                    {
                        txtuser.Focus();
                        MessageBox.Show("Username or Password is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '●';
        }



        //private void txtpass_MouseHover(object sender, EventArgs e)
        //{
        //    txtpass.PasswordChar = '\0';
        //}
    }
}
