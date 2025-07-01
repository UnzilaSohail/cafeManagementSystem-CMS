using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CMS.UI_Forms.Employee;
using CMS.UI_Forms.Manager;
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

namespace CMS.UI_Forms
{
    public partial class ManagerHomePage : Form
    {
        string Username;
        public ManagerHomePage()
        {
            InitializeComponent();
        }
        public ManagerHomePage(string username)
        {
            Username = username;
            InitializeComponent();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.Show();
        }

     
      
        private void ManagerHomePage_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Sources=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM [CafeManagementSystem].[dbo].[Products]";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

       
        private void ManagerHomePage_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [CafeManagementSystem].[dbo].[Products]", connection);
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


        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM [CafeManagementSystem].[dbo].[Products]", connection);
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void orderSummary_Click_1(object sender, EventArgs e)
        {
            ManagerPendingOrdersForm managerPendingOrdersForm = new ManagerPendingOrdersForm();
            this.Hide();
            managerPendingOrdersForm.Show();
        }

        private void promotionsButton_Click_1(object sender, EventArgs e)
        {
            Manager.ManagerPromotionsForm managerPromotionsForm = new Manager.ManagerPromotionsForm();
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

        private void employeeButton_Click_1(object sender, EventArgs e)
        {
            ManagerEmployeesForm managerEmployeesForm = new ManagerEmployeesForm();
            this.Hide();
            managerEmployeesForm.Show();
        }

        private void supplierButton_Click_1(object sender, EventArgs e)
        {
            //Manager.ManagerSuppliersForm managerSuppliersForm = new Manager.ManagerSuppliersForm();
            //this.Hide();
            //managerSuppliersForm.Show();
        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            //AddProductsForm addProductsForm = new AddProductsForm();
            //this.Hide();
            //addProductsForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


