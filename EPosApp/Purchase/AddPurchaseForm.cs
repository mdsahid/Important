using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.Purchase
{
    public partial class AddPurchaseForm : Master
    {
        public AddPurchaseForm()
        {
            InitializeComponent();
        }

        private void AddPurchaseForm_Load(object sender, EventArgs e)
        {
            txtItem.Text = "Item";
            gridViewPurchase.BorderStyle = BorderStyle.None;
            gridViewPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewPurchase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewPurchase.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewPurchase.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewPurchase.BackgroundColor = Color.White;

            gridViewPurchase.EnableHeadersVisualStyles = false;
            gridViewPurchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 248, 228);
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.SteelBlue;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (txtItem.Text == "Item")
            {
                txtItem.Text = "";
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (txtItem.Text == "")
            {
                txtItem.Text = "Place Holder text...";


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
