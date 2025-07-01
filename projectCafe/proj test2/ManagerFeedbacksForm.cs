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
//using proj_test2;

namespace CMS.UI_Forms.Manager
{
    public partial class ManagerFeedbacksForm : Form
    {
        public ManagerFeedbacksForm()
        {
            InitializeComponent();
        }


     

        private void ManagerFeedbacksForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [CafeManagementSystem].[dbo].[Feedback]";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void LoadFeedbacks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [CafeManagementSystem].[dbo].[Feedback]", connection);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ManagerFeedbacksForm_Load_1(object sender, EventArgs e)
        {
            LoadFeedbacks();
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

        private void customersButton_Click_1(object sender, EventArgs e)
        {
            ManagerCustomerForm customerForm = new ManagerCustomerForm();
            this.Hide();
            customerForm.Show();
        }

        private void employeeButton_Click_1(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
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

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            LoadFeedbacks();

        }
    }
}
