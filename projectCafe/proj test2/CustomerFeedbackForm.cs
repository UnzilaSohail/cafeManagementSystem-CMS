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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using proj_test2;
using CMS;

namespace CMS.UI_Forms


{
    public partial class CustomerFeedbackForm : Form

    {
        public CustomerFeedbackForm()
        {
            InitializeComponent();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            CustomerFeedbackForm customerFeedbackForm = new CustomerFeedbackForm();
            this.Hide();
            customerFeedbackForm.Show();
        }

   
 

        private void CustomerFeedbackForm_Load(object sender, EventArgs e)
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

        private void promotionsButton_Click_1(object sender, EventArgs e)
        {

            CustomerPromotionsForm customerPromotionsForm = new CustomerPromotionsForm();
            this.Hide();
            customerPromotionsForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {

            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void commentsTextbox_TextChanged(object sender, EventArgs e)
        {
            int characterCount = commentsTextbox.Text.Length;

            // Update the character count label
            characterCountLabel.Text = $"Character Count: {characterCount}";
        }

        private void submitReviewButton_Click_1(object sender, EventArgs e)
        {
            // Get the selected rating
            int rating = 0;
            if (star1.Checked) rating = 1;
            else if (star2.Checked) rating = 2;
            else if (star3.Checked) rating = 3;
            else if (star4.Checked) rating = 4;
            else if (star5.Checked) rating = 5;

            // Get the comment
            string comment = commentsTextbox.Text;
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            connection.Open();
            // Store the data into the database
            DateTime feedbackDate = DateTime.Now;
            //int customerId = SessionState.CustomerId;
            command.Connection = connection;
            command.Parameters.AddWithValue("@rating", rating);
            command.Parameters.AddWithValue("@comment", comment);
            command.Parameters.AddWithValue("@feedbackDate", feedbackDate);
            //command.Parameters.AddWithValue("@customerId", customerId);
            command.CommandText = "INSERT INTO Feedback (Rating, FeedbackText, FeedbackDate) VALUES (@rating, @comment, @feedbackDate)";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Feedback submitted successfully!");
                    star1.Checked = false;
                    star2.Checked = false;
                    star3.Checked = false;
                    star4.Checked = false;
                    star5.Checked = false;
                    commentsTextbox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Failed to submit feedback.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }


}

