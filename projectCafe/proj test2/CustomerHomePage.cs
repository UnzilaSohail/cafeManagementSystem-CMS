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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using proj_test2;

namespace CMS
{
    public partial class CustomerHomePage : Form
    {
        private int productId;
        public string Username;
        private int customerId;
        private decimal productPrice = 0;
        private Dictionary<string, decimal> cartItems = new Dictionary<string, decimal>();
       // private int orderId; // Declare orderId variable at the class level


        public CustomerHomePage()
        {
            InitializeComponent();
            quantityBox.ValueChanged += quantityBox_ValueChanged;
            LoadCategories();
            dataGridView1.Columns.Add("Product_ID", "Product Id");
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            this.Username = Username;
            this.customerId = customerId;

        }
        public CustomerHomePage(string username, int customerId)
        {
            Username = username;
            InitializeComponent();
            quantityBox.ValueChanged += quantityBox_ValueChanged;
            LoadCategories();
            dataGridView1.Columns.Add("Product_ID", "Product Id");
            dataGridView1.Columns.Add("Name", "Product Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
        }



        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }


   

        private void DisplayCartItems()
        {
            // Clear the richTextBox
            richTextBox1.Clear();

            // Display items in the richTextBox
            foreach (var item in cartItems)
            {
                richTextBox1.AppendText($"{item.Key} - Price: {item.Value}\n");
            }

            // Calculate and display total price
            decimal totalPrice = CalculateTotalPrice();
            totalPriceTextBox.Text = totalPrice.ToString();
        }
        private int GetRandomEmployeeID()
        {
            int employeeID = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT TOP 1 Employee_ID FROM Employees ORDER BY NEWID()";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            employeeID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error retrieving employee ID: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return employeeID;
        }

