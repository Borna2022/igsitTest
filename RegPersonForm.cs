using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igsit
{
    public partial class RegPersonForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public RegPersonForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegPersonForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source = borna; Initial Catalog = igsitDBTest; Integrated Security = True;";
            conn.Open();
            fillgrid();
        }
        void fillgrid(string s = "select * from T_Persons")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            da.SelectCommand = cmd1;
            da.Fill(ds,"T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("Datasource", ds, "T1");
        }
    }
}
