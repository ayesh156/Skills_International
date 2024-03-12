using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginFrom : Form
    {
        private MySqlConnection connection;

        public LoginFrom()
        {
            InitializeComponent();

            // Initialize the MySqlConnection object with connection string
            string connectionString = "datasource=localhost;port=3306;username=root;password=SEngineer,531;database=student";
            connection = new MySqlConnection(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand object with the SQL query and connection
                MySqlCommand command = new MySqlCommand("SELECT * FROM `logins` WHERE `username`= @usn AND `password` = @pass", connection);
                command.Parameters.AddWithValue("@usn", tb_username.Text);
                command.Parameters.AddWithValue("@pass", tb_password.Text);

                // Execute the SQL query and store the result in a DataTable
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    RegistrationFrom hp = new RegistrationFrom();
                    hp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_password.Text = "";
            tb_username.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
