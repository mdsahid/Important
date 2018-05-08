using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.Sales
{
    public partial class AddSalesForm : Master
    {
        public AddSalesForm()
        {
            InitializeComponent();
        }

        private void AddSalesForm_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Item";

            gridViewPurchase.BorderStyle = BorderStyle.None;
            gridViewPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewPurchase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewPurchase.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewPurchase.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewPurchase.BackgroundColor = Color.White;

            gridViewPurchase.EnableHeadersVisualStyles = false;
            gridViewPurchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0,72,105);
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
