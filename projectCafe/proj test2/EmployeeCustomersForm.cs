using proj_test2;
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

namespace CMS.UI_Forms.Employee
{
    public partial class EmployeeCustomersForm : Form
    {
        private string username;

        public EmployeeCustomersForm()
        {
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            try
            {
                string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Customers"; // Assuming Customers is the correct table name
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EmployeeCustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void EmployeeCustomersForm_Load_1(object sender, EventArgs e)
        {

        }

        private void checkInOutButton_Click_1(object sender, EventArgs e)
        {
            EmployeesHomePage employeesHomePage = new EmployeesHomePage(username);
            this.Hide();
            employeesHomePage.Show();
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

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            EmployeeFeedbacksForm employeeFeedbacksForm = new EmployeeFeedbacksForm();
            this.Hide();
            employeeFeedbacksForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Assuming you have a button column for each row, perform actions based on the clicked button
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ButtonColumnName")
                {
                    // Retrieve data from the clicked row, for example:
                    string customerId = dataGridView1.Rows[e.RowIndex].Cells["CustomerIdColumnName"].Value.ToString();
                    string customerName = dataGridView1.Rows[e.RowIndex].Cells["CustomerNameColumnName"].Value.ToString();

                    // Perform actions based on the clicked button or cell
                    MessageBox.Show($"Customer ID: {customerId}, Customer Name: {customerName}");
                }
            }
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {

            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}

