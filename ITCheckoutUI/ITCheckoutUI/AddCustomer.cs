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

            //fixed with notes
            //need CommandText line if you use the file syntax, or can call directly using sqlcommand
            //the procedure cannot have .sql attachted 
            //Need command type included
            //need Identity to be included in the queriy
            try
            {
                SqlCommand AddCustomerCmd = new SqlCommand(@"ITDB.IT.AddCustomer", connection);
                //AddCustomerCmd.CommandText = @"ITDB.IT.AddCustomer";
                AddCustomerCmd.CommandType = CommandType.StoredProcedure;
                AddCustomerCmd.Parameters.AddWithValue("@FirstName", first);
                AddCustomerCmd.Parameters.AddWithValue("@LastName", last);
                AddCustomerCmd.Parameters.AddWithValue("@CustomerID", 0);

                AddCustomerCmd.ExecuteNonQuery();

                MessageBox.Show("Customer added successfully!");
            }
            catch(SqlException sql)
            {
                MessageBox.Show("Customer Already in Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add Customer");
            }
        }
    }
}
