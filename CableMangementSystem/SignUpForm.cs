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
    public partial class SignUpForm : Form
    {
        private int user_id;
        public SignUpForm()
        {
            InitializeComponent();
            pwd_box.PasswordChar = '*';
            pwd_box.MaxLength = 10;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_box.Text == "" || phone_box.Text == "" || email_box.Text == "" || pwd_box.Text == "")
            {
                MessageBox.Show("Cannot be left Empty");
                return;
            }
            if (phone_box.TextLength != 11)
            {
                MessageBox.Show("Enter Valid  Phone Number");
                return;
            }
            if (pwd_box.TextLength < 5)
            {
                MessageBox.Show("Password length must be greater or equal than 5");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                // procedure for inserting new user
                SqlCommand cmd = new SqlCommand("SIGN_UP_PROC", con);
                SqlCommand cmd2 = new SqlCommand("SELECT USER_ID FROM USER_ WHERE NAME = @Name ", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NAME", name_box.Text));
                cmd.Parameters.Add(new SqlParameter("@PASS", pwd_box.Text));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", email_box.Text));
                cmd.Parameters.Add(new SqlParameter("@TEL", phone_box.Text));

                cmd.ExecuteNonQuery();
                //get user_name
                cmd2.Parameters.Add(new SqlParameter("@Name", name_box.Text));
                cmd2.ExecuteNonQuery();
                //get user_id
                this.user_id = Convert.ToInt32(cmd2.ExecuteScalar());

                con.Close();

                AddAddress add_address = new AddAddress(this.user_id);
                add_address.ShowDialog();
                this.Close();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
                MessageBox.Show("Enter valid phone number");
            }

        }
    }
}
