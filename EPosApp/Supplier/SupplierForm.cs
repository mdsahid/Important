using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.Supplier
{
    public partial class SupplierForm : Master
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            gridViewSupplier.BorderStyle = BorderStyle.None;
            gridViewSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewSupplier.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewSupplier.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewSupplier.BackgroundColor = Color.White;

            gridViewSupplier.EnableHeadersVisualStyles = false;
            gridViewSupplier.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        
        }
    }
}
