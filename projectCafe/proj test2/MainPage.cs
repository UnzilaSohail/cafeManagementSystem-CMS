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
namespace CMS

{
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
                CustomizeUI();
            }

            private void CustomizeUI()
            {
                // Set form properties
                this.BackColor = Color.FromArgb(255, 240, 225);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Text = "Welcome to Comrades Cafe";
                this.MaximizeBox = false;

                //// Set button properties
                //signUpButton.BackColor = Color.FromArgb(255, 160, 0);
                //signUpButton.ForeColor = Color.White;
                //signUpButton.Font = new Font("Arial", 12, FontStyle.Bold);
                //signUpButton.FlatAppearance.BorderSize = 0;
                //signUpButton.FlatStyle = FlatStyle.Flat;

                //loginButton.BackColor = Color.FromArgb(30, 144, 255);
                //loginButton.ForeColor = Color.White;
                //loginButton.Font = new Font("Arial", 12, FontStyle.Bold);
                //loginButton.FlatAppearance.BorderSize = 0;
                //loginButton.FlatStyle = FlatStyle.Flat;
            }

            private void signUpButton_Click(object sender, EventArgs e)
            {
                // Navigate to the sign-up form
                SignupForm signUpForm = new SignupForm();
                signUpForm.Show();
            }

            private void loginButton_Click(object sender, EventArgs e)
            {
                // Navigate to the login form
                InitialForm InitialForm = new InitialForm();
            InitialForm.Show();
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    

}