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
                SqlCommand cmd = new SqlCommand("SELECT * FROM CITY", conn);
                SqlDataReader reader;

                reader = cmd.ExecuteReader();
                List<string> cities = new List<string>();

                while (reader.Read())
                {
                    cities.Add(reader["CITY_NAME"].ToString());
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
                SqlCommand cmd = new SqlCommand($"SELECT CITY_NO FROM CITY WHERE CITY_NAME='{city}'",conn);
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
                SqlCommand cmd = new SqlCommand($"SELECT AREA_NAME FROM AREA WHERE AREA.CITY_NO={cityId}", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> areas = new List<string>();

                while (reader.Read())
                {
                    areas.Add(reader["AREA_NAME"].ToString());
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
                SqlCommand cmd = new SqlCommand($"SELECT AREA_NO FROM AREA WHERE AREA_NAME='{area}'",conn);
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
                SqlCommand cmd = new SqlCommand($"SELECT BLOCK_NAME FROM BLOCK WHERE BLOCK.AREA_NO={areaId}",conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> blocks = new List<string>();

                while (reader.Read())
                {
                    blocks.Add(reader["BLOCK_NAME"].ToString());
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
