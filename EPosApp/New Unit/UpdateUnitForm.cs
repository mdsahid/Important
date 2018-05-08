using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPosApp.New_Unit
{
    public partial class UpdateUnitForm : Form
    {
        Units unt = new Units();
        public UpdateUnitForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Name Can't Be Empty", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                unt.updateUnit(Convert.ToInt32(cmbParent.SelectedValue), txtName.Text,
                                 Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtValue.Text));
                MessageBox.Show("Product Updated Successfully", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
