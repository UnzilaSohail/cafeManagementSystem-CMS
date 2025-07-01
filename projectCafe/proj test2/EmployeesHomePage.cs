using proj_test2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CMS.UI_Forms.Employee;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS.UI_Forms
{
    public partial class EmployeesHomePage : Form
    {
        private string username;

        public object Sender { get; }

        public EmployeesHomePage(string username)
        {
            InitializeComponent();
            this.username = username; // Assign the username parameter to the field
            EmployeesHomePage_Load(username);
        }

        public EmployeesHomePage(object sender)
        {
            Sender = sender;
        }


        private void EmployeesHomePage_Load(object sender)
        {
            string a = employeeName.Text;
            employeeName.Text = username + " Logged in";
            currentDateLabel.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void EmployeesHomePage_Load_1(object sender, EventArgs e)
        {
            string a = employeeName.Text;
            employeeName.Text = sender + " Logged in";
            currentDateLabel.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void employeeName_Click(object sender, EventArgs e)
        {
            employeeName.Text = username + " Logged in";
        }
        private int GetEmployeeIdByUsername(string username)
        {
            int empId = 0; // Initialize empId to 0

            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                string query = "SELECT Employee_ID FROM Employees WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username); ;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    empId = Convert.ToInt32(reader["Employee_ID"]);
                }

                connection.Close();
            }

            return empId;
        }


        private void accountInfoButton_Click_1(object sender, EventArgs e)
        {
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
            this.Hide();
            accountDetailsForm.Show();
        }

        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkInButton_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            int empId = GetEmployeeIdByUsername(this.username); // Pass the username field
            connection.Open();
            //var empId = SessionState.EmployeeId;
            var checkIn = DateTime.Now.TimeOfDay;
            var dateCheckIn = DateTime.Now.Date;
            command.Connection = connection;
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@dateCheckIn", dateCheckIn);
            command.Parameters.AddWithValue("@checkIn", checkIn);
            command.CommandText = "INSERT INTO EmployeeCheckInOuts ([EmployeeID], [CheckInTime], [DateCheckInOut]) VALUES (@empId, @checkIn, @dateCheckIn)";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Checked In Successfully");
        }

        private void checkOutButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            int empId = GetEmployeeIdByUsername(this.username); // Pass the username field
                                                                //var empId = SessionState.EmployeeId;
            var checkOut = DateTime.Now.TimeOfDay;
            var dateCheckOut = DateTime.Now.Date;

            command.Connection = connection;
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@dateCheckOut", dateCheckOut);
            command.Parameters.AddWithValue("@checkOut", checkOut);

            // Check if the employee has checked in before
            string checkExistingCheckInQuery = "SELECT TOP(1) [CheckInOutId], [CheckOutTime] FROM EmployeeCheckInOuts WHERE [EmployeeID] = @empId AND [DateCheckInOut] = @dateCheckOut ORDER BY [CheckInTime] DESC";

            connection.Open();
            command.CommandText = checkExistingCheckInQuery;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                var existingCheckInId = reader["CheckInOutId"];
                var existingCheckOutTime = reader["CheckOutTime"];

                connection.Close();

                if (existingCheckOutTime != DBNull.Value && existingCheckOutTime != null)
                {
                    MessageBox.Show("You have already checked out.");
                }
                else
                {
                    // Update the existing check-in record with the check-out time
                    string updateCheckOutQuery = "UPDATE EmployeeCheckInOuts SET [CheckOutTime] = @checkOut WHERE [CheckInOutId] = @existingCheckInId";
                    command.CommandText = updateCheckOutQuery;
                    command.Parameters.AddWithValue("@existingCheckInId", existingCheckInId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Checked Out Successfully");
                }
            }
            else
            {
                connection.Close();
                MessageBox.Show("Error: Please check in first before checking out.");
            }
        }

        private void ordersButton_Click_1(object sender, EventArgs e)
        {
            EmployeeOrdersForm employeeOrdersForm = new EmployeeOrdersForm();
            this.Hide();
            employeeOrdersForm.Show();
        }

        private void promotionsButton_Click_1(object sender, EventArgs e)
        {
            EmployeePromotionsForm employeePromotionsForm = new EmployeePromotionsForm();
            this.Hide();
            employeePromotionsForm.Show();
        }

        private void customerButton_Click_1(object sender, EventArgs e)
        {
            EmployeeCustomersForm employeeCustomersForm = new EmployeeCustomersForm();
            this.Hide();
            employeeCustomersForm.Show();
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            EmployeeFeedbacksForm employeeFeedbacksForm = new EmployeeFeedbacksForm();
            this.Hide();
            employeeFeedbacksForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();

            loginForm.Show();
        }

        private void checkInOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}

