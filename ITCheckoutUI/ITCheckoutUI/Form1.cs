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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDb;Database=testing");
            

            SqlCommand command = new SqlCommand("IT.TestProcedure", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            string result = command.ExecuteScalar().ToString();

            testOutput.Text = result;
        }
    }
}
