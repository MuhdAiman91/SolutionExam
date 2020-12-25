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
using System.IO;
using System.Configuration;

namespace SolutionExam
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SolutionExam.Properties.Settings.sqlConn"].ToString());
        //SqlConnection con = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog = dbName; Integrated Security = True");
        SqlDataAdapter adapt;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            display_data();
        }

        private void regEm_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to register this employee?",
                                                 "Registration",
                                                 MessageBoxButtons.YesNo);
            if (nameBox.Text == "")
            {
                MessageBox.Show("Input Mandatory Fields:\n" +
                                "-Fill In Name",
                                "Note",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                else
                {
                    con.Open();
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Name FROM Employee WHERE Name = '" + nameBox.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (dt1.Rows.Count > 0)//Check Duplicate Name
                    {
                        MessageBox.Show("This employee already registered!",
                                        "Note",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                        con.Close();
                    }
                    else
                    {
                        SqlCommand SQLcm = con.CreateCommand();
                        SqlCommand cmi = new SqlCommand("SELECT MAX (Id) +1 FROM Employee", con);
                        int newID = (int)cmi.ExecuteScalar();
                        SQLcm.Parameters.AddWithValue("@idemployee", newID);
                        idBox.Text = newID.ToString();
                        //Check image
                        bool isNullOrEmpty = emPic == null || emPic.Image == null;
                        if (dobBox.Checked == false)
                        {
                            if (isNullOrEmpty == false)
                            {
                                MemoryStream stream = new MemoryStream();
                                emPic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] pic = stream.ToArray();
                                String query = "INSERT INTO Employee (Id, Name,Photo) VALUES (@txtid,@txtname,@txtphoto)";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtid", idBox.Text);
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtphoto", pic);

                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Register new User success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                            else
                            {
                                String query = "INSERT INTO Employee (Id, Name) VALUES (@txtid,@txtname)";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtid", idBox.Text);
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);

                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Register new User success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                        }
                        else
                        {
                            if (isNullOrEmpty == false)
                            {
                                MemoryStream stream = new MemoryStream();
                                emPic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] pic = stream.ToArray();
                                string query = "INSERT INTO Employee (Id, Name, DOB, Photo) VALUES (@txtid,@txtname,@txtdate,@txtphoto)";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {

                                        command.Parameters.AddWithValue("@txtid", idBox.Text);
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtdate", dobBox.Value.Date);
                                        command.Parameters.AddWithValue("@txtphoto", pic);

                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Register new User success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                            else
                            {
                                string query = "INSERT INTO Employee (Id, Name, DOB) VALUES (@txtid,@txtname,@txtdate)";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {

                                        command.Parameters.AddWithValue("@txtid", idBox.Text);
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtdate", dobBox.Value.Date);

                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Register new User success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void display_data()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM [Employee] ORDER BY ID", con);
            adapt.Fill(dt);
            dataGridEm.DataSource = dt;
            con.Close();
        }

        private void getImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                emPic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void deEm_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Select Data to Delete",
                                "Note",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                                 "Confirm Delete?",
                                                 MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("DELETE Employee WHERE Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Deleted Successfully!");
                    display_data();
                    ClearData();
                }
                else
                {
                    return;
                }
            }
        }

        private void edEm_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to edit this employee?",
                                                 "Registration",
                                                 MessageBoxButtons.YesNo);
            if (Id == 0)
            {
                MessageBox.Show("Select Data to Edit",
                                "Note",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                con.Open();
                if (confirmResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Name FROM Employee WHERE Name = '" + nameBox.Text + "' and Id != '" + idBox.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (dt1.Rows.Count > 0)//Check Duplicate Name
                    {
                        MessageBox.Show("This employee already registered!",
                                        "Note",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                        con.Close();
                    }
                    else
                    {//Check image
                        bool isNullOrEmpty = emPic == null || emPic.Image == null;
                        if (dobBox.Checked == false)
                        {
                            if (isNullOrEmpty == false)
                            {
                                MemoryStream stream = new MemoryStream();
                                emPic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] pic = stream.ToArray();
                                String query = "UPDATE Employee SET Photo = @txtphoto,Name = @txtname WHERE Id = @id";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtphoto", pic);
                                        command.Parameters.AddWithValue("@id", Id);
                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Edit Employee data success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                            else
                            {
                                String query = "UPDATE Employee SET Name = @txtname WHERE Id = @id";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@id", Id);
                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Edit Employee data success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                        }
                        else// Edit date
                        {
                            if (isNullOrEmpty == false)
                            {
                                MemoryStream stream = new MemoryStream();
                                emPic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] pic = stream.ToArray();
                                String query = "UPDATE Employee SET DOB = @txtdate,Photo = @txtphoto, Name = @txtname where Id = @id";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtdate", dobBox.Value.Date);
                                        command.Parameters.AddWithValue("@txtphoto", pic);
                                        command.Parameters.AddWithValue("@id", Id);
                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Edit Employee data success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                            else
                            {
                                String query = "UPDATE Employee SET DOB = @txtdate, Name = @txtname WHERE Id = @id";
                                try
                                {
                                    using (SqlCommand command = new SqlCommand(query, con))
                                    {
                                        command.Parameters.AddWithValue("@txtname", nameBox.Text);
                                        command.Parameters.AddWithValue("@txtdate", dobBox.Value.Date);
                                        command.Parameters.AddWithValue("@id", Id);
                                        int result = command.ExecuteNonQuery();

                                        MessageBox.Show("Edit Employee data success!",
                                            "Note");
                                        // Check Error
                                        if (result < 0)
                                            MessageBox.Show("Error");

                                        con.Close();
                                        display_data();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            emPic.Image = null;
        }
        private void ClearData()
        {
            nameBox.Text = "";
            dobBox.Text = "";
            emPic.Image = null;
            Id = 0;
        }

        private void dataGridEm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridEm.Rows[e.RowIndex].Cells[0].Value.ToString());
            idBox.Text = Id.ToString();
            nameBox.Text = dataGridEm.Rows[e.RowIndex].Cells[1].Value.ToString();
            dobBox.Text = dataGridEm.Rows[e.RowIndex].Cells[2].Value.ToString();
            try
            {
                Byte[] byteData = new Byte[0];
                byteData = (Byte[])(dataGridEm.Rows[e.RowIndex].Cells[3].Value);
                MemoryStream stmData = new MemoryStream(byteData);
                emPic.Image = Image.FromStream(stmData);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                emPic.Image = null;
            }
        }
    }
}
