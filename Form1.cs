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

namespace igsit
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RegPersonForm RegPersonForm = new RegPersonForm();
            RegPersonForm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RegPenalty RegPenaltyForm = new RegPenalty();
            RegPenaltyForm.Show();
        }
    }
}
