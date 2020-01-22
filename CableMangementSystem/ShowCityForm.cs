using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CableMangementSystem
{
    public partial class ShowCityForm : Form
    {

        
        public ShowCityForm()
        {
            InitializeComponent();
            
        }

       
        private void ShowCityForm_Load(object sender, EventArgs e)
        {
            try
            {

                
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_CITY", conn);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                List<string> cities = new List<string>();

                while (reader.Read())
                {
                    cities.Add(reader["CITY"].ToString());
                }

                foreach (string item in cities)
                    ShowCityListBox.Items.Add(item);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        private int GetCityId(string city)
        {
            int cityId = 0;

            try
            {

                 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("RET_ID_FOR_CITY",conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CITY_NAME", city));

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cityId = int.Parse(reader["CITY_NO"].ToString());
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return cityId;
        }
        private void ShowCityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShowAreaListBox.Items.Clear();
                ShowBlockListBox.Items.Clear();
                 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                // get selected item 
                string city = ShowCityListBox.SelectedItem.ToString();
                int cityId = GetCityId(city);

                conn.Open();
                SqlCommand cmd = new SqlCommand("LOAD_AREA_BY_CITY", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CITYNAME", city));
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> areas = new List<string>();

                while (reader.Read())
                {
                    areas.Add(reader["AREA"].ToString());
                }

                foreach (string item in areas)
                    ShowAreaListBox.Items.Add(item);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        // get area id from area table 
        private int GetAreaId(string area)
        {
            int areaId = 0;

            try
            {

                 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT AREA_NO FROM AREA WHERE AREA='"+area+"' ",conn);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    areaId = int.Parse(reader["AREA_NO"].ToString());
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return areaId;
        }
        private void ShowAreaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShowBlockListBox.Items.Clear();
                 
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                // get selected item 
                string area = ShowAreaListBox.SelectedItem.ToString();
                int areaId = GetAreaId(area);

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT BLOCK FROM BLOCK WHERE BLOCK.AREA_NO='"+areaId+"' ",conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> blocks = new List<string>();

                while (reader.Read())
                {
                    blocks.Add(reader["BLOCK"].ToString());
                }

                foreach (string item in blocks)
                    ShowBlockListBox.Items.Add(item);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
