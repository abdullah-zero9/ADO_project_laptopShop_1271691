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
using System.Xml.Linq;

namespace Laptop_Emporium
{
    public partial class processor : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=laptopDB;Trusted_Connection=True;");
        public processor()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO processor(name) VALUES(@name)";
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data inserted successfully!");
                cmd.CommandText = "SELECT * FROM processor";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            con.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM processor";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
