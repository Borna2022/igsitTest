using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igsit
{
    public partial class RegPersonForm : Form
    {
        SqlConnection conn; //= new SqlConnection();
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
            conn = DatabaseHelper.GetConnection();
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
            dgvtpersons.DataBindings.Clear();
            dgvtpersons.DataBindings.Add("Datasource", ds, "T1");
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
        //first record
        private void btnfirst_Click(object sender, EventArgs e)
        {
            cr.Position = 0;
        }
        //previous record
        private void btnprevious_Click(object sender, EventArgs e)
        {
            cr.Position--;
        }
        //last record
        private void btnlast_Click(object sender, EventArgs e)
        {
            cr.Position = cr.Count - 1;
        }
        //next record
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


        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Do you want to delete " + txtname.Text + " " + txtlastname.Text , "Warning",MessageBoxButtons.YesNo );
            if (x == DialogResult.No)
                return;
            SqlCommand c2= new SqlCommand();
            c2.CommandText = "delete from  T_Persons where fprs_personCode=@p1 ";
            c2.Parameters.AddWithValue("p1", txtpersoncode.Text);
            c2.Connection=conn;
            c2.ExecuteNonQuery();
            fillgrid();
        }

        private void dgvtpersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text == "ویرایش")
            {
                txtpersoncode.ReadOnly = true;
                txtname.ReadOnly = false;
                txtlastname.ReadOnly = false;
                txtvin.ReadOnly = false;
                btnedit.Text = "اعمال تغییرات";
                txtname.Focus();

            }
            else
            {
                SqlCommand c3= new SqlCommand();
                c3.CommandText = "update T_Persons set fprs_Name=@p1,fprs_LastName=@p2, fprs_VinCode=@p3 where fprs_personCode=@p4 ";
                c3.Parameters.AddWithValue("P1", txtname.Text);
                c3.Parameters.AddWithValue("P2", txtlastname.Text);
                c3.Parameters.AddWithValue("P3", txtvin.Text);
                c3.Parameters.AddWithValue("P4", txtpersoncode.Text);
                c3.Connection=conn;
                c3.ExecuteNonQuery();
                fillgrid();
                txtpersoncode.ReadOnly = true;
                txtname.ReadOnly = true;
                txtlastname.ReadOnly = true;
                txtvin.ReadOnly = true;
                btnedit.Text = "ویرایش";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string b = string.Empty;
            switch (cbosearch.SelectedIndex)
            {
                case 0:
                    b = "fprs_Name";
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 1:
                    b = "fprs_LastName";
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 2:
                    b = "fprs_personCode";
                    break;
                case 3:
                    b = "fprs_VinCode";
                    break;
                default:
                    // در صورت نیاز می‌توانید یک مقدار پیش‌فرض تعیین کنید
                    break;
            }

            if (!string.IsNullOrEmpty(b))
            {
                string query = $"select * from T_Persons where {b} like '{txtsearch.Text}%'";
                fillgrid(query);
            }
            else
            {
                
            }

        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));

        }

        private void txtlastname_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            switch (cbosearch.SelectedIndex)
            {
                case 0:
                    
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 1:
                    
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 2:
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
                    break;
                case 3:
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
                    break;
                default:
                    break;
            }
        }

        private void cbosearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Focus();
            txtsearch.Clear();
        }
    }
}
