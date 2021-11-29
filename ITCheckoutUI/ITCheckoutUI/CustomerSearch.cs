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
    public partial class CustomerSearch : Form
    {
        TextBox txtCustomerFirst = new TextBox();
        TextBox txtCustomerLast = new TextBox();
        Label lblCustomerFirst = new Label();
        Label lblCustomerLast = new Label();
        TextBox txtCustomerID = new TextBox();
        Label lblCustomerID = new Label();
        Label lblCheckedOut = new Label();
        DateTimePicker dtpCheckedOut = new DateTimePicker();
        DateTimePicker dtpReturnedOn = new DateTimePicker();
        Label lblReturnedOn = new Label();
        
        Landing parent;
        SqlConnection sqlConnection;

        public CustomerSearch(Landing parent, SqlConnection connection)
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

        private void CustomerSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void radSearchID_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtCustomerID.Clear();
            pnlSearchConditions2.Width = 244;
            lblCustomerID.Text = "Customer ID:";
            lblCustomerID.Height = 25;
            pnlSearchConditions2.Controls.Add(txtCustomerID);
            pnlSearchConditions1.Controls.Add(lblCustomerID);
        }

        private void radSearchName_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtCustomerFirst.Clear();
            txtCustomerLast.Clear();
            pnlSearchConditions2.Width = 150;
            lblCustomerFirst.Text = "First Name:";
            lblCustomerLast.Text = "Last Name:";
            lblCustomerFirst.Height = 30;
            lblCustomerLast.Height = 30;
            pnlSearchConditions2.Controls.Add(txtCustomerFirst);
            pnlSearchConditions1.Controls.Add(lblCustomerFirst);
            pnlSearchConditions2.Controls.Add(txtCustomerLast);
            pnlSearchConditions1.Controls.Add(lblCustomerLast);
        }

        private void radCheckOutDate_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            dtpCheckedOut.Value = DateTime.Now;
            pnlSearchConditions2.Width = 244;
            lblCheckedOut.Text = "Date Checked Out:";
            lblCheckedOut.Height = 30;
            pnlSearchConditions2.Controls.Add(dtpCheckedOut);
            pnlSearchConditions1.Controls.Add(lblCheckedOut);
        }

        private void radReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            dtpReturnedOn.Value = DateTime.Now;
            pnlSearchConditions2.Width = 244;
            lblReturnedOn.Text = "Date Returned On:";
            lblReturnedOn.Height = 30;
            pnlSearchConditions2.Controls.Add(dtpReturnedOn);
            pnlSearchConditions1.Controls.Add(lblReturnedOn);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            if (radSearchID.Checked)
            {
                if (txtCustomerID.Text != string.Empty)
                {
                    string customerID = txtCustomerID.Text;
                    try
                    {
                        SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCustomerByID", sqlConnection);
                        SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchCustomerViaIDCmd.Parameters.AddWithValue("@CustomerID", customerID);

                        SearchCustomerViaIDCmd.ExecuteNonQuery();

                        var reader = SearchCustomerViaIDCmd.ExecuteReader();

                        var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Customer ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search customers with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer ID");
                }
            }
            else if (radSearchName.Checked)
            {
                if (txtCustomerFirst.Text != string.Empty && txtCustomerLast.Text != string.Empty)
                {
                    string customerFirst = txtCustomerFirst.Text;
                    string customerLast = txtCustomerLast.Text;
                    
                    try
                    {
                        SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCustomerByName", sqlConnection);
                        SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchCustomerViaIDCmd.Parameters.AddWithValue("@FirstName", customerFirst);
                        SearchCustomerViaIDCmd.Parameters.AddWithValue("@LastName", customerLast);

                        SearchCustomerViaIDCmd.ExecuteNonQuery();

                        var reader = SearchCustomerViaIDCmd.ExecuteReader();

                        var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Customer ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search customers with given parameters.");
                    }
                }
                else if (txtCustomerFirst.Text != string.Empty)
                {
                    string customerFirst = txtCustomerFirst.Text;
                    try
                    {
                        SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCustomerByFirst", sqlConnection);
                        SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchCustomerViaIDCmd.Parameters.AddWithValue("@FirstName", customerFirst);

                        SearchCustomerViaIDCmd.ExecuteNonQuery();

                        var reader = SearchCustomerViaIDCmd.ExecuteReader();

                        var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Customer ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search customers with given parameters.");
                    }
                }
                else if (txtCustomerLast.Text != string.Empty)
                {
                    string customerLast = txtCustomerLast.Text;
                    try
                    {
                        SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCustomerByLast", sqlConnection);
                        SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchCustomerViaIDCmd.Parameters.AddWithValue("@LastName", customerLast);

                        SearchCustomerViaIDCmd.ExecuteNonQuery();

                        var reader = SearchCustomerViaIDCmd.ExecuteReader();

                        var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Customer ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search customers with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer ID");
                }
            }
            else if (radCheckOutDate.Checked)
            {
                DateTime dt = dtpCheckedOut.Value.Date;
                try
                {
                    SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCCheckedOutOn", sqlConnection);
                    SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                    SearchCustomerViaIDCmd.Parameters.AddWithValue("@CheckedOutDate", dt);

                    SearchCustomerViaIDCmd.ExecuteNonQuery();

                    var reader = SearchCustomerViaIDCmd.ExecuteReader();

                    var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                    var firstNameOrdinal = reader.GetOrdinal("FirstName");
                    var lastNameOrdinal = reader.GetOrdinal("LastName");

                    dgvResults.ColumnCount = 3;

                    dgvResults.Columns[0].Name = "Customer ID";
                    dgvResults.Columns[1].Name = "First Name";
                    dgvResults.Columns[2].Name = "Last Name";

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                        row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                        row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                        dgvResults.Rows.Add(row);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to search customers with given parameters.");
                }
            }
            else if (radReturnDate.Checked)
            {
                DateTime dt = dtpReturnedOn.Value.Date;
                try
                {
                    SqlCommand SearchCustomerViaIDCmd = new SqlCommand(@"ITDB.IT.GetCReturnedOn", sqlConnection);
                    SearchCustomerViaIDCmd.CommandType = CommandType.StoredProcedure;
                    SearchCustomerViaIDCmd.Parameters.AddWithValue("@CheckedOutDate", dt);

                    SearchCustomerViaIDCmd.ExecuteNonQuery();

                    var reader = SearchCustomerViaIDCmd.ExecuteReader();

                    var customerIDOrdinal = reader.GetOrdinal("CustomerID");
                    var firstNameOrdinal = reader.GetOrdinal("FirstName");
                    var lastNameOrdinal = reader.GetOrdinal("LastName");

                    dgvResults.ColumnCount = 3;

                    dgvResults.Columns[0].Name = "Customer ID";
                    dgvResults.Columns[1].Name = "First Name";
                    dgvResults.Columns[2].Name = "Last Name";

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[0].Value = reader.GetInt32(customerIDOrdinal);
                        row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                        row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                        dgvResults.Rows.Add(row);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to search customers with given parameters.");
                }
            }
            else
            {
                MessageBox.Show("A choice must be made in what search conditions are applied.");
            }
        }
    }
}