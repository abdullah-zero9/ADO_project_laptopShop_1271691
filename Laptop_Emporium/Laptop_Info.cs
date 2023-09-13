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
    public partial class laptop_Info : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=laptopDB;Trusted_Connection=True;");

        public laptop_Info()
        {
            InitializeComponent();
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }
        private void laptopInfo_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // Retrieve the last inserted laptop data from the laptops table
            cmd.CommandText = "SELECT TOP 1 laptop_id, name, brand FROM laptops ORDER BY laptop_id DESC";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtLaptopID.Text = reader["laptop_id"].ToString();
                txtName.Text = reader["name"].ToString();
                txtBrand.Text = reader["brand"].ToString();
            }
            reader.Close();

            // populate the processor combo box
            cmd.CommandText = "SELECT processor_id,name FROM processor";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            colprocessor.DataSource = ds.Tables[0];
            colprocessor.DisplayMember = "name";
            colprocessor.ValueMember = "processor_id";

            // populate the RAM combo box
            cmd.CommandText = "SELECT RamSize FROM Ram";
            DataSet dsRam = new DataSet();
            SqlDataAdapter sdaRam = new SqlDataAdapter(cmd);
            sdaRam.Fill(dsRam);
            cmbRam.DataSource = dsRam.Tables[0];
            cmbRam.DisplayMember = "RamSize";

            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Check if the laptop_id exists in the laptops table
                string checkCmdText = "SELECT COUNT(*) FROM laptops WHERE laptop_id = @laptop_id";
                SqlCommand checkCmd = new SqlCommand(checkCmdText, con);
                checkCmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("The specified laptop_id does not exist in the laptops table.", "Error");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO laptop_details(laptop_id, hard_disk, display_size, release_date, available, price, unit_stock) " +
                                        "VALUES (@laptop_id, @hard_disk, @display_size, @release_date, @available, @price, @unit_stock)";

                    // Set the parameter values
                    cmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                    cmd.Parameters.AddWithValue("@hard_disk", txtHDD.Text);
                    cmd.Parameters.AddWithValue("@display_size", "");
                    cmd.Parameters.AddWithValue("@release_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@available", chkAvailable.Checked);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@unit_stock", int.Parse(txtUnitStock.Text));

                    // Execute the insert command
                    cmd.ExecuteNonQuery();

                    // Show a success message box
                    MessageBox.Show("Data saved successfully!", "Success");
                }

            }
            catch (Exception ex)
            {
                // Show an error message box
                MessageBox.Show("An error occurred while saving data: " + ex.Message, "Error");
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }
    }
}
