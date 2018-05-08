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
    public partial class User : Master
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            gridViewUser.BorderStyle = BorderStyle.None;
            gridViewUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewUser.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewUser.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewUser.BackgroundColor = Color.White;

            gridViewUser.EnableHeadersVisualStyles = false;
            gridViewUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            //gridViewUser.ColumnHeaderCellChanged.
            gridViewUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewUser.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }
    }
}
