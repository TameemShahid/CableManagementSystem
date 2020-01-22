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
    public partial class Block : Form
    {
        public Block()
        {
            InitializeComponent();
            if(comboBox1.Text == "")
            {
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void Block_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            try
            {
                comboBox1.Items.Clear();
                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_CITY", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["CITY"]);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            comboBox2.Enabled = true;
            var city = comboBox1.Text;
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AREA FROM AREA WHERE CITY_NO = (SELECT CITY_NO FROM CITY WHERE CITY='QUETTA')", conn);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while(reader.Read())
=======
            try
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();

                SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("LOAD_AREA_BY_CITY", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CITYNAME", comboBox1.Text));

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["AREA"]);
                }

                conn.Close();
            }
            catch (Exception ex)
>>>>>>> e77e3b92eaf58739e5cf323e7b3eb78ef61a04e2
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Textbox cannot be empty!");
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=TAMEEMTTG;Initial Catalog=CableMDB;Integrated Security=True");
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("ADD_BLOCK", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BLOCKNAME", textBox1.Text));
                    cmd.Parameters.Add(new SqlParameter("@AREANAME", comboBox2.Text));

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    textBox1.Text = "";
                    MessageBox.Show("Block successfully added!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }
    }
}
