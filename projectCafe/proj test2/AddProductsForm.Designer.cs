//namespace CMS.UI_Forms.Employee
//{
//    partial class AddProductsForm1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // AddProductsForm
//            // 
//            this.ClientSize = new System.Drawing.Size(282, 253);
//            this.Name = "AddProductsForm";
//            this.Load += new System.EventHandler(this.AddProductsForm_Load_1);
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Button addEditButton;
//        private System.Windows.Forms.Button backButton;
//        private System.Windows.Forms.TextBox descriptionTextBox;
//        private System.Windows.Forms.Label label10;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.TextBox priceTextBox;
//        private System.Windows.Forms.Label label9;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.TextBox nameTextBox;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button clearButton;
//        private System.Windows.Forms.Label addEditLabel;
//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Button logoutButton;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.Button supplierButton;
//        private System.Windows.Forms.Button employeeButton;
//        private System.Windows.Forms.Button customersButton;
//        private System.Windows.Forms.Button feedbackButton;
//        private System.Windows.Forms.Button promotionsButton;
//        private System.Windows.Forms.Button orderSummary;
//        private System.Windows.Forms.Button productsButton;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.ComboBox categoriesComboBox;
//        private System.Windows.Forms.ComboBox suppliersComboBox;
//        private System.Windows.Forms.NumericUpDown quantityUpDown;
//        private cafe_Management_systemDataSet cafe_Management_systemDataSet;
//        private System.Windows.Forms.BindingSource suppliersBindingSource;
//        private cafe_Management_systemDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
//    }
//}

using CMS.UI_Forms.Employee;
using System;
using System.Drawing;

namespace CMS
{
    partial class AddProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(System.Windows.Forms.TextBox v)
        {
            this.SuspendLayout();
            // 
            // AddProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(493, 337);
            this.nameTextBox = v;
            this.Load += new System.EventHandler(this.AddProductsForm_Load_1);
            this.ResumeLayout(false);

        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label addEditLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button orderSummary;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.ComboBox suppliersComboBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private cafe_Management_systemDataSet cafe_Management_systemDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private cafe_Management_systemDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private EventHandler Load;
        private EventHandler AddProductsForm_Load_1;

        public Size ClientSize { get; private set; }
    }
}

