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
    public partial class PurchaseForm : Master
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            gridViewPurchase.BorderStyle = BorderStyle.None;
            gridViewPurchase.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewPurchase.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewPurchase.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewPurchase.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewPurchase.BackgroundColor = Color.White;

            gridViewPurchase.EnableHeadersVisualStyles = false;
            gridViewPurchase.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewPurchase.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }
    }
}
