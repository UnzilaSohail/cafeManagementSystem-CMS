using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
//using Microsoft.AspNetCore.Http;
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
//using proj_test2;

namespace CMS.UI_Forms.Employee
{
    public partial class EmployeeOrdersForm : Form
    {
        private string username;

        public EmployeeOrdersForm()
        {
            InitializeComponent();
        }

        private void EmployeeOrdersForm_Load(object sender, EventArgs e)
        {
            // SQL Connection and Query
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            int empId = GetEmployeeIdByUsername(this.username);
            command.CommandText = "SELECT [OrderID], [CustomerID], [OrderDate] FROM Orders WHERE [EmployeeID] = @empId";
            command.Parameters.AddWithValue("@empId", empId);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EmployeeOrdersForm_Load_1(object sender, EventArgs e)
        {

        }

        private void checkInOutButton_Click_1(object sender, EventArgs e)
        {
            EmployeesHomePage employeesHomePage = new EmployeesHomePage(username);
            this.Hide();
            employeesHomePage.Show();
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
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
        
            LoadPendingOrdersData();

        }

        private int GetEmployeeIdByUsername(string username)
        {
            int empId = 0; // Initialize empId to 0

            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                string query = "SELECT Employee_ID FROM Employees WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

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
        private string GetUsernameFromDatabase()
        {
            string username = ""; // Initialize username

            // Establish connection and execute query to fetch username
            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                string query = "SELECT TOP 1 Username FROM Employees";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                }

                connection.Close();
            }

            return username;
        }
        private void LoadPendingOrdersData()
        {
            username = GetUsernameFromDatabase();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is not provided.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT o.[Order_ID], o.[CustomerID], o.[OrderDate] FROM Orders o INNER JOIN Employees e ON o.[EmployeeID] = e.[Employee_ID]WHERE e.[Username] = @username";

                    command.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending orders: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Retrieve data from the clicked row
                string orderId = dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                string customerId = dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                string orderDate = dataGridView1.Rows[e.RowIndex].Cells["OrderDate"].Value.ToString();

                // Perform actions based on the clicked row data
                MessageBox.Show($"Order ID: {orderId}, Customer ID: {customerId}, Order Date: {orderDate}");
            }
        }
    }
    
}
