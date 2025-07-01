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
    public partial class AddEditEmployeeForm : Form
    {
        public AddEditEmployeeForm(int employeeId)
        {
            InitializeComponent();
        }

        public AddEditEmployeeForm()
        {
        }

      
        private void supplierButton_Click(object sender, EventArgs e)
        {
            //ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            //this.Hide();
            //managerSuppliersForm.Show();
        }

       

        private void AddEditEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
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

        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void addEditButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");

                using (SqlCommand command = new SqlCommand("AddNewEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters from textboxes
                    command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                    command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", contactTextBox.Text);
                    command.Parameters.AddWithValue("@ShiftStartTime", shiftStartTextBox.Text);
                    command.Parameters.AddWithValue("@ShiftEndTime", shiftEndTextBox.Text);
                    command.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    command.Parameters.AddWithValue("@JoinDate", DateTime.Now); // Assuming join date is current date
                    command.Parameters.AddWithValue("@Salary", decimal.Parse(salaryTextBox.Text));
                    command.Parameters.AddWithValue("@HourlyRate", decimal.Parse(hourlyTextBox.Text));
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee added successfully.");
                    clearButton_Click_1(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
    }
}


