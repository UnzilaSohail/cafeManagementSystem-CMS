using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.UI_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CMS.UI_Forms.Employee;
//using proj_test2;

namespace CMS.UI_Forms
{
    public partial class EmployeePromotionsForm : Form
    {
        private string username;

        public EmployeePromotionsForm()
        {
            InitializeComponent();
        }


        private void EmployeePromotionsForm_Load(object sender, EventArgs e)
        {
            LoadPromotionsData();
        }

        private void LoadPromotionsData()
        {
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT [PromotionID], [Name], [Description], [StartDate], [EndDate], [Discount], [ProductCategory] FROM Promotions";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            LoadPromotionsData();
        }

        private void EmployeePromotionsForm_Load_1(object sender, EventArgs e)
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

        private void customerButton_Click_1(object sender, EventArgs e)
        {
            EmployeeCustomersForm employeeCustomersForm = new EmployeeCustomersForm();
            this.Hide();
            employeeCustomersForm.Show();
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {

            EmployeeFeedbacksForm employeeFeedbacksForm = new EmployeeFeedbacksForm();
            this.Hide();
            employeeFeedbacksForm.Show();
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}

