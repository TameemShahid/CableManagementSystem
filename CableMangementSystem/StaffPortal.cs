using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CableMangementSystem
{
    public partial class StaffPortal : Form
    {
        public StaffPortal()
        {
            InitializeComponent();
        }
        
        private void addInventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form AddInventory = new AddInventory();
            AddInventory.WindowState = FormWindowState.Maximized;
            AddInventory.MdiParent = this;
            AddInventory.Show();
        }

        private void addAreaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form addArea = new Area();
            addArea.WindowState = FormWindowState.Maximized;
            addArea.MdiParent = this;
            addArea.Show();
        }

        private void billingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form billingHistory = new BillingHistory();
            billingHistory.WindowState = FormWindowState.Maximized;
            billingHistory.MdiParent = this;
            billingHistory.Show();
        }

        private void addBlockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Block blk = new Block();
            blk.WindowState = FormWindowState.Maximized;
            blk.MdiParent = this;
            blk.Show();
        }

        private void addCityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.WindowState = FormWindowState.Maximized;
            city.MdiParent = this;
            city.Show();
        }

        private void addConnectionChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewConnCharges ncc = new NewConnCharges();
            ncc.WindowState = FormWindowState.Maximized;
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Payment newPayment = new Payment();
            newPayment.WindowState = FormWindowState.Maximized;
            newPayment.MdiParent = this;
            newPayment.Show();
        }
        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditConnCharges ecc = new EditConnCharges();
            ecc.WindowState = FormWindowState.Maximized;
            ecc.MdiParent = this;
            ecc.Show();
        }

       
        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowInventory showInven = new ShowInventory();
            showInven.WindowState = FormWindowState.Maximized;
            showInven.MdiParent = this;
            showInven.Show();
        }

        private void StaffPortal_Load(object sender, EventArgs e)
        {
        }

        private void ShowCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCityForm show = new ShowCityForm();
            show.WindowState = FormWindowState.Maximized;
            show.MdiParent = this;
            show.Show();
        }

        private void BillingHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.WindowState = FormWindowState.Maximized;
            report.MdiParent = this;
            report.Show();
        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DC8AJAGQ;Initial Catalog=Temp;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM INVENTORY", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                string[] colName = { "ITEM_NO", "ITEM_NAME", "QUANTITY" };
                string data;
                List<string> inventoryItem = new List<string>();
                while (reader.Read())
                {
                    for (int i = 0; i < colName.Length; i++)
                    {
                        data = reader[colName[i]].ToString();
                        Console.WriteLine(data);
                        inventoryItem.Add(data);
                    }
                }


                GenReport.CreateDocumentInventory("Cable Co", "Inventory Report", inventoryItem);
                conn.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void BillPendingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
