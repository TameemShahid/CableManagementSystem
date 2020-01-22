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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("ADD_PAYMENT", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AMOUNT", numericUpDown1.Value));
                cmd.Parameters.Add(new SqlParameter("@STARTDATE", monthCalendar1.SelectionEnd.ToShortDateString()));
                MessageBox.Show(monthCalendar1.SelectionEnd.ToShortDateString());

                cmd.ExecuteNonQuery();

                conn.Close();
                numericUpDown1.ResetText();
                monthCalendar1.ResetText();
                MessageBox.Show("Payment successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
