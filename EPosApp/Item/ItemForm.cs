﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.Item
{
    public partial class ItemForm : Master
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            gridViewItems.BorderStyle = BorderStyle.None;
            gridViewItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewItems.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewItems.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewItems.BackgroundColor = Color.White;

            gridViewItems.EnableHeadersVisualStyles = false;
            gridViewItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewItems.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
       
        }
    }
}
