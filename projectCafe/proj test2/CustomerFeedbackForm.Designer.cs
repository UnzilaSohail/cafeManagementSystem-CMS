using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace CMS.UI_Forms

{
    partial class CustomerFeedbackForm
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
            this.promotionsButton = new System.Windows.Forms.Button();
            this.orderSummary = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commentsTextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.star1 = new System.Windows.Forms.RadioButton();
            this.star2 = new System.Windows.Forms.RadioButton();
            this.star3 = new System.Windows.Forms.RadioButton();
            this.star4 = new System.Windows.Forms.RadioButton();
            this.star5 = new System.Windows.Forms.RadioButton();
            this.submitReviewButton = new System.Windows.Forms.Button();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.feedbackButton);
            this.panel1.Controls.Add(this.promotionsButton);
            this.panel1.Controls.Add(this.orderSummary);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 410);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proj_test2.Properties.Resources.cafe_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.MistyRose;
            this.logoutButton.Location = new System.Drawing.Point(0, 314);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(206, 33);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feedbackButton.ForeColor = System.Drawing.Color.MistyRose;
            this.feedbackButton.Location = new System.Drawing.Point(0, 272);
            this.feedbackButton.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(206, 33);
            this.feedbackButton.TabIndex = 3;
            this.feedbackButton.Text = "Feedbacks";
            this.feedbackButton.UseVisualStyleBackColor = false;
            // 
            // promotionsButton
            // 
            this.promotionsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.promotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promotionsButton.ForeColor = System.Drawing.Color.MistyRose;
            this.promotionsButton.Location = new System.Drawing.Point(0, 231);
            this.promotionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(206, 33);
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
            this.orderSummary.Location = new System.Drawing.Point(0, 189);
            this.orderSummary.Margin = new System.Windows.Forms.Padding(2);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(206, 33);
            this.orderSummary.TabIndex = 1;
            this.orderSummary.Text = "Order Summary";
            this.orderSummary.UseVisualStyleBackColor = false;
            this.orderSummary.Click += new System.EventHandler(this.orderSummary_Click_1);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuButton.ForeColor = System.Drawing.Color.MistyRose;
            this.menuButton.Location = new System.Drawing.Point(0, 147);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(206, 33);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Place Order";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(334, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Give us Feedback!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(232, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comments";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // commentsTextbox
            // 
            this.commentsTextbox.Location = new System.Drawing.Point(320, 241);
            this.commentsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.commentsTextbox.Name = "commentsTextbox";
            this.commentsTextbox.Size = new System.Drawing.Size(302, 107);
            this.commentsTextbox.TabIndex = 4;
            this.commentsTextbox.Text = "";
            this.commentsTextbox.TextChanged += new System.EventHandler(this.commentsTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(232, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate us!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // star1
            // 
            this.star1.AutoSize = true;
            this.star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.star1.ForeColor = System.Drawing.Color.Goldenrod;
            this.star1.Location = new System.Drawing.Point(320, 70);
            this.star1.Margin = new System.Windows.Forms.Padding(2);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(38, 29);
            this.star1.TabIndex = 6;
            this.star1.TabStop = true;
            this.star1.Text = "*";
            this.star1.UseVisualStyleBackColor = true;
            // 
            // star2
            // 
            this.star2.AutoSize = true;
            this.star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.star2.ForeColor = System.Drawing.Color.Goldenrod;
            this.star2.Location = new System.Drawing.Point(320, 101);
            this.star2.Margin = new System.Windows.Forms.Padding(2);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(46, 29);
            this.star2.TabIndex = 7;
            this.star2.TabStop = true;
            this.star2.Text = "**";
            this.star2.UseVisualStyleBackColor = true;
            // 
            // star3
            // 
            this.star3.AutoSize = true;
            this.star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.star3.ForeColor = System.Drawing.Color.Goldenrod;
            this.star3.Location = new System.Drawing.Point(320, 130);
            this.star3.Margin = new System.Windows.Forms.Padding(2);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(54, 29);
            this.star3.TabIndex = 8;
            this.star3.TabStop = true;
            this.star3.Text = "***";
            this.star3.UseVisualStyleBackColor = true;
            // 
            // star4
            // 
            this.star4.AutoSize = true;
            this.star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.star4.ForeColor = System.Drawing.Color.Goldenrod;
            this.star4.Location = new System.Drawing.Point(320, 159);
            this.star4.Margin = new System.Windows.Forms.Padding(2);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(62, 29);
            this.star4.TabIndex = 9;
            this.star4.TabStop = true;
            this.star4.Text = "****";
            this.star4.UseVisualStyleBackColor = true;
            // 
            // star5
            // 
            this.star5.AutoSize = true;
            this.star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.star5.ForeColor = System.Drawing.Color.Goldenrod;
            this.star5.Location = new System.Drawing.Point(320, 190);
            this.star5.Margin = new System.Windows.Forms.Padding(2);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(70, 29);
            this.star5.TabIndex = 10;
            this.star5.TabStop = true;
            this.star5.Text = "*****";
            this.star5.UseVisualStyleBackColor = true;
            // 
            // submitReviewButton
            // 
            this.submitReviewButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.submitReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submitReviewButton.ForeColor = System.Drawing.Color.MistyRose;
            this.submitReviewButton.Location = new System.Drawing.Point(400, 350);
            this.submitReviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitReviewButton.Name = "submitReviewButton";
            this.submitReviewButton.Size = new System.Drawing.Size(138, 33);
            this.submitReviewButton.TabIndex = 12;
            this.submitReviewButton.Text = "Submit";
            this.submitReviewButton.UseVisualStyleBackColor = false;
            this.submitReviewButton.Click += new System.EventHandler(this.submitReviewButton_Click_1);
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.AutoSize = true;
            this.characterCountLabel.Location = new System.Drawing.Point(574, 223);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(0, 13);
            this.characterCountLabel.TabIndex = 13;
            // 
            // CustomerFeedbackForm
            // 
            this.AcceptButton = this.feedbackButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 487);
            this.Controls.Add(this.characterCountLabel);
            this.Controls.Add(this.submitReviewButton);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentsTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerFeedbackForm";
            this.Text = "CustomerFeedbackForm";
            this.Load += new System.EventHandler(this.CustomerFeedbackForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel1;
        private Button feedbackButton;
        private Button promotionsButton;
        private Button menuButton;
        private Button orderSummary;
        private Button logoutButton;
        private Label label1;
        private Label label2;
        private RichTextBox commentsTextbox;
        private Label label3;
        private RadioButton star1;
        private RadioButton star2;
        private RadioButton star3;
        private RadioButton star4;
        private RadioButton star5;
        private Button submitReviewButton;
        private PictureBox pictureBox1;
        private Label characterCountLabel;
    }
}



