using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Emporium
{
    public partial class Update_Delete : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=laptopDB;Trusted_Connection=True;");
        public Update_Delete()
        {
            InitializeComponent();
        }
        private void Update_Delete_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Retrieve the last inserted laptop data from the laptops table
                cmd.CommandText = "SELECT TOP 1 laptop_id, name, brand, picture FROM laptops ORDER BY laptop_id DESC";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtLaptopID.Text = reader["laptop_id"].ToString();
                    txtName.Text = reader["name"].ToString();
                    txtBrand.Text = reader["brand"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("picture")))
                    {
                        byte[] imgData = (byte[])reader["picture"];
                        MemoryStream ms = new MemoryStream(imgData);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                reader.Close();

                // Retrieve the laptop details for the last inserted laptop id
                cmd.CommandText = "SELECT hard_disk, display_size, release_date, available, price, unit_stock, picture " +
                                    "FROM laptop_details WHERE laptop_id = @laptop_id";
                cmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtHDD.Text = reader["hard_disk"].ToString();
                    txtDisplaySize.Text = reader["display_size"].ToString();
                    dateTimePicker1.Value = (DateTime)reader["release_date"];
                    chkAvailable.Checked = (bool)reader["available"];
                    txtPrice.Text = reader["price"].ToString();
                    txtUnitStock.Text = reader["unit_stock"].ToString();
                    if (!reader.IsDBNull(reader.GetOrdinal("picture")))
                    {
                        byte[] imgData = (byte[])reader["picture"];
                        MemoryStream ms = new MemoryStream(imgData);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "SELECT laptop_id, hard_disk, display_size, release_date, available, price, unit_stock " + "FROM laptop_details WHERE laptop_id = @laptop_id";

                    cmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtHDD.Text = reader["hard_disk"].ToString();
                            txtDisplaySize.Text = reader["display_size"].ToString();
                            dateTimePicker1.Value = (DateTime)reader["release_date"];
                            chkAvailable.Checked = (bool)reader["available"];
                            txtPrice.Text = reader["price"].ToString();
                            txtUnitStock.Text = reader["unit_stock"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified laptop_id.", "Error");
                    }

                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                // Show an error message box
                MessageBox.Show("An error occurred while searching data: " + ex.Message, "Error");
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
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
                    cmd.CommandText = "UPDATE laptop_details SET hard_disk = @hard_disk, display_size = @display_size, " +
                        "release_date = @release_date, available = @available, price = @price, unit_stock = @unit_stock " +
                        "WHERE laptop_id = @laptop_id";

                    cmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                    cmd.Parameters.AddWithValue("@hard_disk", txtHDD.Text);
                    cmd.Parameters.AddWithValue("@display_size", txtDisplaySize.Text);
                    cmd.Parameters.AddWithValue("@release_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@available", chkAvailable.Checked);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@unit_stock", txtUnitStock.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Laptop details updated successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message box
                MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error");
            }
            finally
            {
                // Close the database connection
                con.Close();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    // Delete the record from the laptop_details table
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM laptop_details WHERE laptop_id = @laptop_id";
                    cmd.Parameters.AddWithValue("@laptop_id", txtLaptopID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The record has been deleted from the laptop_details table.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("No record has been deleted from the laptop_details table.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message box
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error");
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }

    }
}
