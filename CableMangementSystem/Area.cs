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

namespace CableMangementSystem
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("RET_ID_FOR_CITY", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CITY_NAME", comboBox1.Text));
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                string city_id = "";
                while (reader.Read())
                {
                    city_id = reader["CITY_NO"].ToString();
                    break;
                }

                reader.Close();

                cmd = new SqlCommand("ADD_AREA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AREANAME", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@CITYNO", city_id));
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = "";
                MessageBox.Show("Area successfully added!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Area_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_CITY", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "CITY";
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
