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

namespace CableMangementSystem
{
    public partial class ReportForm : Form
    {
        private string user_id = "";
        
        private List<string> dataUser;
        
    
        public ReportForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadDataGridView();

            dataUser = new List<string>();
        }

        private void LoadDataGridView()
        {
            try
            {

                
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM HISTORY", conn);
                //commad.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter sqlda = new SqlDataAdapter(command);
               
                DataSet ds = new DataSet();
                sqlda.Fill(ds);

                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void GenerateReport()
        {

            // column name for billing history 
            // change this col names for your server 
            string[] colName = { "HISTORY_ID", "USER_ID", "NAME","HOUSE", "PAYMENT", "RECEIVED BY", "MONTH", "STATUS" };

            if (user_id == "")
                MessageBox.Show("Please Select Row Of which you want to generate report");
            else {
                int userId = int.Parse(user_id);

                try
                {
                    
                    SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

                    conn.Open();

                    /*only for testing use stored procedure*/
                    // change this for your revelant
                    SqlCommand cmd = new SqlCommand("LOAD_USER_BY_ID", conn);

                    /* uncommen for actual implementation  */

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@USERID", user_id));

                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    string data;

                    while (reader.Read())
                    {
                        // save all data into string array
                        for (int j = 0; j < colName.Length; j++)
                        {
                            data = reader[colName[j]].ToString();

                            dataUser.Add(data);
                        }
                    }

                    // generate report from above information
                    GenReport.CreateDocumentHistory("Cable Co", "Billing History", dataUser);

                    conn.Close();
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }


            } // end of else 


        }
        private void ReportForm_Load(object sender, EventArgs e) { }


        private void GenReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
        private void dataGridView_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                user_id = row.Cells[1].Value.ToString();
            }
        }



        private void SearchCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                string query = "SELECT * FROM HISTORY";
                List<string> colName = new List<string>();

                // string[] colName = { "HISTORY_ID", "USER_ID", "USER_NAME", "HOUSE", "PAYMENT", "RECEIVED_BY", "MONTH", "STATUS" };

                string searchName = SearchNameTxtBox.Text;

                // check for checked state 
                if (HistoryIdCheckBox.CheckState == CheckState.Checked)
                    colName.Add("HISTORY_ID");
                if (UserIdCheckBox.CheckState == CheckState.Checked)
                    colName.Add("USER_ID");
                if (UserNameCheckBox.CheckState == CheckState.Checked)
                    colName.Add("USER_NAME"); // change this to NAME 
                if (HouseCheckBox.CheckState == CheckState.Checked)
                    colName.Add("HOUSE");
                if (PaymentCheckBox.CheckState == CheckState.Checked)
                    colName.Add("PAYMENT");
                if (ReceiveCheckBox.CheckState == CheckState.Checked)
                    colName.Add("RECEIVED_BY");// change this to RECEIVED BY
                if (MonthCheckBox.CheckState == CheckState.Checked)
                    colName.Add("MONTH");
                if (StatusCheckBox.CheckState == CheckState.Checked)
                    colName.Add("STATUS");

                if (colName.Count == 0)
                {
                    //colName.Add("*");
                    colName.Add("HISTORY_ID");
                    colName.Add("USER_ID");
                    colName.Add("USER_NAME"); // change this to NAME 
                    colName.Add("HOUSE");
                    colName.Add("PAYMENT");
                    colName.Add("RECEIVED_BY");
                    colName.Add("MONTH");
                    colName.Add("STATUS");

                }

                StringBuilder newSqlBuilder = new StringBuilder();


                string comma;
                for (int i = 0; i < colName.Count; i++)
                {
                    comma = (i == (colName.Count - 1) ? " " : ",");
                    newSqlBuilder.Append(colName[i] + comma);
                }

                label1.Text = "SELECT " + newSqlBuilder.ToString() + $" FROM HISTORY WHERE USER_NAME='{searchName}';";
                query = label1.Text;

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                string[] colNameArray = colName.ToArray();
                List<string> userHistory = new List<string>();
                while (reader.Read())
                {
                    for (int i = 0; i < colName.Count; i++)
                    {
                        userHistory.Add(reader[colNameArray[i]].ToString());
                    }
                }
                reader.Close();

                StringBuilder viewStringBuilder = new StringBuilder();
                foreach (string item in userHistory)
                    viewStringBuilder.Append(item);

                MessageBox.Show(viewStringBuilder.ToString());


                //not working
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlda.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
