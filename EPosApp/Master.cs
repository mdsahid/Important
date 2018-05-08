using EPosApp.Item;
using EPosApp.New_Unit;
using EPosApp.Purchase;
using EPosApp.Sales;
using EPosApp.Supplier;
using EPosApp.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp
{
    public partial class Master : Form
    {
        

        string FormId = string.Empty;
        public Master()
        {
            InitializeComponent();
        }
        public Master(string id)
        {
            this.FormId = id;
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void masterSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm fmcg = new PurchaseForm();
            fmcg.ShowDialog();
        }

        private void aBCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SalesForm fmcg = new SalesForm();
            //fmcg.ShowDialog();

            this.Hide();
            SalesForm d = new SalesForm();
            d.Visible = true;
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UnitForm fmcg = new UnitForm();
            //fmcg.ShowDialog();

            UnitPart fmcg = new UnitPart();
            fmcg.ShowDialog();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemForm fmcg = new ItemForm();
            fmcg.ShowDialog();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers fmcg = new Customers();
            fmcg.ShowDialog();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stores fmcg = new Stores();
            fmcg.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm fmcg = new SupplierForm();
            fmcg.ShowDialog();

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stocks fmcg = new Stocks();
            fmcg.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User fmcg = new User();
            fmcg.ShowDialog();

            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm fmcg = new UserForm();
            fmcg.ShowDialog(this);

        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void userActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports fmcg = new Reports();
            fmcg.ShowDialog(this);
        }
        
    }
}
