//using CMS.UI_Forms;
//using proj_test2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.UI_Forms
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }


        private void cafeName_Click(object sender, EventArgs e)
        {

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void customerLoginButton_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("customer");
            this.Hide();
            loginForm.Show();
        }

        private void employeeLoginButton_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm("employee");
            this.Hide();
            loginForm.Show();
        }
    }
}
