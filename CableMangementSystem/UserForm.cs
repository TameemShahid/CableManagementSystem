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
    public partial class UserForm : Form
    {
        private string email;
        private int id;

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(string username)
        {
            InitializeComponent();
            this.email = username;
        }

       
        private int GetIdFromEmail()
        {
            int id = 0;
            try
            {
               
                // connection string 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);

                conn.Open();
                // verify col 
                SqlCommand cmd = new SqlCommand("SELECT USER_ID FROM USER_ WHERE EMAIL= '"+this.email+"' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["USER_ID"].ToString());
                    break;
                }

                conn.Close();

            } catch (Exception ex) { }

            return id;
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            this.id = GetIdFromEmail();
            MessageBox.Show("Welcome User With Id "+this.id);
        }

        private void ShowHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHistoryForm historyForm = new ShowHistoryForm(this.id,this.email);
            historyForm.MdiParent = this;
            historyForm.WindowState = FormWindowState.Maximized;
            historyForm.Show();
        }

        private void EditDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDetailForm detail = new EditDetailForm(this.id);
            detail.MdiParent = this;
            detail.WindowState = FormWindowState.Maximized;
            detail.Show();
        }
    }
}
