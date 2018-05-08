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
    public partial class AddNewUnit : Form
    {
        public AddNewUnit()
        {
            InitializeComponent();
        }
        string Constr = ConfigurationManager.ConnectionStrings["PosDb"].ConnectionString;
        Units u = new Units();

        private void AddNewUnit_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Enter The Unit Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (txtQty.Text == string.Empty && txtValue.Text == string.Empty)
            //{
            //    MessageBox.Show("Quantity and Value Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            else
            {

                //u.insertUnit(Convert.ToInt32(cmbParent.SelectedValue), txtName.Text, Convert.ToInt32(txtQty.Text),
                //                    Convert.ToInt32(txtValue.Text));
                //MessageBox.Show("New Unit Inserted Successfully", "New Unit", MessageBoxButtons.OK, MessageBoxIcon.Information);


                using (SqlConnection Con = new SqlConnection(Constr))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert ns_units(parent_id,name,qty,value) Values('" + Convert.ToInt32(cmbParent.SelectedValue) + "','" + txtName.Text + "','" + txtQty.Text + "','" + txtValue.Text + "')", Con);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("New Unit Inserted Successfully", "New Unit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
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

        private void panelMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
