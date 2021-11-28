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
    }
}
