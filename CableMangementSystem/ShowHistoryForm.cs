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
        

        public ShowHistoryForm()
        {
            InitializeComponent();
        }

       

        public ShowHistoryForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private int GetIdFromEmail()
        {
            int id = 0;
            try
            {   
               
                // connection string 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

                conn.Open();

                // verify col OR change 
                SqlCommand cmd = new SqlCommand($"SELECT USER_ID FROM USER_INFO WHERE EMAIL='{this.email}'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["USER_ID"].ToString());
                    break;
                }

                conn.Close();

            }
            catch (Exception ex) { }

            return id;
        }

        private void ShowHistoryForm_Load(object sender, EventArgs e)
        {
            int id = GetIdFromEmail();
            MessageBox.Show($"hello {id}");
        }
    }
}
