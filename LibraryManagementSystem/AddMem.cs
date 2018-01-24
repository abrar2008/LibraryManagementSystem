using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace LibraryManagementSystem
{
    public partial class AddMem : Form
    {
        public AddMem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            path = "provider=microsoft.jet.oledb.4.0;data source=d:\\LMS.mdb"; 
            OleDbConnection conn = new OleDbConnection(path);
            conn.Open();
            string query;
            query = "insert into member(mname)values('" + textBox1.Text + "')";
            OleDbCommand cmd;
            cmd = new OleDbCommand(query,conn); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Member has been added","Member Add confirmation"); 

        }
    }
}
