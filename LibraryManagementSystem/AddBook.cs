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
    public partial class AddBook : Form
    {
        public AddBook()
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
            query = "insert into book(bname,quantity)values('" + textBox1.Text + "',"+textBox2.Text+")";
            OleDbCommand cmd;
            cmd = new OleDbCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Book added with appropriate number of copies", "Book Add confirmation"); 
        }
    }
}
