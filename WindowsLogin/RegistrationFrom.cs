using Google.Protobuf.WellKnownTypes;  // Importing Google Protobuf WellKnownTypes
using MySql.Data.MySqlClient;  // Importing MySQL Data Provider
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class RegistrationFrom : Form
    {
        // Connection string to MySQL database
        private readonly string connectionString = "datasource=localhost;port=3306;username=root;password=SEngineer,531;database=student";

        // Constructor method
        public RegistrationFrom()
        {
            InitializeComponent();
            LoadStudentIDs();  // Calling method to load student IDs
        }

        // Event handler for logout button click
        private void Logout_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrom lg = new LoginFrom();
            lg.Show();  // Showing login form
            this.Hide();  // Hiding current registration form
        }

        // Event handler for register button click
        private void register_Click(object sender, EventArgs e)
        {
            // Retrieve student information from text boxes

            // Registration number
            string rno = textBoxRno.Text;
            // First name
            string fname = textBoxFname.Text;
            // Last name
            string lname = textBoxLname.Text;
            // Date of birth
            DateTime bdate = textBoxdob.Value;
            // Gender
            string gender;
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            // Address
            string address = textBoxAddress.Text;
            // Email
            string email = textBoxEmail.Text;
            // Mobile phone
            string mphone = textBoxMphone.Text;
            // Home phone
            string hphone = textBoxHphone.Text;
            // Parent name
            string pname = textBoxPname.Text;
            // NIC (National Identity Card)
            string nic = textBoxNIC.Text;
            // Contact number
            string contactno = textBoxCnumber.Text;

            // Validation of fields using if-else ladder

            // Check if registration number is empty or whitespace
            if (string.IsNullOrWhiteSpace(rno))
            {
                MessageBox.Show("Please enter registration number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxRno.Focus();  // Set focus to registration number textbox
            }
            // Check if first name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(fname))
            {
                MessageBox.Show("Please enter first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxFname.Focus();  // Set focus to first name textbox
            }
            // Check if last name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show("Please enter last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxLname.Focus();  // Set focus to last name textbox
            }
            // Check if age is between 10 and 100 years
            else if (DateTime.Today.Year - bdate.Year < 10 || DateTime.Today.Year - bdate.Year > 100)
            {
                MessageBox.Show("The student's age must be between 10 and 100 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxdob.Focus();  // Set focus to date of birth textbox
            }
            // Check if address is empty or whitespace
            else if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxAddress.Focus();  // Set focus to address textbox
            }
            // Check if email is empty or whitespace
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();  // Set focus to email textbox
            }
            // Check if mobile phone is empty or whitespace
            else if (string.IsNullOrWhiteSpace(mphone))
            {
                MessageBox.Show("Please enter mobile phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxMphone.Focus();  // Set focus to mobile phone textbox
            }
            // Check if home phone is empty or whitespace
            else if (string.IsNullOrWhiteSpace(hphone))
            {
                MessageBox.Show("Please enter home phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxHphone.Focus();  // Set focus to home phone textbox
            }
            // Check if parent name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(pname))
            {
                MessageBox.Show("Please enter parent name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPname.Focus();  // Set focus to parent name textbox
            }
            // Check if NIC is empty or whitespace
            else if (string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNIC.Focus();  // Set focus to NIC textbox
            }
            // Check if contact number is empty or whitespace
            else if (string.IsNullOrWhiteSpace(contactno))
            {
                MessageBox.Show("Please enter contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCnumber.Focus();  // Set focus to contact number textbox
            }
            // Check if gender is not selected
            else if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // If all fields are valid
            else
            {
                // Proceed to save the student information in the database

                // Creating a MySQL connection
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand command = null;

                try
                {
                    // Constructing insert query
                    string query = "INSERT INTO `registration` " +
                                   "(`regNo`,`firstName`,`lastName`,`dateOfBirth`,`gender`,`address`,`email`,`mobilePhone`,`homePhone`,`parentName`,`nic`,`contactNo`) " +
                                   "VALUES (@rn,@fn,@ln,@dob,@gn,@adr,@em,@mp,@hp,@pn,@nic,@cn)";

                    // Creating MySQL command
                    command = new MySqlCommand(query, con);

                    // Adding parameters to the command
                    command.Parameters.Add("@rn", MySqlDbType.Int64).Value = int.Parse(rno);
                    command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                    command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                    command.Parameters.Add("@dob", MySqlDbType.DateTime).Value = bdate;
                    command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
                    command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@mp", MySqlDbType.Int64).Value = int.Parse(mphone);
                    command.Parameters.Add("@hp", MySqlDbType.Int64).Value = int.Parse(hphone);
                    command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pname;
                    command.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic;
                    command.Parameters.Add("@cn", MySqlDbType.Int64).Value = int.Parse(contactno);

                    con.Open();  // Opening connection
                    bool success = command.ExecuteNonQuery() == 1;  // Executing command and checking success

                    // Showing success or error message after saving
                    MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // If operation was successful, clear fields and reload student IDs
                    if (success)
                    {
                        LoadStudentIDs();  // Reloading student IDs
                        ClearFields();  // Clearing input fields
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Closing the command and connection
                    if (command != null)
                    {
                        command.Dispose();
                    }
                    if (con != null && con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }

        // Method to load student IDs
        private void LoadStudentIDs()
        {
            // Creating a MySQL connection
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand command = null;
            MySqlDataReader reader = null;

            try
            {
                con.Open();  // Opening connection
                string query = "SELECT regNo FROM registration";
                command = new MySqlCommand(query, con);
                reader = command.ExecuteReader();

                textBoxRno.Items.Clear();  // Clearing existing items in combo box
                // Adding retrieved student IDs to combo box
                while (reader.Read())
                {
                    textBoxRno.Items.Add(reader["regNo"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Closing the reader, command, and connection
                if (reader != null)
                {
                    reader.Close();
                }
                if (command != null)
                {
                    command.Dispose();
                }
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        // Event handler for delete button click
        private void delete_Click(object sender, EventArgs e)
        {
            // Check if textBoxRno is not empty
            if (!string.IsNullOrEmpty(textBoxRno.Text))
            {
                // Creating a MySQL connection
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand command = null;

                try
                {
                    con.Open();  // Opening connection
                    int regNo = int.Parse(textBoxRno.Text);  // Parsing registration number
                    string query = "DELETE FROM registration WHERE regNo = @regNo";  // Constructing delete query
                    command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@regNo", regNo);  // Adding parameter
                    int rowsAffected = command.ExecuteNonQuery();  // Executing command and getting rows affected

                    // Showing success message if record deleted successfully
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentIDs();  // Reloading student IDs
                        ClearFields();  // Clearing input fields
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Closing the command and connection
                    if (command != null)
                    {
                        command.Dispose();
                    }
                    if (con != null && con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for text changed event of textBoxRno
        private void textBoxRno_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if textBoxRno is not empty
            if (!string.IsNullOrEmpty(textBoxRno.Text))
            {
                // Creating a MySQL connection
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand command = null;
                MySqlDataReader reader = null;

                try
                {
                    con.Open();  // Opening connection
                    int regNo = int.Parse(textBoxRno.Text);  // Parsing registration number
                    string query = "SELECT * FROM registration WHERE regNo = @regNo";  // Constructing select query
                    command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@regNo", regNo);  // Adding parameter
                    reader = command.ExecuteReader();  // Executing reader

                    // Populating text boxes with retrieved student information
                    if (reader.Read())
                    {
                        textBoxFname.Text = reader["firstName"].ToString();
                        textBoxLname.Text = reader["lastName"].ToString();
                        textBoxdob.Text = ((DateTime)reader["dateOfBirth"]).ToString("yyyy-MM-dd");

                        string gender = reader["gender"].ToString();
                        if (gender == "Male")
                        {
                            radioButtonMale.Checked = true;
                        }
                        else if (gender == "Female")
                        {
                            radioButtonFemale.Checked = true;
                        }

                        textBoxAddress.Text = reader["address"].ToString();
                        textBoxEmail.Text = reader["email"].ToString();
                        textBoxMphone.Text = reader["mobilePhone"].ToString();
                        textBoxHphone.Text = reader["homePhone"].ToString();
                        textBoxPname.Text = reader["parentName"].ToString();
                        textBoxNIC.Text = reader["nic"].ToString();
                        textBoxCnumber.Text = reader["contactNo"].ToString();
                    }
                    else
                    {
                        ClearFields();  // Clearing input fields if no record found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Closing the reader
                    if (reader != null)
                    {
                        reader.Close();
                    }

                    // Closing the connection
                    if (con != null && con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                // Clear TextBoxes if textBoxRno is empty
                ClearFields();
            }
        }

        // Method to clear all input fields
        private void ClearFields()
        {
            textBoxRno.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxdob.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxMphone.Text = "";
            textBoxHphone.Text = "";
            textBoxPname.Text = "";
            textBoxNIC.Text = "";
            textBoxCnumber.Text = "";
        }

        // Event handler for clear button click
        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();  // Clearing all input fields
        }

        // Event handler for update button click
        private void update_Click(object sender, EventArgs e)
        {
            // Retrieve student information from text boxes
            string rno = textBoxRno.Text;
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = textBoxdob.Value;
            string gender;
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            string mphone = textBoxMphone.Text;
            string hphone = textBoxHphone.Text;
            string pname = textBoxPname.Text;
            string nic = textBoxNIC.Text;
            string contactno = textBoxCnumber.Text;

            // Validation of fields using if-else ladder

            // Check if registration number is empty or whitespace
            if (string.IsNullOrWhiteSpace(rno))
            {
                MessageBox.Show("Please enter registration number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxRno.Focus();
            }
            // Check if first name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(fname))
            {
                MessageBox.Show("Please enter first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxFname.Focus();
            }
            // Check if last name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show("Please enter last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxLname.Focus();
            }
            // Check if age is between 10 and 100 years
            else if (DateTime.Today.Year - bdate.Year < 10 || DateTime.Today.Year - bdate.Year > 100)
            {
                MessageBox.Show("The student's age must be between 10 and 100 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxdob.Focus();
            }
            // Check if address is empty or whitespace
            else if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxAddress.Focus();
            }
            // Check if email is empty or whitespace
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Focus();
            }
            // Check if mobile phone is empty or whitespace
            else if (string.IsNullOrWhiteSpace(mphone))
            {
                MessageBox.Show("Please enter mobile phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxMphone.Focus();
            }
            // Check if home phone is empty or whitespace
            else if (string.IsNullOrWhiteSpace(hphone))
            {
                MessageBox.Show("Please enter home phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxHphone.Focus();
            }
            // Check if parent name is empty or whitespace
            else if (string.IsNullOrWhiteSpace(pname))
            {
                MessageBox.Show("Please enter parent name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPname.Focus();
            }
            // Check if NIC is empty or whitespace
            else if (string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxNIC.Focus();
            }
            // Check if contact number is empty or whitespace
            else if (string.IsNullOrWhiteSpace(contactno))
            {
                MessageBox.Show("Please enter contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxCnumber.Focus();
            }
            // Check if gender is not selected
            else if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // If all fields are valid
            else
            {
                // Proceed to update the student information in the database

                // Creating a MySQL connection
                MySqlConnection con = new MySqlConnection(connectionString);

                try
                {
                    con.Open();  // Opening connection
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "UPDATE `registration` SET " +
                                          "`firstName` = @fn, `lastName` = @ln, `dateOfBirth` = @dob, `gender` = @gn, `address` = @adr, `email` = @em, " +
                                          "`mobilePhone` = @mp, `homePhone` = @hp, `parentName` = @pn, `nic` = @nic, `contactNo` = @cn WHERE `regNo` = @rn";

                    // Setting parameter values
                    command.Parameters.AddWithValue("@rn", int.Parse(rno));
                    command.Parameters.AddWithValue("@fn", fname);
                    command.Parameters.AddWithValue("@ln", lname);
                    command.Parameters.AddWithValue("@dob", bdate);
                    command.Parameters.AddWithValue("@gn", gender);
                    command.Parameters.AddWithValue("@adr", address);
                    command.Parameters.AddWithValue("@em", email);
                    command.Parameters.AddWithValue("@mp", int.Parse(mphone));
                    command.Parameters.AddWithValue("@hp", int.Parse(hphone));
                    command.Parameters.AddWithValue("@pn", pname);
                    command.Parameters.AddWithValue("@nic", nic);
                    command.Parameters.AddWithValue("@cn", int.Parse(contactno));

                    bool success = command.ExecuteNonQuery() == 1;  // Executing command and checking success

                    // Showing success or error message after updating
                    MessageBox.Show(success ? "Record Updated Successfully" : "Error occurred while updating record", "Update Student", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    // If operation was successful, clear fields and reload student IDs
                    if (success)
                    {
                        LoadStudentIDs();  // Reloading student IDs
                        ClearFields();  // Clearing input fields
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Closing the connection
                    if (con != null && con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }

        // Event handler for exit link clicked
        private void exit_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prompt the user with a Yes/No question
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Close the entire application
                Application.Exit();
            }
        }
    }
}
