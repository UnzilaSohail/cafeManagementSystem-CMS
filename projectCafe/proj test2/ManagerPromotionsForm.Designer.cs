using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CMS.UI_Forms.Manager
{
    partial class ManagerPromotionsForm
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
            this.supplierButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addPromotionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutButton);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_test2.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 421);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(206, 33);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // supplierButton
            // 
            this.supplierButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.supplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.supplierButton.ForeColor = System.Drawing.Color.MistyRose;
            this.supplierButton.Location = new System.Drawing.Point(0, 382);
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
            this.employeeButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.employeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeButton.ForeColor = System.Drawing.Color.MistyRose;
            this.employeeButton.Location = new System.Drawing.Point(0, 342);
            this.employeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(206, 33);
            this.employeeButton.TabIndex = 6;
            this.employeeButton.Text = "Employees";
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click_1);
            // 
            // customersButton
            // 
            this.customersButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customersButton.ForeColor = System.Drawing.Color.MistyRose;
            this.customersButton.Location = new System.Drawing.Point(0, 302);
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
            this.promotionsButton.BackColor = System.Drawing.Color.LightSalmon;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(-8, 222);
            this.promotionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(214, 33);
            this.promotionsButton.TabIndex = 2;
            this.promotionsButton.Text = "Promotions";
            this.promotionsButton.UseVisualStyleBackColor = false;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click);
            // 
            // orderSummary
            // 
            this.orderSummary.BackColor = System.Drawing.Color.SaddleBrown;
            this.orderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderSummary.ForeColor = System.Drawing.Color.MistyRose;
            this.orderSummary.Location = new System.Drawing.Point(0, 182);
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
            this.productsButton.Location = new System.Drawing.Point(0, 144);
            this.productsButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(206, 33);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshButton.ForeColor = System.Drawing.Color.MistyRose;
            this.refreshButton.Location = new System.Drawing.Point(583, 41);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(91, 35);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(434, 222);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(368, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Promotions";
            // 
            // addPromotionButton
            // 
            this.addPromotionButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.addPromotionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPromotionButton.ForeColor = System.Drawing.Color.MistyRose;
            this.addPromotionButton.Location = new System.Drawing.Point(238, 41);
            this.addPromotionButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPromotionButton.Name = "addPromotionButton";
            this.addPromotionButton.Size = new System.Drawing.Size(91, 35);
            this.addPromotionButton.TabIndex = 24;
            this.addPromotionButton.Text = "+ Add";
            this.addPromotionButton.UseVisualStyleBackColor = false;
            this.addPromotionButton.Click += new System.EventHandler(this.addPromotionButton_Click_1);
            // 
            // ManagerPromotionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 487);
            this.Controls.Add(this.addPromotionButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerPromotionsForm";
            this.Text = "ManagerPromotionsForm";
            this.Load += new System.EventHandler(this.ManagerPromotionsForm_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Button logoutButton;
        private Button refreshButton;
        private DataGridView dataGridView1;
        private Label label1;
        private Button addPromotionButton;
        private PictureBox pictureBox1;
    }
}
