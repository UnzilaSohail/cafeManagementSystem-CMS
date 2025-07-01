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
using proj_test2;

namespace CMS.UI_Forms.Manager
{
    public partial class ManagerPendingOrdersForm : Form
    {
        public ManagerPendingOrdersForm()
        {
            InitializeComponent();
        }

        private void LoadPendingOrders()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [CafeManagementSystem].[dbo].[OrderDetailsExtended]", connection);
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
        

        private void ManagerPendingOrdersForm_Load_1(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productsButton_Click_1(object sender, EventArgs e)
        {
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();

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

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            LoadPendingOrders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

