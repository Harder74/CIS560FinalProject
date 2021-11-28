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
using System.IO;

namespace ITCheckoutUI
{
    public partial class AddCustomer : Form
    {
        Landing parent;
        SqlConnection connection;
        public AddCustomer(Landing parent, SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.parent = parent;
            connection = sqlConnection;
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            parent.ReturnToLanding(this);
            this.Close();
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string first = txtFirstName.Text;
            string last = txtLastName.Text;

            //alternate route for a similar error
            /*
            SqlCommand AddCustomerCmd = new SqlCommand(File.ReadAllText(@"..\..\Procedures\IT.AddCustomer.sql"), connection);
            AddCustomerCmd.CommandText = @"IT.AddCustomer"
            AddCustomerCmd.CommandType = CommandType.StoredProcedure;
            AddCustomerCmd.Parameters.AddWithValue("@FirstName", first);
            AddCustomerCmd.Parameters.AddWithValue("@LastName", last);
            
            AddCustomerCmd.ExecuteNonQuery();
            */

            
            SqlCommand AddCustomerCmd = new SqlCommand(File.ReadAllText(@"..\..\Procedures\IT.AddCustomer.sql"), connection);
            
            AddCustomerCmd.Parameters.AddWithValue("FirstName", first);
            AddCustomerCmd.Parameters.AddWithValue("LastName", last);
            
            AddCustomerCmd.ExecuteNonQuery();

            MessageBox.Show("Customer added successfully!");
        }
    }
}
