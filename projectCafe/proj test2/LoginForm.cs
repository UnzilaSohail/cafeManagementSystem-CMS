using CMS.UI_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public partial class LoginForm : Form
    {
        public string Parameter = ""; // Initialize Parameter field
        private bool isManager = false; // Initialize isManager field
        private readonly string connectionString;

        public LoginForm(string parameter)
        {
            InitializeComponent();
            Parameter = parameter;
            // Initialize connection string if it's not provided through constructor
            connectionString = InitializeConnectionString();
        }

        public LoginForm()
        {
            InitializeComponent();
            Parameter = "default"; // Set a default value for Parameter if not provided
            // Initialize connection string if it's not provided through constructor
            connectionString = InitializeConnectionString();
        }

        private string InitializeConnectionString()
        {
            // Initialize connection string using SqlConnectionStringBuilder
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"UNZILA-09\SQLEXPRESS"; // Assuming SQL Express instance name
            builder.InitialCatalog = "CafeManagementSystem";
            builder.IntegratedSecurity = true; // Using Windows Authentication
            return builder.ConnectionString;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.ToLower().Trim();
            string password = passwordTextBox.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                // Use using statement for SqlConnection to ensure proper resource disposal
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open connection

                    string query = "";
                    if (Parameter == "employee")
                    {
                        query = "SELECT COUNT(*), Is_Manager FROM Employees WHERE LOWER(Username) = @Username AND Password = @Password GROUP BY Is_Manager";
                        using (SqlCommand managerCommand = new SqlCommand(query, connection))
                        {
                            managerCommand.Parameters.AddWithValue("@Username", username);
                            managerCommand.Parameters.AddWithValue("@Password", password);

                            using (SqlDataReader managerReader = managerCommand.ExecuteReader())
                            {
                                if (managerReader.Read())
                                {
                                    isManager = managerReader.GetBoolean(1); // Retrieve Is_Manager value
                                }
                            }
                        }
                    }
                    else if (Parameter == "customer")
                    {
                        query = "SELECT COUNT(*) FROM Customers WHERE Username = @Username AND Password = @Password";
                    }
                    else
                    {
                        MessageBox.Show("Invalid parameter.");
                        return; // Exit the method if Parameter is invalid
                    }

                    // Create SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // ExecuteScalar returns the first column of the first row
                        int count = (int)command.ExecuteScalar();

                        // Handle the login logic based on the query result
                        if (count > 0)
                        {
                            if (Parameter == "customer")
                            {
                                MessageBox.Show("Customer logged in successfully.");

                                CustomerHomePage customerHomePage = new CustomerHomePage();
                                this.Hide();
                                customerHomePage.Show();
                                // Proceed with customer login
                            }
                            else if (isManager) // Check isManager value
                            {
                                MessageBox.Show("Manager logged in successfully.");
                                // Display manager homepage
                                ManagerHomePage managerHomePage = new ManagerHomePage();
                                this.Hide();
                                managerHomePage.Show();
                            }
                            else
                            {
                                MessageBox.Show("Employee logged in successfully.");
                                // Display employee homepage
                                EmployeesHomePage emp = new EmployeesHomePage(username);
                                this.Hide();
                                emp.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed. Error: " + ex.Message);
            }
        }

      

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.");
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }
    }
}
