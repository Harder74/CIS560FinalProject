using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCheckoutUI
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("password"))
            {
                Landing landing = new Landing();
                this.Hide();
                landing.Show();
            }
            else
            {
                MessageBox.Show("The username/password combination you have entered is incorrect.");
            }
        }
    }
}
