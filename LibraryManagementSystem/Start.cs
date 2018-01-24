using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1;
            f1 = new AddMem();
            f1.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1;
            f1 = new AddBook();
            f1.Show();
            this.Hide(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1;
            f1 = new IssueBook();
            f1.Show();
            this.Hide(); 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
