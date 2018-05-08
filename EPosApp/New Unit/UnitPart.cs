using EPosApp.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.New_Unit
{
    public partial class UnitPart : Form
    {
        string Constr = ConfigurationManager.ConnectionStrings["PosDb"].ConnectionString;
        Units u = new Units();


        public UnitPart()
        {
            InitializeComponent();
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            New_Unit.AddNewUnit frm = new New_Unit.AddNewUnit();
            frm.ShowDialog();
            this.Hide();

            gridViewUnits.DataSource = u.getUnits();
        }

        private void GetLoad()
        {
            using (SqlConnection con = new SqlConnection(Constr))
            {
                con.Open();
                //SqlDataAdapter sda = new SqlDataAdapter("Select * from ns_units", con);
                SqlCommand cmd = new SqlCommand("Select * from ns_units", con);
                IDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(rdr);
                //sda.Fill(dt);
                gridViewUnits.DataSource = dt;
            }
        }

        private void UnitPart_Load(object sender, EventArgs e)
        {
            GetLoad();


            gridViewUnits.BorderStyle = BorderStyle.None;
            gridViewUnits.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridViewUnits.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridViewUnits.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridViewUnits.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridViewUnits.BackgroundColor = Color.White;

            gridViewUnits.EnableHeadersVisualStyles = false;
            gridViewUnits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridViewUnits.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 72, 105);
            gridViewUnits.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewUnits.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridViewUnits.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8.5F, FontStyle.Bold);
        }

        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to delete aaaaaaaaaaaaaa", "Remove Unit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                u.deleteUnits(Convert.ToInt32(gridViewUnits.CurrentRow.Cells[0].Value));
                gridViewUnits.DataSource = u.getUnits();
                MessageBox.Show("Unit Deleted Successfully", "Remove Unit");
            }
        }

        private void btnUpdateUnit_Click(object sender, EventArgs e)
        {


            UpdateUnitForm fup = new UpdateUnitForm();

            fup.txtId.Text = gridViewUnits.CurrentRow.Cells[0].Value.ToString();
            fup.cmbParent.Text = gridViewUnits.CurrentRow.Cells[1].Value.ToString();
            fup.txtName.Text = gridViewUnits.CurrentRow.Cells[2].Value.ToString();
            fup.txtQty.Text = gridViewUnits.CurrentRow.Cells[3].Value.ToString();
            fup.txtValue.Text = gridViewUnits.CurrentRow.Cells[4].Value.ToString();

            //fup.Created = gridViewUnits.CurrentRow.Cells[5].Value.ToString();
            //fup.COMBO_CATEGORIES.Text = gridViewUnits.CurrentRow.Cells[6].Value.ToString();

            //byte[] img = (byte[])DGV_PRODUCTS.CurrentRow.Cells[4].Value;
            //MemoryStream ms = new MemoryStream(img);
            //fup.PB_BROWSE_IMAGE.Image = Image.FromStream(ms);
            fup.ShowDialog();
            gridViewUnits.DataSource = u.getUnits();
        }
    }
}
