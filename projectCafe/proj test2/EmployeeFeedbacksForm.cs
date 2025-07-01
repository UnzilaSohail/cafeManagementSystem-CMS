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

namespace CMS.UI_Forms.Employee
{
    public partial class EmployeeFeedbacksForm : Form
    {
        public EmployeeFeedbacksForm()
        {
            InitializeComponent();
        }

     

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void EmployeeFeedbacksForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Feedback";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void EmployeeFeedbacksForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Feedback", connection);
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

        private void checkInOutButton_Click_1(object sender, EventArgs e)
        {
            EmployeesHomePage employeesHomePage = new EmployeesHomePage(sender);
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

        private void customerButton_Click_1(object sender, EventArgs e)
        {
            EmployeeCustomersForm employeeCustomersForm = new EmployeeCustomersForm();
            this.Hide();
            employeeCustomersForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

