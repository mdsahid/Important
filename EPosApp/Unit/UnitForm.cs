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

namespace EPosApp.Unit
{
    public partial class UnitForm : Master
    {
        Units u = new Units();
        public UnitForm()
        {
            InitializeComponent();

            //gridViewUnits.DataSource = u.getUnits();
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            
            //gridViewUnits.AllowUserToAddRows = false;
            ////gridViewUnits.RowTemplate.Height = 50;
        }
        string Constr = ConfigurationManager.ConnectionStrings["PosDb"].ConnectionString;
        private void UnitForm_Load(object sender, EventArgs e)
        {
            GetLoad();
            //frmFind_Load();
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

        private void gridViewUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetLoad()
        {
            using (SqlConnection con=new SqlConnection(Constr))
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

        //private void frmFind_Load()
        //{
        //    DataSet ds = new DataSet();
        //    string sql = "Select * from ns_units";
        //    using (SqlConnection con = new SqlConnection(Constr))
        //    {
        //        SqlCommand command = new SqlCommand(sql, con);
        //        SqlDataAdapter adp = new SqlDataAdapter(command);
        //        adp.Fill(ds,"");
        //        gridViewUnits.AutoGenerateColumns = false;

        //        gridViewUnits.DataSource = ds.Tables["incoun"];
        //    }
        //}

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            AddUnitForm frm = new AddUnitForm();
            frm.ShowDialog();
            this.Hide();

            gridViewUnits.DataSource = u.getUnits();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridViewUnits.DataSource = u.searchUnit(txtSearchValue.Text);
        }
    }
}
