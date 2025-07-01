using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMS.UI_Forms.Manager

{
    partial class AddEditEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addEditEmployeeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shiftEndTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shiftStartTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hourlyTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.addEditButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.supplierButton);
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.customersButton);
            this.panel1.Controls.Add(this.feedbackButton);
            this.panel1.Controls.Add(this.promotionsButton);
            this.panel1.Controls.Add(this.orderSummary);
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 613);
            this.panel1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 414);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(206, 33);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_test2.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // supplierButton
            // 
            this.supplierButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.supplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supplierButton.ForeColor = System.Drawing.Color.MistyRose;
            this.supplierButton.Location = new System.Drawing.Point(0, 376);
            this.supplierButton.Margin = new System.Windows.Forms.Padding(2);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(206, 33);
            this.supplierButton.TabIndex = 7;
            this.supplierButton.Text = "Suppliers";
            this.supplierButton.UseVisualStyleBackColor = false;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click_1);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeButton.ForeColor = System.Drawing.Color.MistyRose;
            this.employeeButton.Location = new System.Drawing.Point(0, 339);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(206, 33);
            this.employeeButton.TabIndex = 6;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = false;
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customersButton.ForeColor = System.Drawing.Color.MistyRose;
            this.customersButton.Location = new System.Drawing.Point(0, 300);
            this.customersButton.Margin = new System.Windows.Forms.Padding(2);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(206, 33);
            this.customersButton.TabIndex = 5;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = false;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click_1);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedbackButton.ForeColor = System.Drawing.Color.MistyRose;
            this.feedbackButton.Location = new System.Drawing.Point(0, 262);
            this.feedbackButton.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(206, 33);
            this.feedbackButton.TabIndex = 3;
            this.feedbackButton.Text = "Feedbacks";
            this.feedbackButton.UseVisualStyleBackColor = false;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click_1);
            // 
            // promotionsButton
            // 
            this.promotionsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(-8, 224);
            this.promotionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(214, 33);
            this.promotionsButton.TabIndex = 2;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = false;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click_1);
            // 
            // orderSummary
            // 
            this.orderSummary.BackColor = System.Drawing.Color.SaddleBrown;
            this.orderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderSummary.ForeColor = System.Drawing.Color.MistyRose;
            this.orderSummary.Location = new System.Drawing.Point(0, 185);
            this.orderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(206, 33);
            this.orderSummary.TabIndex = 1;
            this.orderSummary.Text = "Pending Orders";
            this.orderSummary.UseVisualStyleBackColor = false;
            this.orderSummary.Click += new System.EventHandler(this.orderSummary_Click_1);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.productsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.productsButton.Location = new System.Drawing.Point(0, 147);
            this.productsButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(206, 33);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.ForeColor = System.Drawing.Color.MistyRose;
            this.clearButton.Location = new System.Drawing.Point(262, 319);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 35);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // addEditEmployeeLabel
            // 
            this.addEditEmployeeLabel.AutoSize = true;
            this.addEditEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.addEditEmployeeLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.addEditEmployeeLabel.Location = new System.Drawing.Point(313, 6);
            this.addEditEmployeeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addEditEmployeeLabel.Name = "addEditEmployeeLabel";
            this.addEditEmployeeLabel.Size = new System.Drawing.Size(201, 31);
            this.addEditEmployeeLabel.TabIndex = 19;
            this.addEditEmployeeLabel.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(260, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(338, 55);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(276, 20);
            this.usernameTextBox.TabIndex = 23;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(338, 87);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(276, 20);
            this.passwordTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(260, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(338, 115);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.firstNameTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(260, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "FirstName";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(572, 114);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(500, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "LastName";
            // 
            // shiftEndTextBox
            // 
            this.shiftEndTextBox.Location = new System.Drawing.Point(514, 229);
            this.shiftEndTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.shiftEndTextBox.Name = "shiftEndTextBox";
            this.shiftEndTextBox.Size = new System.Drawing.Size(102, 20);
            this.shiftEndTextBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(442, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Shift End";
            // 
            // shiftStartTextBox
            // 
            this.shiftStartTextBox.Location = new System.Drawing.Point(338, 231);
            this.shiftStartTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.shiftStartTextBox.Name = "shiftStartTextBox";
            this.shiftStartTextBox.Size = new System.Drawing.Size(102, 20);
            this.shiftStartTextBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(260, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Shift Start";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(338, 173);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(276, 20);
            this.contactTextBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(260, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Contact";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(338, 142);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(276, 20);
            this.emailTextBox.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(260, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Email";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(338, 201);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(276, 20);
            this.addressTextBox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(260, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Address";
            // 
            // hourlyTextBox
            // 
            this.hourlyTextBox.Location = new System.Drawing.Point(521, 256);
            this.hourlyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hourlyTextBox.Name = "hourlyTextBox";
            this.hourlyTextBox.Size = new System.Drawing.Size(93, 20);
            this.hourlyTextBox.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(442, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Hourly Rate";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(338, 257);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(102, 20);
            this.salaryTextBox.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(260, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Salary";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label13.Location = new System.Drawing.Point(260, 284);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Join Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 284);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.ForeColor = System.Drawing.Color.MistyRose;
            this.backButton.Location = new System.Drawing.Point(523, 319);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 35);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.addEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addEditButton.ForeColor = System.Drawing.Color.MistyRose;
            this.addEditButton.Location = new System.Drawing.Point(392, 319);
            this.addEditButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(91, 35);
            this.addEditButton.TabIndex = 47;
            this.addEditButton.Text = "Add";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click_1);
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 487);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.hourlyTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shiftEndTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shiftStartTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addEditEmployeeLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEditEmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button feedbackButton;
        private Button promotionsButton;
        private Button orderSummary;
        private Button productsButton;
        private Button employeeButton;
        private Button customersButton;
        private Button supplierButton;
        private PictureBox pictureBox1;
        private Button logoutButton;
        private Button clearButton;
        private Label addEditEmployeeLabel;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox firstNameTextBox;
        private Label label4;
        private TextBox lastNameTextBox;
        private Label label5;
        private TextBox shiftEndTextBox;
        private Label label6;
        private TextBox shiftStartTextBox;
        private Label label7;
        private TextBox contactTextBox;
        private Label label8;
        private TextBox emailTextBox;
        private Label label9;
        private TextBox addressTextBox;
        private Label label10;
        private TextBox hourlyTextBox;
        private Label label11;
        private TextBox salaryTextBox;
        private Label label12;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private Button backButton;
        private Button addEditButton;
    }
}

