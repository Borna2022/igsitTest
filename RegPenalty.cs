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
using System.Xml.Linq;
using System.Globalization;

namespace igsit
{
    public partial class RegPenalty : Form
    {
        SqlConnection conn; //= new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;

        public RegPenalty()
        {
            InitializeComponent();
        }

        private void RegPenalty_Load(object sender, EventArgs e)
        {
            conn = DatabaseHelper.GetConnection();
            conn.Open();
            fillgrid();
            cbosearch.Focus();

        }
        void fillgrid(string s = "select * from T_Penalty")
        {
            cmd1.CommandText = s;
            cmd1.Connection = conn;
            da.SelectCommand = cmd1;
            ds.Clear();
            da.Fill(ds, "T1");
            dgvregpenalty.DataBindings.Clear();
            dgvregpenalty.DataBindings.Add("Datasource", ds, "T1");
            txtpenaltycode.DataBindings.Clear();
            txtpenaltycode.DataBindings.Add("text", ds, "T1.fpnl_PenaltyCode");
            txtpenaltycost.DataBindings.Clear();
            txtpenaltycost.DataBindings.Add("text", ds, "T1.fpnl_PenaltyCost");
            txtpenaltydescription.DataBindings.Clear();
            txtpenaltydescription.DataBindings.Add("text", ds, "T1.fpnl_PenaltyDescription");
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
            txtpenaltycode.ReadOnly = false;
            txtpenaltycost.ReadOnly = false;
            txtpenaltydescription.ReadOnly = false;

            txtpenaltycode.Text = "";
            txtpenaltycost.Text = "";
            txtpenaltydescription.Text = "";

            btnnew.Enabled = false;
            btnsave.Enabled = true;
            txtpenaltycode.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlCommand c1 = new SqlCommand())
            {
                try
                {
                    c1.CommandText = "insert into T_Penalty values(@p1,@p2,@p3)";
                    c1.Parameters.AddWithValue("p1", txtpenaltycode.Text);
                    c1.Parameters.AddWithValue("p2", txtpenaltycost.Text);
                    c1.Parameters.AddWithValue("p3", txtpenaltydescription.Text);

                    c1.Connection = conn;
                    c1.ExecuteNonQuery();
                    btnsave.Enabled = false;
                    btnnew.Enabled = true;
                    txtpenaltycode.ReadOnly = true;
                    txtpenaltycost.ReadOnly = true;
                    txtpenaltydescription.ReadOnly = true;

                    fillgrid();

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (InvalidOperationException invOpEx)
                {
                    MessageBox.Show("Invalid operation: " + invOpEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Do you want to delete " + txtpenaltycode.Text + " با شرح " + txtpenaltydescription.Text, "Warning", MessageBoxButtons.YesNo);
            if (x == DialogResult.No)
                return;
            SqlCommand c2 = new SqlCommand();
            c2.CommandText = "delete from  T_Penalty where fpnl_PenaltyCode=@p1 ";
            c2.Parameters.AddWithValue("p1", txtpenaltycode.Text);
            c2.Connection = conn;
            c2.ExecuteNonQuery();
            fillgrid();
        }

        private void dgvregpenalty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text == "ویرایش")
            {
                txtpenaltycode.ReadOnly = true;
                txtpenaltycost.ReadOnly = false;
                txtpenaltydescription.ReadOnly = false;

                btnedit.Text = "اعمال تغییرات";
                txtpenaltycode.Focus();

            }
            else
            {
                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "update T_Penalty set fprs_Name=@p1,fprs_LastName=@p2, fprs_VinCode=@p3 where fprs_personCode=@p4 ";
                c3.Parameters.AddWithValue("P1", txtpenaltycode.Text);
                c3.Parameters.AddWithValue("P2", txtpenaltycost.Text);
                c3.Parameters.AddWithValue("P3", txtpenaltydescription.Text);

                c3.Connection = conn;
                c3.ExecuteNonQuery();
                fillgrid();
                txtpenaltycode.ReadOnly = true;
                txtpenaltycost.ReadOnly = true;
                txtpenaltydescription.ReadOnly = true;

                btnedit.Text = "ویرایش";
            }
        }

        private void cbosearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Focus();
            txtsearch.Clear();
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
                    b = "fpnl_PenaltyCode";
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 1:
                    b = "fpnl_PenaltyCost";
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    break;
                case 2:
                    b = "fpnl_PenaltyDescription";
                    break;
                default:
                    // در صورت نیاز می‌توانید یک مقدار پیش‌فرض تعیین کنید
                    break;
            }

            if (!string.IsNullOrEmpty(b))
            {
                string query = $"select * from  T_Penalty where {b} like '{txtsearch.Text}%'";
                fillgrid(query);
            }
            else
            {

            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }

        private void txtpenaltydescription_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }
    }
}
