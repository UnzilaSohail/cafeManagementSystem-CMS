using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMS.UI_Forms
{
    partial class InitialForm
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
            this.cafeName = new System.Windows.Forms.Label();
            this.employeeLoginButton = new System.Windows.Forms.Button();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cafeName
            // 
            this.cafeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cafeName.AutoSize = true;
            this.cafeName.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cafeName.Location = new System.Drawing.Point(208, 27);
            this.cafeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cafeName.Name = "cafeName";
            this.cafeName.Size = new System.Drawing.Size(347, 52);
            this.cafeName.TabIndex = 0;
            this.cafeName.Text = "Comrades Cafe";
            // 
            // employeeLoginButton
            // 
            this.employeeLoginButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.employeeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeLoginButton.ForeColor = System.Drawing.Color.Black;
            this.employeeLoginButton.Location = new System.Drawing.Point(264, 206);
            this.employeeLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.employeeLoginButton.Name = "employeeLoginButton";
            this.employeeLoginButton.Size = new System.Drawing.Size(146, 76);
            this.employeeLoginButton.TabIndex = 5;
            this.employeeLoginButton.Text = "Login as Employee";
            this.employeeLoginButton.UseVisualStyleBackColor = false;
            this.employeeLoginButton.Click += new System.EventHandler(this.employeeLoginButton_Click_1);
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.customerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerLoginButton.ForeColor = System.Drawing.Color.Black;
            this.customerLoginButton.Location = new System.Drawing.Point(264, 103);
            this.customerLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(146, 76);
            this.customerLoginButton.TabIndex = 6;
            this.customerLoginButton.Text = "Login as Customer";
            this.customerLoginButton.UseVisualStyleBackColor = false;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_test2.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.employeeLoginButton);
            this.Controls.Add(this.cafeName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InitialForm";
            this.Text = "Cafe Management System";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cafeName;
        private Button employeeLoginButton;
        private Button customerLoginButton;
        private PictureBox pictureBox1;
    }
}