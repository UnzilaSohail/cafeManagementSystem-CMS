using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
//using System.Web.SessionState;
using proj_test2;
using CMS;


namespace CMS.UI_Forms
{
   
    public partial class CustomerOrderSummary : Form
    {
        private int customerId;
        public CustomerOrderSummary()
        {
            InitializeComponent();
            this.customerId = customerId; 
            LoadOrders();
        }




        private void LoadOrders()
        {
            // Create a DataTable to store the order data
    DataTable dt = new DataTable();

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    // Prepare and execute the SQL command to retrieve order data
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT OD.OrderID, P.Name AS ProductName, OD.Quantity, OD.Subtotal, C.First_Name AS CustomerFirstName, C.Last_Name AS CustomerLastName, E.First_Name AS EmployeeFirstName, E.Last_Name AS EmployeeLastName, O.OrderDate FROM OrderDetails OD INNER JOIN Orders O ON OD.OrderID = O.Order_ID INNER JOIN Products P ON OD.ProductID = P.Product_ID INNER JOIN Customers C ON O.CustomerID = C.Customer_ID INNER JOIN Employees E ON O.EmployeeID = E.Employee_ID WHERE C.Customer_ID = @customerId";
                    command.Parameters.AddWithValue("@customerId", customerId);

                    // Execute the command and fill the DataTable with the retrieved data
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DeleteOrder(int orderId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@OrderID", orderId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!");
                        LoadOrders(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Record deletion failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

      
        private void CustomerOrderSummary_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }



        private void CustomerOrderSummary_Load_1(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            CustomerHomePage customerHomePage = new CustomerHomePage();
            this.Hide();
            customerHomePage.Show();

        }

        private void promotionsButton_Click_1(object sender, EventArgs e)
        {
            {
                CustomerPromotionsForm customerPromotionsForm = new CustomerPromotionsForm();
                this.Hide();
                customerPromotionsForm.Show();
            }
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            CustomerFeedbackForm customerFeedbackForm = new CustomerFeedbackForm();
            this.Hide();
            customerFeedbackForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button and in a valid row
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Prompt confirmation before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Perform delete action for the selected orderId
                    using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                    {
                        try
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM OrderDetails WHERE OrderID = @OrderID";
                            SqlCommand command = new SqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@OrderID", orderId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!");
                                // Refresh DataGridView
                                CustomerOrderSummary_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Record deletion failed.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void orderSummary_Click(object sender, EventArgs e)
        {

        }
    }
}


