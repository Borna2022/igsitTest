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
        CurrencyManager cr;

        public RegPersonForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegPersonForm_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Data Source=DESKTOP-HOJA8V1;Initial Catalog=igsitDBTest;Integrated Security=True";
            conn.Open();
            fillgrid();
        }
        void fillgrid(string s = "select * from T_Persons")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            da.SelectCommand = cmd1;
            ds.Clear();
            da.Fill(ds,"T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("Datasource", ds, "T1");
            txtpersoncode.DataBindings.Clear();
            txtpersoncode.DataBindings.Add("text", ds, "T1.fprs_personCode");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("text", ds, "T1.fprs_Name");
            txtlastname.DataBindings.Clear();
            txtlastname.DataBindings.Add("text", ds, "T1.fprs_LastName");
            txtvin.DataBindings.Clear();
            txtvin.DataBindings.Add("text", ds, "T1.fprs_VinCode");
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            cr.Position = 0;
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            cr.Position--;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            cr.Position = cr.Count - 1;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            cr.Position++;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtpersoncode.ReadOnly = false;
            txtname.ReadOnly = false;
            txtlastname.ReadOnly = false;
            txtvin.ReadOnly = false;
            txtpersoncode.Text = "";
            txtname.Text = "";
            txtlastname.Text = "";
            txtvin.Text = "";
            btnnew.Enabled = false;
            btnsave.Enabled = true;
            txtpersoncode.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "insert into T_Persons values(@p1,@p2,@p3,@p4)";
            c1.Parameters.AddWithValue("p1", txtpersoncode.Text);
            c1.Parameters.AddWithValue("p2", txtname.Text);
            c1.Parameters.AddWithValue("p3", txtlastname.Text);
            c1.Parameters.AddWithValue("p4", txtvin.Text);
            c1.Connection = conn;
            c1.ExecuteNonQuery();
            btnsave.Enabled = false;
            btnnew.Enabled = true;
            txtpersoncode.ReadOnly = true;
            txtname.ReadOnly = true;
            txtlastname.ReadOnly = true;
            txtvin.ReadOnly = true;
            fillgrid();
        }
    }
}
