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
    public partial class Landing : Form
    {
        SqlConnection properConnection;
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            SqlConnection originConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDb;Database=master");

            SqlCommand databaseCreationCmd = new SqlCommand(File.ReadAllText(@"..\..\DB-Schema\DatabaseCreation.sql"), originConnection);

            originConnection.Open();

            databaseCreationCmd.ExecuteNonQuery();

            properConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDb;Database=ITDB");

            SqlCommand schemaCreationCmd = new SqlCommand(File.ReadAllText(@"..\..\DB-Schema\SchemaCreation.sql"), properConnection);

            properConnection.Open();

            schemaCreationCmd.ExecuteNonQuery();
            
            SqlCommand tableCreationCmd = new SqlCommand(File.ReadAllText(@"..\..\Tables\TableCreationQuery.sql"), properConnection);

            tableCreationCmd.ExecuteNonQuery();
            
        }

        public void ReturnToLanding(Form child)
        {
            this.Show();
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearch customerSearch = new CustomerSearch(this, properConnection);
            customerSearch.Show();
        }

        private void btnSearchEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSearch employeeSearch = new EmployeeSearch(this, properConnection);
            employeeSearch.Show();
        }

        private void btnSearchInventoryItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventorySearch inventorySearch = new InventorySearch(this, properConnection);
            inventorySearch.Show();
        }

        private void btnCheckoutItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutItem checkoutItem = new CheckoutItem(this, properConnection);
            checkoutItem.Show();
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnItem returnItem = new ReturnItem(this, properConnection);
            returnItem.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItem addItem = new AddItem(this, properConnection);
            addItem.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCustomer = new AddCustomer(this, properConnection);
            addCustomer.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee(this, properConnection);
            addEmployee.Show();
        }

        private void Landing_FormClosed(object sender, FormClosedEventArgs e)
        {
            properConnection.Close();
            Application.Exit();
        }
    }
}