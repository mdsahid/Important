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
    public partial class GridVDesign : Form
    {
        public GridVDesign()
        {
            InitializeComponent();
        }

        private void GridVDesign_Load(object sender, EventArgs e)
        {
             
               
                //n = dataGridView1.Rows.Add();
                //dataGridView1.Rows[n].Cells[0].Value = "123457";
                //dataGridView1.Rows[n].Cells[1].Value = "Jahid";
                //dataGridView1.Rows[n].Cells[2].Value = "Hafej";
                //dataGridView1.Rows[n].Cells[3].Value = "01721439597";
                //dataGridView1.Rows[n].Cells[4].Value = "hahid@gmail.com";
                //dataGridView1.Rows[n].Cells[5].Value = "Python";
                //dataGridView1.Rows[n].Cells[6].Value = "Niketon, Dhaka";
                //n = dataGridView1.Rows.Add();
                //n = dataGridView1.Rows.Add();
                //dataGridView1.Rows[n].Cells[0].Value = "123458";
                //dataGridView1.Rows[n].Cells[1].Value = "Hossain";
                //dataGridView1.Rows[n].Cells[2].Value = "Mawlana";
                //dataGridView1.Rows[n].Cells[3].Value = "01721439597";
                //dataGridView1.Rows[n].Cells[4].Value = "jahid@gmail.com";
                //dataGridView1.Rows[n].Cells[5].Value = "Java";
                //dataGridView1.Rows[n].Cells[6].Value = "Niketon, Dhaka";
         
            
            //n = dataGridView1.Rows.Add();
            //dataGridView1.Rows[n].Cells[0].Value = "";
            //dataGridView1.Rows[n].Cells[1].Value = " ";
            //dataGridView1.Rows[n].Cells[2].Value = " ";
            //dataGridView1.Rows[n].Cells[3].Value = "Total:-";
            //dataGridView1.Rows[n].Cells[4].Value = "10";
            //dataGridView1.Rows[n].Cells[5].Value = "";
            //dataGridView1.Rows[n].Cells[6].Value = "";
            //dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
