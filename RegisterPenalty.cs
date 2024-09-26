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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace igsit
{
    public partial class PenaltyRegisterForm : Form
    {
        SqlConnection conn; //= new SqlConnection();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        //CurrencyManager cr;
        public PenaltyRegisterForm()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text;
            using (SqlCommand cmd = new SqlCommand("SELECT fprs_Name, fprs_LastName,fprs_VinCode,fprs_personCode FROM T_Persons WHERE fprs_Name LIKE @searchText or fprs_LastName LIKE @searchText OR fprs_VinCode LIKE @searchText or fprs_personCode LIKE @searchText ORDER BY fprs_LastName", conn))
            {
                cmd.Parameters.AddWithValue("@searchText", searchText + "%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    lsbshowperson.Items.Clear();
                    while (reader.Read())
                    {
                        lsbshowperson.Items.Add(reader["fprs_personCode"]+"  "+ reader["fprs_LastName"] + "  " + reader["fprs_Name"] + "  " + reader["fprs_VinCode"]);
                    }
                } // اینجا SqlDataReader بسته می‌شود
            }

        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }

        private void txtpenaltycode_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }

        private void PenaltyRegisterForm_Load(object sender, EventArgs e)
        {
            conn = DatabaseHelper.GetConnection();
            conn.Open();
            //fillgrid();
            txtsearch.Focus();
            lsbshowperson.RightToLeft = RightToLeft.Yes;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string personCode = txtsearch.Text;

            using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM T_Persons WHERE fprs_personCode = @personCode", conn))
            {
                checkCmd.Parameters.AddWithValue("@personCode", personCode);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // کد ملی در جدول وجود دارد، ثبت کنید
                    using (SqlCommand insertCmd = new SqlCommand("INSERT INTO T_PenaltyRegister (fprg_personCode) VALUES (@personCode)", conn))
                    {
                        insertCmd.Parameters.AddWithValue("@personCode", personCode);
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("کد ملی با موفقیت ثبت شد.");
                    }
                }
                else
                {
                    // کد ملی وجود ندارد، از کاربر بپرسید
                    DialogResult result = MessageBox.Show("این کد ملی وجود ندارد. آیا مایل هستید آنرا ایجاد کنید؟", "تایید", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // فرم RegPersonForm را باز کنید
                        RegPersonForm regForm = new RegPersonForm();
                        regForm.btnnew_Click(null, null);
                        regForm.ShowDialog();

                        // پس از ثبت کاربر، فرم را ببندید و به فرم PenaltyRegisterForm برگردید
                        this.Show();
                    }
                }
            }
        }





        //void fillgrid(string s = "select * from T_Persons")
        //{
        //    cmd1.CommandText = s;
        //    cmd1.Connection = conn;
        //    da.SelectCommand = cmd1;
        //    ds.Clear();
        //    da.Fill(ds, "T1");
        //    dgvtpersons.DataBindings.Clear();
        //    dgvtpersons.DataBindings.Add("Datasource", ds, "T1");
        //    txtpersoncode.DataBindings.Clear();
        //    txtpersoncode.DataBindings.Add("text", ds, "T1.fprs_personCode");
        //    txtname.DataBindings.Clear();
        //    txtname.DataBindings.Add("text", ds, "T1.fprs_Name");
        //    txtlastname.DataBindings.Clear();
        //    txtlastname.DataBindings.Add("text", ds, "T1.fprs_LastName");
        //    txtvin.DataBindings.Clear();
        //    txtvin.DataBindings.Add("text", ds, "T1.fprs_VinCode");
        //    cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        //}
    }
}
