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

namespace CMS.UI_Forms.Manager
{
    public partial class ManagerCustomerForm : Form
    {
        public ManagerCustomerForm()
        {
            InitializeComponent();
        }

        private void LoadCustomerData()
        {
            try
            {
                string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
                string query = "SELECT * FROM Customers";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        DataTable dt = new DataTable();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No customers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManagerCustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";

                // Define SQL query to select all columns from the Customers table
                string query = @"SELECT * 
                        FROM Customers";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ManagerCustomerForm_Load_1(object sender, EventArgs e)
        {
            LoadCustomerData();
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

        private void employeeButton_Click_1(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void supplierButton_Click_1(object sender, EventArgs e) { }
        //{
        //    ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
        //    this.Hide();
        //    managerSuppliersForm.Show();


        private void logoutButton_Click_1(object sender, EventArgs e)
        {

            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

        }
    }
}


