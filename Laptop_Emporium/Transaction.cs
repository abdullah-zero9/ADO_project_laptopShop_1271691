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
using System.Xml.Linq;

namespace Laptop_Emporium
{
    public partial class Transaction : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=laptopDB;Trusted_Connection=True;");
        public Transaction()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT processor_id,name FROM processor";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            colprocessor.DataSource = ds.Tables[0];
            colprocessor.DisplayMember = "name";
            colprocessor.ValueMember = "processor_id";

            // fill the RAM column with values from the RAM table
            cmd.CommandText = "SELECT RamSize FROM ram";
            ds = new DataSet();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            DataGridViewTextBoxColumn colRam = (DataGridViewTextBoxColumn)dataGridView1.Columns["colRam"];
            colRam.DataPropertyName = "RamSize";
            colRam.HeaderText = "RAM Capacity";

            con.Close();
        }

        private void btnSaveAll_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlTransaction ts = con.BeginTransaction();

                SqlCommand cmd = con.CreateCommand();
                cmd.Transaction = ts;
                cmd.CommandText = "INSERT INTO laptops (name, brand) VALUES (@name, @brand); SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                int laptopId = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["colprocessor"].Value != null && row.Cells["colRam"].Value != null)
                    {
                        int processorId = Convert.ToInt32(row.Cells["colprocessor"].Value);
                        string RAM = row.Cells["colRam"].Value?.ToString();

                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO RAM (laptop_id, processor_id, RamSize) VALUES (@laptop_id, @processor_id, @RamSize)";
                        cmd2.Parameters.AddWithValue("@laptop_id", laptopId);
                        cmd2.Parameters.AddWithValue("@processor_id", processorId);
                        cmd2.Parameters.AddWithValue("@RamSize", RAM);
                        cmd2.ExecuteNonQuery();
                    }
                }

                ts.Commit();
                MessageBox.Show("Data Inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nData is not saved!");
            }
            finally
            {
                con.Close();
            }

            ClearAll();

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM laptops", con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearAll()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["colRam"].Value = null;
                row.Cells["colprocessor"].Value = null;
            }
        }

        
    }
}