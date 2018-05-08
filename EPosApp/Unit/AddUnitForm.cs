using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EPosApp.Unit
{
    public partial class AddUnitForm : Master
    {
        public AddUnitForm()
        {
            InitializeComponent();
        }
        Units u = new Units();
        string Constr = ConfigurationManager.ConnectionStrings["PosDb"].ConnectionString;

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Enter The Unit Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtQty.Text == string.Empty && txtValue.Text == string.Empty)
            {
                MessageBox.Show("Quantity and Value Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

            else
            {

                //u.insertUnit(Convert.ToInt32(cmbParent.SelectedValue), txtName.Text, txtQty.Text,
                //                     txtValue.Text, DateTime.Today());
                //MessageBox.Show("New Unit Inserted Successfully", "New Unit", MessageBoxButtons.OK, MessageBoxIcon.Information);


                using (SqlConnection Con = new SqlConnection(Constr))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert ns_units(parent_id,name,qty,value,created) Values('" + Convert.ToInt32(cmbParent.SelectedValue) + "','" + txtName.Text + "','" + txtQty.Text + "','" + txtValue.Text + "',GetDate())", Con);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("New Unit Inserted Successfully", "New Unit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            
            
            
            
            
            
            //using (SqlConnection Con=new SqlConnection(Constr))
            //{
            //    Con.Open();
            //    SqlCommand cmd = new SqlCommand("Insert ns_units(parent_id,name,qty,value,created) Values('" + Convert.ToInt32(cmbParent.SelectedValue) + "','" + txtName.Text + "','" + txtQty.Text + "','" + txtValue.Text + "',GetDate())", Con);
            //    cmd.ExecuteNonQuery();
                
            //    //GetLoad();
            //}
        }

        private void btnUnitList_Click(object sender, EventArgs e)
        {
            UnitForm frm = new UnitForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbParent.SelectedItem = -1;
            txtName.Text = "";
            txtQty.Text = "";
            txtValue.Text = "";
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        
    }
}
