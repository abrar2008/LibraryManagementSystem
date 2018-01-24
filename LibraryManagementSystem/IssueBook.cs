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
    public partial class IssueBook : Form
    {
        int bid, mid;
        OleDbDataReader reader, reader1;  
            
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            string path;
            path = "provider=microsoft.jet.oledb.4.0;data source=d:\\LMS.mdb";
            OleDbConnection conn = new OleDbConnection(path);
            conn.Open();
            string query;
            query = "select * from Book";
            OleDbCommand cmd;
            cmd = new OleDbCommand(query, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
               comboBox1.Items.Add(reader.GetString(1)); 
            
            }
            OleDbConnection conn1 = new OleDbConnection(path);
            conn1.Open();
            string query1;
            query1 = "select * from Member";
            OleDbCommand cmd1;
            cmd1 = new OleDbCommand(query1, conn);
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox2.Items.Add(reader1.GetString(1));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bid = reader.GetInt16(0);
            mid = reader1.GetInt16(0);
            MessageBox.Show(bid + "  " + mid); 
        }
    }
}
