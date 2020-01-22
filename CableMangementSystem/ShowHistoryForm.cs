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
    public partial class ShowHistoryForm : Form
    {
        private string email;
        private int id;
        public ShowHistoryForm()
        {
            InitializeComponent();
        }
        public ShowHistoryForm(int id,string email)
        {
            InitializeComponent();
            this.id = id;
            this.email = email;
        }

        private void ShowHistoryForm_Load(object sender, EventArgs e)
        {
            //int id = GetIdFromEmail();
            //MessageBox.Show("hello {id}");

            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("LOAD_HISTORY_BY_USERID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@USERID", this.id));
            cmd.ExecuteNonQuery();
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            DataSet data_set = new DataSet();
            data_adapter.Fill(data_set);
            dataGridView1.DataSource = data_set.Tables[0];
            con.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            UserForm userform = new UserForm(this.email);
            this.Close();
            this.Dispose();
        }



        //private int GetIdFromEmail()
        //{
        //    int id = 0;
        //    try
        //    {

        //        // connection string 
        //        SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

        //        conn.Open();

        //        // verify col OR change 
        //        SqlCommand cmd = new SqlCommand("SELECT USER_ID FROM USER_INFO WHERE EMAIL='{this.email}'", conn);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            id = int.Parse(reader["USER_ID"].ToString());
        //            break;
        //        }

        //        conn.Close();

        //    }
        //    catch (Exception ex) { }

        //    return id;
        //}

    }
}
