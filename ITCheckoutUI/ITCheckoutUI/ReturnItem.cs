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
    public partial class ReturnItem : Form
    {
        Landing parent;
        SqlConnection sqlConnection;
        public ReturnItem(Landing parent, SqlConnection connection)
        {
            InitializeComponent();
            this.parent = parent;
            this.sqlConnection = connection;
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            parent.ReturnToLanding(this);
            this.Close();
        }

        private void ReturnItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCheckoutID.Text != string.Empty && txtEmployeeID.Text != string.Empty)
            {
                string checkoutID = txtCheckoutID.Text;
                string employeeID = txtEmployeeID.Text;
                string returnID = "0";
                try
                {
                    SqlCommand AddCheckoutCmd = new SqlCommand(@"ITDB.IT.AddReturn", sqlConnection);
                    AddCheckoutCmd.CommandType = CommandType.StoredProcedure;
                    AddCheckoutCmd.Parameters.AddWithValue("@CheckoutID", checkoutID);
                    AddCheckoutCmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    var p = AddCheckoutCmd.Parameters.Add("@ReturnID", SqlDbType.Int);
                    p.Direction = ParameterDirection.Output;

                    AddCheckoutCmd.ExecuteNonQuery();

                    SqlCommand ChangeCheckoutStatusCmd = new SqlCommand(@"ITDB.IT.ItemReturned", sqlConnection);
                    ChangeCheckoutStatusCmd.CommandType = CommandType.StoredProcedure;
                    ChangeCheckoutStatusCmd.Parameters.AddWithValue("@ReturnedID", AddCheckoutCmd.Parameters["@ReturnId"].Value);

                    ChangeCheckoutStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Return created successfully!");
                    parent.ReturnToLanding(this);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only numeric values should be entered. Checkout ID entered must exist.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in to make a return.");
            }
        }
    }
}