        private void SaveOrderDetails(int orderId)
        {using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
    {
        try
        {
            connection.Open();
            string insertQuery = "INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Subtotal) VALUES (@orderId, @productId, @quantity, @subtotal)";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int productId = Convert.ToInt32(row.Cells["Product_ID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells["Price"].Value) * quantity; // Calculate subtotal based on price and quantity

                        insertCommand.Parameters.Clear();
                        insertCommand.Parameters.AddWithValue("@orderId", orderId);
                        insertCommand.Parameters.AddWithValue("@productId", productId);
                        insertCommand.Parameters.AddWithValue("@quantity", quantity);
                        insertCommand.Parameters.AddWithValue("@subtotal", subtotal);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error saving order details: " + ex.Message);
        }
    }
        }

      
        private decimal GetProductPrice(int productId)
        {
            decimal price = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Price FROM Products WHERE Product_ID = @productId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            price = Convert.ToDecimal(result);

                            // Check for discount and apply if available
                            var discount = CheckDiscount(productId);
                            if (discount > 0)
                            {
                                price -= (discount / 100) * price;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return price;
        }
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            string[] lines = richTextBox1.Lines;
            foreach (string line in lines)
            {
                // Assuming each line has the format "ItemName - Price: 10.00" (change it to match your actual format)
                string[] parts = line.Split(new string[] { " - Price: " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    decimal itemPrice = decimal.Parse(parts[1]);
                    totalPrice += itemPrice;
                }
            }

            return totalPrice;
        }



        private void LoadItemsForCategory(int categoryId)
        {
            try
            {
                string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
                string query = "SELECT Product_ID, Name FROM Products WHERE CategoryId = @categoryId";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        itemComboBox.DisplayMember = "Name";
                        itemComboBox.ValueMember = "Product_ID";
                        itemComboBox.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items for category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCategories()
        {
            try
            {
                string connectionString = "Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT CategoryId, CategoryName FROM ProductCategories", connection))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    if (dt.Rows.Count > 0)
                    {
                        categoriesComboBox.DisplayMember = "CategoryName";
                        categoriesComboBox.ValueMember = "CategoryId";
                        categoriesComboBox.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedItem != null)
            {
                DataRowView drv = itemComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int productId;
                    if (int.TryParse(drv["ProductID"].ToString(), out productId))
                    {
                        // Load quantity and other details based on the selected item
                        LoadQuantityForProduct(productId);

                        // Get the price of the selected product
                        productPrice = GetProductPrice(productId);
                        if (quantityBox.Value == 0)
                        {
                            priceTextBox.Text = "0";
                        }
                        else
                        {
                            priceTextBox.Text = productPrice.ToString();
                        }

                        // Calculate and display subtotal
                        // CalculateSubtotal();
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid product ID");
                    }
                }
            }
        }



        private void LoadQuantityForProduct(int productId)
        {
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");
            connection.Open();
            try
            {
                // SQL query to retrieve the maximum quantity available for the selected ProductId
                string query = "SELECT Quantity FROM Products WHERE Product_ID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int maxQuantity = Convert.ToInt32(result);
                        // Set the NumericUpDown control's maximum value
                        quantityBox.Minimum = 0;
                        quantityBox.Maximum = maxQuantity;
                        quantityBox.Value = 0;
                    }
                    else
                    {
                        quantityBox.Enabled = false;
                    }
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
        private decimal CheckDiscount(int productId)
        {
            decimal discount = 0;
            // Assuming you have a connection string
            SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True");

            connection.Open();
            string query = @"SELECT p.CategoryId, pr.StartDate, pr.EndDate, pr.Discount
                         FROM Products p
                         INNER JOIN Promotions pr ON p.CategoryId = pr.ProductCategory
                         WHERE p.CategoryId = @productId AND pr.StartDate <= GETDATE() AND pr.EndDate >= GETDATE()";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductID", productId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        discount = reader.GetDecimal(reader.GetOrdinal("Discount"));
                    }
                }
            }


            return discount;
        }

        private void CalculateSubtotal()
        {
            // Get the selected quantity from the NumericUpDown control
            int selectedQuantity = (int)quantityBox.Value;

            // Calculate subtotal using the current productPrice
            decimal subtotal = selectedQuantity * productPrice;

            // Update the priceTextBox with the new subtotal value
            priceTextBox.Text = subtotal.ToString();
        }

        private void UpdateDataGridView()
        {
            if (itemComboBox.SelectedItem != null)
            {
                DataRowView drv = itemComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int productId;
                    if (int.TryParse(drv["Product_ID"].ToString(), out productId)) // Here's the issue
                    {
                        // Fetch product information (name, description, price) based on productId
                        string productName = GetProductName(productId);
                        string productDescription = GetProductDescription(productId);
                        decimal productPrice = GetProductPrice(productId);

                        // Get the selected quantity from the NumericUpDown control
                        int selectedQuantity = (int)quantityBox.Value;

                        // Add or update the DataGridView with the product information and selected quantity
                        UpdateOrAddDataGridViewRow(productId, productName, productDescription, productPrice, selectedQuantity);
                    }
                    else
                    {
                        MessageBox.Show("Invalid product ID");
                    }
                }
            }
        }
        private string GetProductName(int productId)
        {
            string productName = string.Empty; // Initialize with an empty string

            using (SqlConnection connection = new SqlConnection(@"Data Source=UNZILA-09\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Name FROM Products WHERE Product_ID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            productName = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return productName;
        }
        private string GetProductDescription(int productId)
        {
            string productDescription = string.Empty; // Initialize with an empty string

            using (SqlConnection connection = new SqlConnection(@"Data Source=UNZILA-09\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT Description FROM Products WHERE Product_ID = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            productDescription = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return productDescription;
        }
        private void UpdateOrAddDataGridViewRow(int productId, string productName, string productDescription, decimal productPrice, int selectedQuantity)
        {
            DataGridViewRow existingRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Name"].Value != null &&
                    (row.Cells["Name"].Value).ToString() == productName)
                {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow != null)
            {
                // If the product already exists, update the quantity
                existingRow.Cells["Quantity"].Value = selectedQuantity;
            }
            else
            {
                // If the product doesn't exist, add a new row with product information and quantity
                dataGridView1.Rows.Add(productId, productName, productDescription, productPrice, selectedQuantity);
            }
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

       
        private void orderButton_Click_1(object sender, EventArgs e)

        {
            DateTime orderDate = DateTime.Now;
            int employeeId = GetRandomEmployeeID(); // Make sure this method returns a valid employee ID

            // Insert order and get the order ID
            int orderId = InsertOrderAndGetID(orderDate, employeeId);

            if (orderId > 0)
            {
                // Save order details (you need to implement this method)
                SaveOrderDetails(orderId);
                MessageBox.Show($"Order placed successfully with ID: {orderId}");
            }
            else
            {
                MessageBox.Show("Failed to place order. Please try again.");
            }
        }
      


        private void addToCartButton_Click_1(object sender, EventArgs e)
        {
            UpdateDataGridView();
            if (itemComboBox.SelectedIndex != -1 && !string.IsNullOrEmpty(priceTextBox.Text))
            {
                // Get selected item and price
                string selectedItem = itemComboBox.Text;
                decimal selectedPrice = decimal.Parse(priceTextBox.Text);

                // Check if the item already exists in the cart
                if (cartItems.ContainsKey(selectedItem))
                {
                    // Remove the previous entry for this item
                    cartItems.Remove(selectedItem);
                }

                // Add or update item and price in the cart dictionary
                cartItems[selectedItem] = selectedPrice;

                // Update the display in richTextBox1
                DisplayCartItems();
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

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

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private void itemComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedItem != null)
            {
                DataRowView drv = itemComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    // Extract the product ID directly from the selected value
                    int productId;
                    if (int.TryParse(drv["Product_ID"].ToString(), out productId))
                    {
                        // Load quantity and other details based on the selected item
                        LoadQuantityForProduct(productId);

                        // Get the price of the selected product
                        productPrice = GetProductPrice(productId);
                        if (quantityBox.Value == 0)
                        {
                            priceTextBox.Text = "0";
                        }
                        else
                        {
                            priceTextBox.Text = productPrice.ToString();
                        }

                        // Calculate and display subtotal
                        // CalculateSubtotal();
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid product ID");
                    }
                }
            }
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private int orderIdCounter = 16;
        private int GenerateCustomOrderID()
        {
            // Use the orderIdCounter as the next available order ID
            int nextOrderId = orderIdCounter;

            // Increment the orderIdCounter for the next order
            orderIdCounter++;

            return nextOrderId;
        }

        //private int GetNextAvailableOrderIDFromDatabase()
        //{
        //    int nextOrderId = 0;

        //    // Establish a connection to your database
        //    using (SqlConnection connection = new SqlConnection("Data Source=UNZILA-09\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            // Query to get the maximum order ID from the Orders table
        //            string query = "SELECT MAX(Order_ID) FROM Orders";

        //            // Execute the query
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                // ExecuteScalar returns the result of the query
        //                object result = command.ExecuteScalar();

        //                // Check if the result is not null
        //                if (result != DBNull.Value && result != null)
        //                {
        //                    // Parse the result to int and increment by 1 to get the next available order ID
        //                    nextOrderId = Convert.ToInt32(result) + 1;
        //                }
        //                else
        //                {
        //                    // If the result is null, set the next available order ID to 1
        //                    nextOrderId = 1;
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show("SQL Error: " + ex.Message);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }

        //    return nextOrderId;
        //}
        private int InsertOrderAndGetID(DateTime orderDate, int employeeId)
        {
            int orderId = -1; // Initialize with an invalid ID

            using (SqlConnection connection = new SqlConnection(@"Data Source=UNZILA-09\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    // Generate a custom order ID
                    orderId = GenerateCustomOrderID();

                    // Insert order into Orders table with the custom order ID
                    string insertOrderQuery = "INSERT INTO Orders (Order_ID, OrderDate, EmployeeID) VALUES (@orderId, @orderDate, @employeeId);";
                    using (SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection))
                    {
                        insertOrderCommand.Parameters.AddWithValue("@orderId", orderId);
                        insertOrderCommand.Parameters.AddWithValue("@orderDate", orderDate);
                        insertOrderCommand.Parameters.AddWithValue("@employeeId", employeeId);
                        insertOrderCommand.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                  //  MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Error inserting order: " + ex.Message);
                }
            }

            return orderId;
        }

        private void categoriesComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (categoriesComboBox.SelectedItem != null)
            {
                DataRowView drv = categoriesComboBox.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int categoryId;
                    if (int.TryParse(drv["CategoryId"].ToString(), out categoryId))
                    {
                        LoadItemsForCategory(categoryId);
                    }
                    else
                    {
                        // Handle the case where the conversion fails
                        MessageBox.Show("Invalid category ID");
                    }
                }
            }
        }
    }

}


