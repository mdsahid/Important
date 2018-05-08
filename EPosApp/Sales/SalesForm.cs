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
    public partial class SalesForm : Master
    {

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            gridViewSales.BorderStyle = BorderStyle.None;
            gridViewSales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewSales.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewSales.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewSales.BackgroundColor = Color.White;

            gridViewSales.EnableHeadersVisualStyles = false;
            gridViewSales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewSales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            DashBoard d = new DashBoard();
            d.Visible = true;
            
        }
    }
}
