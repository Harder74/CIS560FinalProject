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
    public partial class AddEmployee : Form
    {
        Landing parent;
        SqlConnection sqlConnection;
        public AddEmployee(Landing parent, SqlConnection connection)
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

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty)
            {
                string first = txtFirstName.Text;
                string last = txtLastName.Text;
                try
                {
                    SqlCommand AddEmployeeCmd = new SqlCommand(@"ITDB.IT.AddEmployee", sqlConnection);
                    AddEmployeeCmd.CommandType = CommandType.StoredProcedure;
                    AddEmployeeCmd.Parameters.AddWithValue("@FirstName", first);
                    AddEmployeeCmd.Parameters.AddWithValue("@LastName", last);
                    AddEmployeeCmd.Parameters.AddWithValue("@EmployeeID", 0);

                    AddEmployeeCmd.ExecuteNonQuery();

                    MessageBox.Show("Employee added successfully!");
                    parent.ReturnToLanding(this);
                    this.Close();
                }
                catch (SqlException sql)
                {
                    MessageBox.Show(sql.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Employee");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in to add employee.");
            }
        }
    }
}
