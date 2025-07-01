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
using CMS.UI_Forms.Manager;

namespace CMS.UI_Forms.Manager
{
    public partial class AddEditPromotionForm : Form
    {
        public int CategoryId;
        public AddEditPromotionForm()
        {
            InitializeComponent();
        }
        private void productsButton_Click(object sender, EventArgs e)
        {
            ManagerHomePage managerHomePage = new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();
        }

        private void orderSummary_Click(object sender, EventArgs e)
        {
            ManagerPendingOrdersForm managerPendingOrdersForm = new ManagerPendingOrdersForm();
            this.Hide();
            managerPendingOrdersForm.Show();
        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {
            ManagerPromotionsForm managerPromotionsForm = new ManagerPromotionsForm();
            this.Hide();
            managerPromotionsForm.Show();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            ManagerFeedbacksForm managerFeedbacksForm = new ManagerFeedbacksForm();
            this.Hide();
            managerFeedbacksForm.Show();
        }
        private void supplierButton_Click(object sender, EventArgs e)
        {
            //ManagerSuppliersForm managerSuppliersForm = new ManagerSuppliersForm();
            //this.Hide();
            //managerSuppliersForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerPromotionsForm managerPromotionsForm = new ManagerPromotionsForm();
            this.Hide();
            managerPromotionsForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            ManagerCustomerForm managerCustomerForm = new ManagerCustomerForm();
            this.Hide();
            managerCustomerForm.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");

                using (SqlCommand command = new SqlCommand("AddNewPromotion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameters from textboxes
                    command.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@ProductCategory", CategoryId);
                    command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                    command.Parameters.AddWithValue("@Discount", decimal.Parse(discountTextBox.Text));
                    command.Parameters.AddWithValue("@StartDate", DateTime.Parse(dateTimePicker1.Text).Date);
                    command.Parameters.AddWithValue("@EndDate", DateTime.Parse(dateTimePicker2.Text).Date);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Promotion added successfully.");
                    clearButton_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }
        private void LoadCategories()
        {
            SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            connection.Open();
            try
            {
                string query = "SELECT CategoryId, CategoryName FROM ProductCategories";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind DataTable to ComboBox
                    categoriesComboBox.DataSource = dt;
                    categoriesComboBox.DisplayMember = "CategoryName"; // Display member
                    categoriesComboBox.ValueMember = "CategoryId"; // Value member
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesComboBox.SelectedItem != null)
            {
                DataRowView drv = categoriesComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int categoryId;
                    if (int.TryParse(drv["CategoryId"].ToString(), out categoryId))
                    {
                        CategoryId = categoryId;
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid category ID");
                    }
                }
            }
        }

        private void AddEditPromotionForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void AddEditPromotionForm_Load_1(object sender, EventArgs e)
        {
            // Retrieve values from textboxes and datetime pickers
            string name = usernameTextBox.Text;
            string description = passwordTextBox.Text;
            string discountStr = emailTextBox.Text;
            decimal discount;

            if (!decimal.TryParse(discountStr, out discount))
            {
                MessageBox.Show("Discount must be a valid decimal number.");
                return; // Exit the method if parsing fails
            }
            DateTime startDate = dateTimePicker3.Value;
            DateTime endDate = dateTimePicker4.Value;
            int productCategory = CategoryId; // Assuming CategoryId is set elsewhere in your form

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection("YourConnectionString"))
                {
                    // Open the connection
                    connection.Open();

                    string query = "INSERT INTO Promotions (Name, Description, StartDate, EndDate, Discount, ProductCategory) " +
                                   "VALUES (@Name, @Description, @StartDate, @EndDate, @Discount, @ProductCategory)";

                    // Create a command object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@ProductCategory", productCategory);

                        // Execute the command to insert data into the database
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Promotion added successfully.");
                            clearButton_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding promotion: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ManagerHomePage managerHomePage= new ManagerHomePage();
            this.Hide();
            managerHomePage.Show();
        }
    }
}


