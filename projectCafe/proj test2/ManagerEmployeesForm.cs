using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.UI_Forms.Employee;
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
using proj_test2;

namespace CMS.UI_Forms.Manager
{
    public partial class ManagerEmployeesForm : Form
    {
        public ManagerEmployeesForm()
        {
            InitializeComponent();
        }


        private void ManagerEmployeesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void LoadDataIntoDataGridView()
        {
            {
                try
                {
                    
                    string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";

                    string query = "SELECT Employee_ID, First_Name, Last_Name, Email, PhoneNumber, Address, Join_Date, Salary, Is_Manager FROM [CafeManagementSystem].[dbo].[Employees]";

                   
                    using (SqlConnection connection = new SqlConnection("Data Source = UNZILA-09\\SQLEXPRESS; Initial Catalog = CafeManagementSystem; Integrated Security = True"))
                    {
                        // Create SqlCommand
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Open connection
                            connection.Open();

                            // Create DataTable to hold results
                            DataTable dt = new DataTable();

                            // Load data into DataTable
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                dt.Load(reader);
                            }

                            // Bind DataTable to DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated data from the DataGridView
            DataGridViewRow updatedRow = dataGridView1.Rows[e.RowIndex];

            int employeeID = Convert.ToInt32(updatedRow.Cells["Employee_ID"].Value);
            string firstName = updatedRow.Cells["FirstName"].Value.ToString();
            string lastName = updatedRow.Cells["LastName"].Value.ToString();
            string email = updatedRow.Cells["Email"].Value.ToString();
            string phoneNumber = updatedRow.Cells["PhoneNumber"].Value.ToString();
            string address = updatedRow.Cells["Address"].Value.ToString();
            DateTime joinDate = Convert.ToDateTime(updatedRow.Cells["JoinDate"].Value);
            decimal salary = Convert.ToDecimal(updatedRow.Cells["Salary"].Value);
            bool isManager = Convert.ToBoolean(updatedRow.Cells["IsManager"].Value);

            // Update the database with the changes
            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                connection.Open();
                string updateQuery = "UPDATE [CafeManagementSystem].[dbo].[Employees] SET First_Name = @FirstName, Last_Name = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address, JoinDate = @JoinDate, Salary = @Salary, Is_Manager = @IsManager WHERE Employee_ID = @EmployeeID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@FirstName", firstName);
                updateCommand.Parameters.AddWithValue("@LastName", lastName);
                updateCommand.Parameters.AddWithValue("@Email", email);
                updateCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                updateCommand.Parameters.AddWithValue("@Address", address);
                updateCommand.Parameters.AddWithValue("@JoinDate", joinDate);
                updateCommand.Parameters.AddWithValue("@Salary", salary);
                updateCommand.Parameters.AddWithValue("@IsManager", isManager);
                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                updateCommand.ExecuteNonQuery();
                connection.Close();

            }
            dataGridView1.RefreshEdit();
        }

        private void ManagerEmployeesForm_Load_1(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void productsButton_Click_1(object sender, EventArgs e)
        {

            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();
        }

        private void orderSummary_Click_1(object sender, EventArgs e)
        {
            ManagerPendingOrdersForm managerPendingOrdersForm = new ManagerPendingOrdersForm();
            this.Hide();
            managerPendingOrdersForm.Show();
        }

        private void promotionsButton_Click_1(object sender, EventArgs e)
        {
            ManagerPromotionsForm managerPromotionsForm = new ManagerPromotionsForm();
            this.Hide();
            managerPromotionsForm.Show();
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            ManagerFeedbacksForm managerFeedbacksForm = new ManagerFeedbacksForm();
            this.Hide();
            managerFeedbacksForm.Show();
        }

        private void customersButton_Click_1(object sender, EventArgs e)
        {
            ManagerCustomerForm managerCustomerForm = new ManagerCustomerForm();
            this.Hide();
            managerCustomerForm.Show();
        }

        private void supplierButton_Click_1(object sender, EventArgs e)
        {

            //ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            //this.Hide();
            //managerSuppliersForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {

            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void addEmployeeButton_Click_1(object sender, EventArgs e)
        {
           AddEditEmployeeForm addEmployeeForm = new AddEditEmployeeForm();
            this.Hide();
            addEmployeeForm.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a button cell
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                // Retrieve the employee ID from the clicked row
                int employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Employee_ID"].Value);

                // Open a new form or perform any action based on the employee ID
                // For example, you can open a form to edit the employee details
                AddEditEmployeeForm editForm = new AddEditEmployeeForm(employeeId);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                // Retrieve the employee ID from the clicked row
                int employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Employee_Id"].Value);

                // Display a confirmation dialog before deleting the employee
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Call a method to delete the employee from the database
                    bool deleted = DeleteEmployee(employeeId);

                    if (deleted)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView after deletion
                        LoadDataIntoDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool DeleteEmployee(int employeeId)
        {
            try
            {
                // Define your connection string
                string connectionString = "\"Data Source=UNZILA-09\\\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";

                // Create a SqlConnection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query to delete the employee
                    string query = "DELETE FROM Employees WHERE Employee_ID = @EmployeeId";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Employee_ID", employeeId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected (employee deleted)
                        if (rowsAffected > 0)
                        {
                            // Employee deleted successfully
                            return true;
                        }
                        else
                        {
                            // No rows affected, employee might not exist
                            MessageBox.Show("Empl" +
                                "oyee does not exist or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

