using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableMangementSystem
{
    public partial class ConnStr : Form
    {
        public ConnStr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString.connectionString = textBox1.Text;
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
