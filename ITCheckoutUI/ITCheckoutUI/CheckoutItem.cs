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
    public partial class CheckoutItem : Form
    {
        Landing parent;
        SqlConnection sqlConnection;
        public CheckoutItem(Landing parent, SqlConnection connection)
        {
            InitializeComponent();
            this.parent = parent;
            sqlConnection = connection;
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            parent.ReturnToLanding(this);
            this.Close();
        }

        private void CheckoutItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != string.Empty && txtEmployeeID.Text != string.Empty && txtItemID.Text != string.Empty)
            {
                string itemID = txtItemID.Text;
                string employeeID = txtEmployeeID.Text;
                string customerID = txtCustomerID.Text;
                string checkOutID = "0";
                try
                {
                    SqlCommand AddCheckoutCmd = new SqlCommand(@"ITDB.IT.AddCheckout", sqlConnection);
                    AddCheckoutCmd.CommandType = CommandType.StoredProcedure;
                    AddCheckoutCmd.Parameters.AddWithValue("@ItemID", itemID);
                    AddCheckoutCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    AddCheckoutCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    AddCheckoutCmd.Parameters.AddWithValue("@CheckoutID", checkOutID);

                    AddCheckoutCmd.ExecuteNonQuery();

                    MessageBox.Show("Checkout created successfully!");
                    parent.ReturnToLanding(this);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only numeric values should be entered.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in to make a checkout.");
            }
        }
    }
}
