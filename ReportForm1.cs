using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igsit
{
    public partial class ReportForm1 : Form
    {
        public ReportForm1()
        {
            InitializeComponent();
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igsitDBTestDataSet1.T_Persons' table. You can move, or remove it, as needed.
            this.t_PersonsTableAdapter.Fill(this.igsitDBTestDataSet1.T_Persons);

            this.reportViewer1.RefreshReport();
        }
    }
}
