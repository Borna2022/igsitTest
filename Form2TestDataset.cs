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
using System.Reflection.Emit;

namespace igsit
{
    public partial class Form2TestDataset : Form
    {
        public Form2TestDataset()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Define the connection string to connect to the SQL Server database
            string connectionString = "Data Source=Borna;Initial Catalog=igsitDBTest;Integrated Security=True;TrustServerCertificate=True";

            // Define the SQL query to select all records from the T_Penalty table
            string query = "SELECT * FROM T_Penalty";

            // Create a new SqlConnection object using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlDataAdapter to execute the query and fill the DataSet
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Create a new DataSet to hold the query results
                DataSet dataSet = new DataSet();

                // Fill the DataSet with the results of the query, using the table name "T_Penalty"
                adapter.Fill(dataSet, "T_Penalty");

                // Create an array of labels to hold the references to the label controls
                System.Windows.Forms.Label[] labels = { label1, label2, label3, label4, label5 };

                // Loop through each label in the array
                for (int i = 0; i < labels.Length; i++)
                {
                    // Check if the current index is within the bounds of the DataSet rows
                    if (i < dataSet.Tables["T_Penalty"].Rows.Count)
                    {
                        // If the value in the "fpnl_PenaltyDescription" column is not DBNull, set the label text to this value
                        // Otherwise, set the label text to "null"
                        labels[i].Text = dataSet.Tables["T_Penalty"].Rows[i]["fpnl_PenaltyDescription"] != DBNull.Value
                                         // Ternary operator: if the value is not DBNull, convert it to string and assign to label text
                                         ? dataSet.Tables["T_Penalty"].Rows[i]["fpnl_PenaltyDescription"].ToString()
                                         // If the value is DBNull, assign "null" to label text
                                         : "null";
                    }
                    else
                    {
                        // If there are not enough rows in the DataSet, set the label text to "null"
                        labels[i].Text = "null";
                    }
                }
            }
        }

    }
}
