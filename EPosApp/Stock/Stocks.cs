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
    public partial class Stocks : Master
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            gridViewStocks.BorderStyle = BorderStyle.None;
            gridViewStocks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewStocks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewStocks.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewStocks.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewStocks.BackgroundColor = Color.White;

            gridViewStocks.EnableHeadersVisualStyles = false;
            gridViewStocks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewStocks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewStocks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewStocks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewStocks.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }
    }
}
