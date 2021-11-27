using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITCheckoutUI
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDb;Database=testing");
            

            SqlCommand command = new SqlCommand("IT.TestProcedure", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            string result = command.ExecuteScalar().ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("password"))
            {

            }
            else
            {
                MessageBox.Show("The username/password combination you have entered is incorrect.");
            }
        }
    }
}
