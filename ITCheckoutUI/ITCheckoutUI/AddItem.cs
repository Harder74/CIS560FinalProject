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
    public partial class AddItem : Form
    {
        Landing parent;
        SqlConnection sqlConnection;
        public AddItem(Landing parent, SqlConnection connection)
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

        private void AddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ReturnToLanding(this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != string.Empty && txtSerialNo.Text != string.Empty && txtItemType.Text != string.Empty)
            {
                string name = txtItemName.Text;
                string serial = txtSerialNo.Text;
                string type = txtItemType.Text;
                int checkedOut = 0;
                int IsRemoved = 0;
                try
                {
                    SqlCommand AddItemCmd = new SqlCommand(@"ITDB.IT.AddItem", sqlConnection);
                    AddItemCmd.CommandType = CommandType.StoredProcedure;
                    AddItemCmd.Parameters.AddWithValue("@ItemName", name);
                    AddItemCmd.Parameters.AddWithValue("@SerialNumber", serial);
                    AddItemCmd.Parameters.AddWithValue("@ItemType", type);
                    AddItemCmd.Parameters.AddWithValue("@IsCheckedOut", checkedOut);
                    AddItemCmd.Parameters.AddWithValue("@IsRemoved", IsRemoved);
                    AddItemCmd.Parameters.AddWithValue("@ItemID", 0);

                    AddItemCmd.ExecuteNonQuery();

                    MessageBox.Show("Item added successfully!");
                    parent.ReturnToLanding(this);
                    this.Close();
                }
                catch (SqlException sql)
                {
                    MessageBox.Show("Item already exists");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Item");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled in to add item.");
            }
        }
    }
}
