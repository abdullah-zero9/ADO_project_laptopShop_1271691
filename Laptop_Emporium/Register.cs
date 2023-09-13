using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Emporium
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection
            /*("Server=DESKTOP-13;Database=laptopDB;Trusted_Connection=True;");*/
        ("Server=.;Database=laptopDB;Trusted_Connection=True;");
        public Register()
        {
            InitializeComponent();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found!!!");
            }
            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO users(userName,fullName,email,contactNo,userPassword) VALUES('" + txtUserName.Text + "','" + txtFullName.Text + "','" + txtEmail.Text + "','" + txtContactNo.Text + "','" + txtPassword.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
            LoadData();
        }
        private void ClearAll()
        {
            txtUserName.Text = "";
            txtFullName.Text = "";
            txtContactNo.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }
    }
}
