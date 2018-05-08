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
    public partial class Customers : Master
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            gridViewCustomers.BorderStyle = BorderStyle.None;
            gridViewCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewCustomers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewCustomers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewCustomers.BackgroundColor = Color.White;

            gridViewCustomers.EnableHeadersVisualStyles = false;
            gridViewCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }
    }
}
