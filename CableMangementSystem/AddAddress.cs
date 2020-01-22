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
    public partial class AddAddress : Form
    {
        private int user_id;
        private string email;
        private string city_id;
        private string area_id;
        private string block_id;
        private int house_no;
        public AddAddress()
        {
            InitializeComponent();
        }
           public AddAddress(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;

            button2.Visible = false;
        }
        public AddAddress(int user_id,int house_no)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.house_no= house_no;

         //   MessageBox.Show(this.house_no.ToString());

            button1.Visible =false;
        }

        private void AddAddress_Load(object sender, EventArgs e)
        {
            area_box.Enabled = false;
            block_box.Enabled = false;
            house_box.Enabled = false;



            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CITY_NO,CITY FROM CITY", con);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("CITY_NO", typeof(string));
            dt.Columns.Add("CITY", typeof(string));
            dt.Load(reader);

            city_box.ValueMember = "CITY_NO";
            city_box.DisplayMember = "CITY";
            city_box.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.block_id = block_box.SelectedValue.ToString();

            if (house_box.Text != "")
            {

                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                //stored procedure to add house in HOUSE
                SqlCommand cmd = new SqlCommand("ADD_HOUSE", con);
                // query to get HOUSE_NO
                SqlCommand cmd2 = new SqlCommand("SELECT HOUSE_NO FROM HOUSE WHERE HOUSE = @house_text", con);
                //stored procedure to add user_id and house_no in USER_ADDRESS
                SqlCommand cmd3 = new SqlCommand("ADD_USER_ADDRESS", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HOUSE", house_box.Text));
                cmd.Parameters.Add(new SqlParameter("@BLOCK_ID", this.block_id));
                cmd.ExecuteNonQuery();

                cmd2.Parameters.Add(new SqlParameter("@house_text", house_box.Text));
                //house_id
                this.house_no = Convert.ToInt32(cmd2.ExecuteScalar());
                cmd2.ExecuteNonQuery();


                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add(new SqlParameter("@HOUSENO", this.house_no));
                cmd3.Parameters.Add(new SqlParameter("@USERID", this.user_id));
                cmd3.ExecuteNonQuery();

                con.Close();

                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
                this.Dispose();
                
            }
            else
            {
                MessageBox.Show("House Cannot be left Blank");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Address();
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT EMAIL FROM USER_ WHERE USER_ID = '" +this.user_id+"'", conn);
            SqlDataReader reader;

            conn.Open();
        
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                this.email = reader["EMAIL"].ToString();
                break;
            }
            reader.Close();
            
          //  this.email = cmd.ExecuteScalar().ToString();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Address Updated");

            UserForm userform = new UserForm(this.email);
            userform.ShowDialog();            
            this.Close();
            this.Dispose();
        }

        private void city_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            area_box.Enabled = true;
            this.city_id = city_box.SelectedValue.ToString();

            if (city_box.Text != "")
            {

                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT AREA_NO, AREA FROM AREA WHERE AREA.CITY_NO = '" + this.city_id + "'", con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("AREA_NO", typeof(string));
                dt.Columns.Add("AREA", typeof(string));
                dt.Load(reader);

                area_box.ValueMember = "AREA_NO";
                area_box.DisplayMember = "AREA";
                area_box.DataSource = dt;

                con.Close();
            }
        }

        private void area_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            block_box.Enabled = true;
            this.area_id = area_box.SelectedValue.ToString();
            if (area_box.Text != "")
            {
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT BLOCK_ID ,BLOCK FROM BLOCK WHERE BLOCK.AREA_NO = '" + this.area_id + "'", con);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Columns.Add("BLOCK_ID", typeof(string));
                dt.Columns.Add("BLOCK", typeof(string));
                dt.Load(reader);

                block_box.ValueMember = "BLOCK_ID";
                block_box.DisplayMember = "BLOCK";
                block_box.DataSource = dt;

                con.Close();
            }
        }

        private void block_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            house_box.Enabled = true;
        }
        private void Update_Address()
        {
            if (house_box.Text != "")
            {
                this.block_id = block_box.SelectedValue.ToString();
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                //procedure to update user address
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_USER_ADDRESS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HOUSE_NO", this.house_no);
                cmd.Parameters.AddWithValue("@BLOCK_ID", this.block_id);
                cmd.Parameters.AddWithValue("@HOUSE", this.house_box.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("House cannot be left empty");
            }
        }

        private void house_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
