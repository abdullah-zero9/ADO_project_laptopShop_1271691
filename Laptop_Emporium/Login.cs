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
using Microsoft.Win32;

namespace Laptop_Emporium
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=laptopDB;Trusted_Connection=True;");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users where userName='" + txtUserName.Text + "' and userPassword='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Home fm = new Home();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or password!!!");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register fr = new Register();
            fr.Show();
        }
    }
}
