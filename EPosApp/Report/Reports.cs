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
    public partial class Reports : Master
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void gridvChistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            gridViewReports.BorderStyle = BorderStyle.None;
            gridViewReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewReports.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewReports.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewReports.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewReports.BackgroundColor = Color.White;

            gridViewReports.EnableHeadersVisualStyles = false;
            gridViewReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewReports.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }
    }
}
