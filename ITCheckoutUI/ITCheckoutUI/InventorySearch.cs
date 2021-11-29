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

        }
    }
}
