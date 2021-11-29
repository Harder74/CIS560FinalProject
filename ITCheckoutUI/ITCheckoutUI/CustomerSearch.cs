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
            if(radSearchID.Checked)
            {

            }
            else if (radSearchName.Checked)
            {

            }
            else if (radCheckOutDate.Checked)
            {

            }
            else if (radReturnDate.Checked)
            {

            }
            else
            {
                MessageBox.Show("A choice");
            }
        }
    }
}
