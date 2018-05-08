using EPosApp.Purchase;
using EPosApp.Sales;
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
    public partial class DashBoard : Master
    {
        public static Form PreviousPage;

        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseForm fmcg = new PurchaseForm();
            fmcg.ShowDialog();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SalesForm fmcg = new SalesForm();
            fmcg.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Stocks fmcg = new Stocks();
            fmcg.ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            User fmcg = new User();
            fmcg.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }
    }
}
