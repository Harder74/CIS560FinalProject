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
    public partial class InventorySearch : Form
    {
        TextBox txtItemName = new TextBox();
        Label lblItemName = new Label();
        TextBox txtItemID = new TextBox();
        Label lblItemID = new Label();
        Label lblCustomerID = new Label();
        TextBox txtCustomerID = new TextBox();
        Label lblItemSerialNo = new Label();
        TextBox txtItemSerialNo = new TextBox();
        Label lblItemType = new Label();
        TextBox txtItemType = new TextBox();

        Landing parent;
        SqlConnection sqlConnection;
        public InventorySearch(Landing parent, SqlConnection connection)
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

        private void InventorySearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void radSearchID_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtItemID.Clear();
            pnlSearchConditions2.Width = 244;
            lblItemID.Text = "Item ID:";
            lblItemID.Height = 25;
            pnlSearchConditions2.Controls.Add(txtItemID);
            pnlSearchConditions1.Controls.Add(lblItemID);
        }

        private void radSearchItemName_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtItemName.Clear();
            pnlSearchConditions2.Width = 244;
            lblItemName.Text = "Item Name:";
            lblItemName.Height = 25;
            pnlSearchConditions2.Controls.Add(txtItemName);
            pnlSearchConditions1.Controls.Add(lblItemName);
        }

        private void radSearchSerialNumber_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtItemSerialNo.Clear();
            pnlSearchConditions2.Width = 244;
            lblItemSerialNo.Text = "Serial No:";
            lblItemSerialNo.Height = 25;
            pnlSearchConditions2.Controls.Add(txtItemSerialNo);
            pnlSearchConditions1.Controls.Add(lblItemSerialNo);
        }

        private void radSearchItemType_CheckedChanged(object sender, EventArgs e)
        {
            pnlSearchConditions1.Controls.Clear();
            pnlSearchConditions2.Controls.Clear();
            txtItemType.Clear();
            pnlSearchConditions2.Width = 244;
            lblItemType.Text = "Item Type:";
            lblItemType.Height = 25;
            pnlSearchConditions2.Controls.Add(txtItemType);
            pnlSearchConditions1.Controls.Add(lblItemType);
        }

        private void radSearchCustomerID_CheckedChanged(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            if (radSearchID.Checked)
            {
                if (txtItemID.Text != string.Empty)
                {
                    string itemID = txtItemID.Text;
                    try
                    {
                        SqlCommand SearchItemViaIDCmd = new SqlCommand(@"ITDB.IT.GetItemByID", sqlConnection);
                        SearchItemViaIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchItemViaIDCmd.Parameters.AddWithValue("@ItemID", itemID);

                        SearchItemViaIDCmd.ExecuteNonQuery();

                        var reader = SearchItemViaIDCmd.ExecuteReader();

                        var itemNameOrdinal = reader.GetOrdinal("ItemName");
                        var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                        var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                        var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                        var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                        dgvResults.ColumnCount = 5;

                        dgvResults.Columns[0].Name = "Item Name";
                        dgvResults.Columns[1].Name = "Serial Number";
                        dgvResults.Columns[2].Name = "Item Type";
                        dgvResults.Columns[3].Name = "IsCheckedOut";
                        dgvResults.Columns[4].Name = "IsRemoved";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                            row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                            row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                            row.Cells[3].Value = reader.GetBoolean(isCheckedOutOrdinal);
                            row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search items with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an item ID");
                }
            }
            else if (radSearchItemName.Checked)
            {
                if (txtItemName.Text != string.Empty)
                {
                    string itemName = txtItemName.Text;
                    try
                    {
                        SqlCommand SearchItemViaNameCmd = new SqlCommand(@"ITDB.IT.GetItemsByItemName", sqlConnection);
                        SearchItemViaNameCmd.CommandType = CommandType.StoredProcedure;
                        SearchItemViaNameCmd.Parameters.AddWithValue("@ItemName", itemName);

                        SearchItemViaNameCmd.ExecuteNonQuery();

                        var reader = SearchItemViaNameCmd.ExecuteReader();

                        var itemNameOrdinal = reader.GetOrdinal("ItemName");
                        var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                        var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                        var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                        var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                        dgvResults.ColumnCount = 5;

                        dgvResults.Columns[0].Name = "Item Name";
                        dgvResults.Columns[1].Name = "Serial Number";
                        dgvResults.Columns[2].Name = "Item Type";
                        dgvResults.Columns[3].Name = "IsCheckedOut";
                        dgvResults.Columns[4].Name = "IsRemoved";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                            row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                            row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                            row.Cells[3].Value = reader.GetBoolean(isRemovedOrdinal);
                            row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search items with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an item name.");
                }
            }
            else if (radSearchSerialNumber.Checked)
            {
                if (txtItemSerialNo.Text != string.Empty)
                {
                    string itemSerialNo = txtItemSerialNo.Text;
                    try
                    {
                        SqlCommand SearchItemViaSerialNoCmd = new SqlCommand(@"ITDB.IT.GetItemBySerialNumber", sqlConnection);
                        SearchItemViaSerialNoCmd.CommandType = CommandType.StoredProcedure;
                        SearchItemViaSerialNoCmd.Parameters.AddWithValue("@SerialNumber", itemSerialNo);

                        SearchItemViaSerialNoCmd.ExecuteNonQuery();

                        var reader = SearchItemViaSerialNoCmd.ExecuteReader();

                        var itemNameOrdinal = reader.GetOrdinal("ItemName");
                        var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                        var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                        var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                        var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                        dgvResults.ColumnCount = 5;

                        dgvResults.Columns[0].Name = "Item Name";
                        dgvResults.Columns[1].Name = "Serial Number";
                        dgvResults.Columns[2].Name = "Item Type";
                        dgvResults.Columns[3].Name = "IsCheckedOut";
                        dgvResults.Columns[4].Name = "IsRemoved";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                            row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                            row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                            row.Cells[3].Value = reader.GetBoolean(isRemovedOrdinal);
                            row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search items with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an item serial number.");
                }
            }
            else if (radSearchItemType.Checked)
            {
                if (txtItemType.Text != string.Empty)
                {
                    string itemType = txtItemType.Text;
                    try
                    {
                        SqlCommand SearchItemViaTypeCmd = new SqlCommand(@"ITDB.IT.GetItemsByItemType", sqlConnection);
                        SearchItemViaTypeCmd.CommandType = CommandType.StoredProcedure;
                        SearchItemViaTypeCmd.Parameters.AddWithValue("@ItemType", itemType);

                        SearchItemViaTypeCmd.ExecuteNonQuery();

                        var reader = SearchItemViaTypeCmd.ExecuteReader();

                        var itemNameOrdinal = reader.GetOrdinal("ItemName");
                        var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                        var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                        var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                        var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                        dgvResults.ColumnCount = 5;

                        dgvResults.Columns[0].Name = "Item Name";
                        dgvResults.Columns[1].Name = "Serial Number";
                        dgvResults.Columns[2].Name = "Item Type";
                        dgvResults.Columns[3].Name = "IsCheckedOut";
                        dgvResults.Columns[4].Name = "IsRemoved";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                            row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                            row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                            row.Cells[3].Value = reader.GetBoolean(isRemovedOrdinal);
                            row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search items with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an item type.");
                }
            }
            else if (radSearchCustomerID.Checked)
            {
                if (txtCustomerID.Text != string.Empty)
                {
                    string customerID = txtCustomerID.Text;
                    try
                    {
                        SqlCommand SearchItemViaCustomerIDCmd = new SqlCommand(@"ITDB.IT.GetItemsByCheckedOutCID", sqlConnection);
                        SearchItemViaCustomerIDCmd.CommandType = CommandType.StoredProcedure;
                        SearchItemViaCustomerIDCmd.Parameters.AddWithValue("@CustomerID", customerID);

                        SearchItemViaCustomerIDCmd.ExecuteNonQuery();

                        var reader = SearchItemViaCustomerIDCmd.ExecuteReader();

                        var itemNameOrdinal = reader.GetOrdinal("ItemName");
                        var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                        var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                        var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                        var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                        dgvResults.ColumnCount = 5;

                        dgvResults.Columns[0].Name = "Item Name";
                        dgvResults.Columns[1].Name = "Serial Number";
                        dgvResults.Columns[2].Name = "Item Type";
                        dgvResults.Columns[3].Name = "IsCheckedOut";
                        dgvResults.Columns[4].Name = "IsRemoved";

                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells.Add(new DataGridViewTextBoxCell());
                            row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                            row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                            row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                            row.Cells[3].Value = reader.GetBoolean(isRemovedOrdinal);
                            row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                            dgvResults.Rows.Add(row);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to search items with given parameters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a customer ID.");
                }
            }
            else
            {
                MessageBox.Show("A choice must be made in what search conditions are applied.");
            }
        }

        private void btnShowItemPopularity_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            try
            {
                SqlCommand SearchItemViaCustomerIDCmd = new SqlCommand(@"ITDB.IT.GetPopOfItems", sqlConnection);
                SearchItemViaCustomerIDCmd.CommandType = CommandType.StoredProcedure;

                SearchItemViaCustomerIDCmd.ExecuteNonQuery();

                var reader = SearchItemViaCustomerIDCmd.ExecuteReader();

                var itemIDOrdinal = reader.GetOrdinal("ItemID");
                var itemNameOrdinal = reader.GetOrdinal("ItemName");
                var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                var numberOfCheckoutsOrdinal = reader.GetOrdinal("NumberOfCheckouts");

                dgvResults.ColumnCount = 4;

                dgvResults.Columns[0].Name = "Item ID";
                dgvResults.Columns[1].Name = "Item Name";
                dgvResults.Columns[2].Name = "Serial Number";
                dgvResults.Columns[3].Name = "Number of Checkouts";

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[0].Value = reader.GetInt32(itemIDOrdinal);
                    row.Cells[1].Value = reader.GetString(itemNameOrdinal);
                    row.Cells[2].Value = reader.GetString(serialNumberOrdinal);
                    row.Cells[3].Value = reader.GetInt32(numberOfCheckoutsOrdinal);

                    dgvResults.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search items.");
            }
        }

        private void btnShowAvailableItems_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            try
            {
                SqlCommand SearchItemViaCustomerIDCmd = new SqlCommand(@"ITDB.IT.GetItemsByCheckedOut", sqlConnection);
                SearchItemViaCustomerIDCmd.CommandType = CommandType.StoredProcedure;
                SearchItemViaCustomerIDCmd.Parameters.AddWithValue("@IsCheckedOut", 0);

                SearchItemViaCustomerIDCmd.ExecuteNonQuery();

                var reader = SearchItemViaCustomerIDCmd.ExecuteReader();

                var itemNameOrdinal = reader.GetOrdinal("ItemName");
                var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                dgvResults.ColumnCount = 5;

                dgvResults.Columns[0].Name = "Item Name";
                dgvResults.Columns[1].Name = "Serial Number";
                dgvResults.Columns[2].Name = "Item Type";
                dgvResults.Columns[3].Name = "IsCheckedOut";
                dgvResults.Columns[4].Name = "IsRemoved";

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                    row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                    row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                    row.Cells[3].Value = reader.GetBoolean(isRemovedOrdinal);
                    row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

                    dgvResults.Rows.Add(row);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search items.");
            }
        }

        private void btnShowCheckedOutItems_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();
            try
            {
                SqlCommand SearchItemViaCustomerIDCmd = new SqlCommand(@"ITDB.IT.GetItemsByCheckedOut", sqlConnection);
                SearchItemViaCustomerIDCmd.CommandType = CommandType.StoredProcedure;
                SearchItemViaCustomerIDCmd.Parameters.AddWithValue("@IsCheckedOut", 1);

                SearchItemViaCustomerIDCmd.ExecuteNonQuery();

                var reader = SearchItemViaCustomerIDCmd.ExecuteReader();

                var itemNameOrdinal = reader.GetOrdinal("ItemName");
                var serialNumberOrdinal = reader.GetOrdinal("SerialNumber");
                var itemTypeOrdinal = reader.GetOrdinal("ItemType");
                var isCheckedOutOrdinal = reader.GetOrdinal("IsCheckedOut");
                var isRemovedOrdinal = reader.GetOrdinal("IsRemoved");

                dgvResults.ColumnCount = 5;

                dgvResults.Columns[0].Name = "Item Name";
                dgvResults.Columns[1].Name = "Serial Number";
                dgvResults.Columns[2].Name = "Item Type";
                dgvResults.Columns[3].Name = "IsCheckedOut";
                dgvResults.Columns[4].Name = "IsRemoved";

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[0].Value = reader.GetString(itemNameOrdinal);
                    row.Cells[1].Value = reader.GetString(serialNumberOrdinal);
                    row.Cells[2].Value = reader.GetString(itemTypeOrdinal);
                    row.Cells[3].Value = reader.GetBoolean(isCheckedOutOrdinal);
                    row.Cells[4].Value = reader.GetBoolean(isRemovedOrdinal);

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
