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
    public partial class EmployeeSearch : Form
    {
        TextBox txtEmployeeFirst = new TextBox();
        TextBox txtEmployeeLast = new TextBox();
        Label lblEmployeeFirst = new Label();
        Label lblEmployeeLast = new Label();
        TextBox txtEmployeeID = new TextBox();
        Label lblEmployeeID = new Label();
        Label lblCheckedOut = new Label();
        DateTimePicker dtpCheckedOut = new DateTimePicker();
        DateTimePicker dtpReturnedOn = new DateTimePicker();
        Label lblReturnedOn = new Label();

        Landing parent;
        SqlConnection sqlConnection;
        public EmployeeSearch(Landing parent, SqlConnection connection)
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

        private void EmployeeSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void radSearchID_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtEmployeeID.Clear();
            pnlSearchConditions2.Width = 244;
            lblEmployeeID.Text = "Employee ID:";
            lblEmployeeID.Height = 25;
            pnlSearchConditions2.Controls.Add(txtEmployeeID);
            pnlSearchConditions1.Controls.Add(lblEmployeeID);
        }

        private void radSearchName_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtEmployeeFirst.Clear();
            txtEmployeeLast.Clear();
            pnlSearchConditions2.Width = 150;
            lblEmployeeFirst.Text = "First Name:";
            lblEmployeeLast.Text = "Last Name:";
            lblEmployeeFirst.Height = 30;
            lblEmployeeLast.Height = 30;
            pnlSearchConditions2.Controls.Add(txtEmployeeFirst);
            pnlSearchConditions1.Controls.Add(lblEmployeeFirst);
            pnlSearchConditions2.Controls.Add(txtEmployeeLast);
            pnlSearchConditions1.Controls.Add(lblEmployeeLast);
        }

        private void radSearchCheckOutDate_CheckedChanged(object sender, EventArgs e)
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

        private void radSearchReturnDate_CheckedChanged(object sender, EventArgs e)
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
                if (txtEmployeeID.Text != string.Empty)
                {
                    string employeeID = txtEmployeeID.Text;
                    try
                    {
                        SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetEmployeeByID", sqlConnection);
                        SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchEmployeeViaIDCmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        SearchEmployeeViaIDCmd.ExecuteNonQuery();

                        var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                        var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Employee ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search employees with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an employee ID");
                }
            }
            else if (radSearchName.Checked)
            {
                if (txtEmployeeFirst.Text != string.Empty && txtEmployeeLast.Text != string.Empty)
                {
                    string employeeFirst = txtEmployeeFirst.Text;
                    string employeeLast = txtEmployeeLast.Text;
                    try
                    {
                        SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetEmployeeByName", sqlConnection);
                        SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchEmployeeViaIDCmd.Parameters.AddWithValue("@FirstName", employeeFirst);
                        SearchEmployeeViaIDCmd.Parameters.AddWithValue("@LastName", employeeLast);

                        SearchEmployeeViaIDCmd.ExecuteNonQuery();

                        var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                        var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Employee ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search employees with given parameters.");
                    }
                }
                else if (txtEmployeeFirst.Text != string.Empty)
                {
                    string employeeFirst = txtEmployeeFirst.Text;
                    try
                    {
                        SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetEmployeeByFirst", sqlConnection);
                        SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchEmployeeViaIDCmd.Parameters.AddWithValue("@FirstName", employeeFirst);

                        SearchEmployeeViaIDCmd.ExecuteNonQuery();

                        var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                        var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Employee ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search employees with given parameters.");
                    }
                }
                else if (txtEmployeeLast.Text != string.Empty)
                {
                    string employeeLast = txtEmployeeLast.Text;
                    try
                    {
                        SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetEmployeeByLast", sqlConnection);
                        SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchEmployeeViaIDCmd.Parameters.AddWithValue("@LastName", employeeLast);

                        SearchEmployeeViaIDCmd.ExecuteNonQuery();

                        var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                        var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                        var firstNameOrdinal = reader.GetOrdinal("FirstName");
                        var lastNameOrdinal = reader.GetOrdinal("LastName");

                        dgvResults.ColumnCount = 3;

                        dgvResults.Columns[0].Name = "Employee ID";
                        dgvResults.Columns[1].Name = "First Name";
                        dgvResults.Columns[2].Name = "Last Name";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                            row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                            row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search employees with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an employee's name.");
                }
            }
            else if (radSearchCheckOutDate.Checked)
            {
                DateTime dt = dtpCheckedOut.Value.Date;
                try
                {
                    SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetECheckedOutOn", sqlConnection);
                    SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                    SearchEmployeeViaIDCmd.Parameters.AddWithValue("@CheckedOutDate", dt);

                    SearchEmployeeViaIDCmd.ExecuteNonQuery();

                    var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                    var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                    var firstNameOrdinal = reader.GetOrdinal("FirstName");
                    var lastNameOrdinal = reader.GetOrdinal("LastName");

                    dgvResults.ColumnCount = 3;

                    dgvResults.Columns[0].Name = "Employee ID";
                    dgvResults.Columns[1].Name = "First Name";
                    dgvResults.Columns[2].Name = "Last Name";

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                        row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                        row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                        dgvResults.Rows.Add(row);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to search employees with given parameters.");
                }
            }
            else if (radSearchReturnDate.Checked)
            {
                DateTime dt = dtpReturnedOn.Value.Date;
                try
                {
                    SqlCommand SearchEmployeeViaIDCmd = new SqlCommand(@"ITDB.IT.GetEReturnedOn", sqlConnection);
                    SearchEmployeeViaIDCmd.CommandType = CommandType.StoredProcedure;
                    SearchEmployeeViaIDCmd.Parameters.AddWithValue("@CheckedOutDate", dt);

                    SearchEmployeeViaIDCmd.ExecuteNonQuery();

                    var reader = SearchEmployeeViaIDCmd.ExecuteReader();

                    var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                    var firstNameOrdinal = reader.GetOrdinal("FirstName");
                    var lastNameOrdinal = reader.GetOrdinal("LastName");

                    dgvResults.ColumnCount = 3;

                    dgvResults.Columns[0].Name = "Employee ID";
                    dgvResults.Columns[1].Name = "First Name";
                    dgvResults.Columns[2].Name = "Last Name";

                    while (reader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells.Add(new DataGridViewTextBoxCell());
                        row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                        row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                        row.Cells[2].Value = reader.GetString(lastNameOrdinal);

                        dgvResults.Rows.Add(row);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to search employees with given parameters.");
                }
            }
            else
            {
                MessageBox.Show("A choice must be made in what search conditions are applied.");
            }
        }

        private void btnMonthlyReports_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            try
            {
                SqlCommand SearchMonthlyReports = new SqlCommand(@"ITDB.IT.GetMonthlyReport", sqlConnection);
                SearchMonthlyReports.CommandType = CommandType.StoredProcedure;
                SearchMonthlyReports.Parameters.AddWithValue("@Month", 11);
                SearchMonthlyReports.Parameters.AddWithValue("@Year", 2021);

                SearchMonthlyReports.ExecuteNonQuery();

                var reader = SearchMonthlyReports.ExecuteReader();

                var employeeIDOrdinal = reader.GetOrdinal("EmployeeID");
                var firstNameOrdinal = reader.GetOrdinal("FirstName");
                var lastNameOrdinal = reader.GetOrdinal("LastName");
                var numberOfCheckouts = reader.GetOrdinal("CheckoutAmmount");

                dgvResults.ColumnCount = 4;

                dgvResults.Columns[0].Name = "Employee ID";
                dgvResults.Columns[1].Name = "First Name";
                dgvResults.Columns[2].Name = "Last Name";
                dgvResults.Columns[3].Name = "Number of Checkouts";

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[0].Value = reader.GetInt32(employeeIDOrdinal);
                    row.Cells[1].Value = reader.GetString(firstNameOrdinal);
                    row.Cells[2].Value = reader.GetString(lastNameOrdinal);
                    row.Cells[3].Value = reader.GetInt32(numberOfCheckouts);

                    dgvResults.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search items.");
            }
        }
    }
}
