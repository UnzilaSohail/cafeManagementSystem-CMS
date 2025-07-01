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
using CMS;

namespace CMS.UI_Forms
{
    public partial class CustomerPromotionsForm : Form
    {
        public CustomerPromotionsForm()
        {
            InitializeComponent();
        }

        private void LoadPromotionsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = UNZILA-09\\SQLEXPRESS; Initial Catalog = CafeManagementSystem; Integrated Security = True"))
                {
                    connection.Open();
                    string query = "SELECT [PromotionID], [Name], [Description], [StartDate], [EndDate], [Discount], [ProductCategory] FROM Promotions";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading promotions data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CustomerPromotionsForm_Load(object sender, EventArgs e)
        {
            LoadPromotionsData();
        }

        private void CustomerPromotionsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            CustomerHomePage customerHomePage = new CustomerHomePage();
            this.Hide();
            customerHomePage.Show();
        }

        private void orderSummary_Click_1(object sender, EventArgs e)
        {
            CustomerOrderSummary customerOrderSummary = new CustomerOrderSummary();
            this.Hide();
            customerOrderSummary.Show();
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

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            LoadPromotionsData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a row other than the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract data from the selected row
                int promotionID = Convert.ToInt32(selectedRow.Cells["PromotionID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string description = Convert.ToString(selectedRow.Cells["Description"].Value);
                DateTime startDate = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                DateTime endDate = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                decimal discount = Convert.ToDecimal(selectedRow.Cells["Discount"].Value);
                int productCategory = Convert.ToInt32(selectedRow.Cells["ProductCategory"].Value);

                // Display the extracted data (you can perform any required action with the data here)
                MessageBox.Show($"Promotion ID: {promotionID}\nName: {name}\nDescription: {description}\nStart Date: {startDate}\nEnd Date: {endDate}\nDiscount: {discount}\nProduct Category: {productCategory}");
            }
        }
    }
}

