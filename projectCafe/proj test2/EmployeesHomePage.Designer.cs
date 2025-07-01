using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CMS.UI_Forms
{
    partial class EmployeesHomePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.checkInOutButton = new System.Windows.Forms.Button();
            this.employeeName = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.accountInfoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.feedbackButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.promotionsButton);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Controls.Add(this.checkInOutButton);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 474);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_test2.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 350);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(206, 33);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedbackButton.ForeColor = System.Drawing.Color.MistyRose;
            this.feedbackButton.Location = new System.Drawing.Point(0, 310);
            this.feedbackButton.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(206, 33);
            this.feedbackButton.TabIndex = 5;
            this.feedbackButton.Text = "Feedbacks";
            this.feedbackButton.UseVisualStyleBackColor = false;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click_1);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerButton.ForeColor = System.Drawing.Color.MistyRose;
            this.customerButton.Location = new System.Drawing.Point(0, 269);
            this.customerButton.Margin = new System.Windows.Forms.Padding(2);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(206, 33);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click_1);
            // 
            // promotionsButton
            // 
            this.promotionsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(0, 227);
            this.promotionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(206, 33);
            this.promotionsButton.TabIndex = 2;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = false;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click_1);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.ordersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ordersButton.ForeColor = System.Drawing.Color.MistyRose;
            this.ordersButton.Location = new System.Drawing.Point(0, 185);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(2);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(206, 33);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click_1);
            // 
            // checkInOutButton
            // 
            this.checkInOutButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.checkInOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkInOutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.checkInOutButton.Location = new System.Drawing.Point(0, 145);
            this.checkInOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkInOutButton.Name = "checkInOutButton";
            this.checkInOutButton.Size = new System.Drawing.Size(206, 33);
            this.checkInOutButton.TabIndex = 0;
            this.checkInOutButton.Text = "CheckInOut";
            this.checkInOutButton.UseVisualStyleBackColor = false;
            this.checkInOutButton.Click += new System.EventHandler(this.checkInOutButton_Click);
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.employeeName.Location = new System.Drawing.Point(327, 29);
            this.employeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(237, 36);
            this.employeeName.TabIndex = 16;
            this.employeeName.Text = "Employee Name";
            this.employeeName.Click += new System.EventHandler(this.employeeName_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentDateLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.currentDateLabel.Location = new System.Drawing.Point(348, 90);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(53, 25);
            this.currentDateLabel.TabIndex = 17;
            this.currentDateLabel.Text = "Date";
            this.currentDateLabel.Click += new System.EventHandler(this.currentDateLabel_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.checkInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.checkInButton.ForeColor = System.Drawing.Color.MistyRose;
            this.checkInButton.Location = new System.Drawing.Point(263, 186);
            this.checkInButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(148, 81);
            this.checkInButton.TabIndex = 18;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click_1);
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.checkOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.checkOutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.checkOutButton.Location = new System.Drawing.Point(472, 187);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(148, 79);
            this.checkOutButton.TabIndex = 19;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click_1);
            // 
            // accountInfoButton
            // 
            this.accountInfoButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.accountInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.accountInfoButton.ForeColor = System.Drawing.Color.MistyRose;
            this.accountInfoButton.Location = new System.Drawing.Point(291, 327);
            this.accountInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.accountInfoButton.Name = "accountInfoButton";
            this.accountInfoButton.Size = new System.Drawing.Size(300, 33);
            this.accountInfoButton.TabIndex = 11;
            this.accountInfoButton.Text = "Account Info";
            this.accountInfoButton.UseVisualStyleBackColor = false;
            this.accountInfoButton.Click += new System.EventHandler(this.accountInfoButton_Click_1);
            // 
            // EmployeesHomePage
            // 
            this.AcceptButton = this.checkOutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 487);
            this.Controls.Add(this.accountInfoButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeesHomePage";
            this.Text = "EmployeesHomePage";
            this.Load += new System.EventHandler(this.EmployeesHomePage_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button customerButton;
        private Button promotionsButton;
        private Button ordersButton;
        private Button checkInOutButton;
        private Button feedbackButton;
        private Button logoutButton;
        private Label employeeName;
        private Label currentDateLabel;
        private Button checkInButton;
        private Button checkOutButton;
        private Button accountInfoButton;
        private PictureBox pictureBox1;
    }
}
