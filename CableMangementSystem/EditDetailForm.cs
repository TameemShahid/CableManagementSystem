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
    public partial class EditDetailForm : Form
    {
        private string user_id;
        private string house_id;
        private int check_select = 0;
        private string email;
        public EditDetailForm()
        {
            InitializeComponent();
        }
        public EditDetailForm(int id)
        {
            this.user_id = id.ToString();
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (check_select == 1)
            {
                AddAddress add_address = new AddAddress( int.Parse(this.user_id), int.Parse(this.house_id));
                add_address.Show();
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("You have not selected row");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pwd_box.Text == "" && tel_box.Text == "" && name_box.Text == "" && email_box.Text == "")
            {
                MessageBox.Show("Please edit one of the fields");
            }

            if (pwd_box.Text != "" && pwd_box.TextLength < 5)
            {
                MessageBox.Show("Password must be 5 character long");
            }

            if (tel_box.TextLength != 11 && tel_box.Text != "")
            {
                MessageBox.Show("Enter valid phone number");

            }
            if (name_box.Text != "")
            {
                Edit_Name();
                MessageBox.Show("Name updated");
                name_box.Text = "";
            }
            if (pwd_box.Text != "" && pwd_box.TextLength > 5)
            {
                Edit_Password();
                MessageBox.Show("Password Updated");
                pwd_box.Text = "";
            }
            if (tel_box.Text != "" && tel_box.TextLength == 11)
            {
                Edit_Telephone();
                MessageBox.Show("Telephone number updated");
                tel_box.Text = "";
            }
            if (email_box.Text != "")
            {
                Edit_Mail();
                MessageBox.Show("Email updated");
                email_box.Text = "";
            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwd_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void Edit_Name()
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE USER_ SET NAME = '" + name_box.Text + "' WHERE USER_ID = '" + this.user_id + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Edit_Password()
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE USER_ SET USER_PASSWORD = '" + pwd_box.Text + "' WHERE USER_ID = '" + this.user_id + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Edit_Telephone()
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE USER_ SET TELEPHONE = '" + tel_box.Text + "' WHERE USER_ID = '" + this.user_id + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Edit_Mail()
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("UPDATE USER_ SET EMAIL = '" + email_box.Text + "' WHERE USER_ID = '" + this.user_id + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    check_select = 1;
                    int index = e.RowIndex;
                    DataGridViewRow selectedrow = dataGridView1.Rows[index];
                    this.house_id = selectedrow.Cells[0].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EditDetailForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("LOAD_USER_ADDRESS", con);
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@USERID", this.user_id));
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
           dataGridView1.Columns[0].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT EMAIL FROM USER_ WHERE USER_ID = '"+this.user_id+"' ",con);
            con.Open();

            this.email = cmd.ExecuteScalar().ToString();
            cmd.ExecuteNonQuery();

            con.Close();

            UserForm userform = new UserForm(this.email);
            userform.Show();
            this.Close();
            this.Dispose();
        }
    }
}
