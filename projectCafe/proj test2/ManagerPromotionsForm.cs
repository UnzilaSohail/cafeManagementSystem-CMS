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
    public partial class ManagerPromotionsForm : Form
    {
        public ManagerPromotionsForm()
        {
            InitializeComponent();
        }


        private void LoadPromotions()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [CafeManagementSystem].[dbo].[Promotions]", connection);
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPromotions();
        }


        private void ManagerPromotionsForm_Load(object sender, EventArgs e)
        {
            LoadPromotions();
        }

        private void ManagerPromotionsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {

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

        private void addPromotionButton_Click_1(object sender, EventArgs e)
        {
            AddEditPromotionForm addEditPromotionForm = new AddEditPromotionForm();
            this.Hide();
            addEditPromotionForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the clicked cell
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Display the cell value in a message box
                MessageBox.Show($"Clicked cell value: {cellValue}");
            }
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            LoadPromotions();
        }
    }
}
