using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using InventoryManagementSystemApp.BLL;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.UI
{
    public partial class Index : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProductCode"] != null)
                {
                   
                    string productCode = Request.QueryString["ProductCode"];
                    Product product = productManager.GetProductByCode(productCode);
                   if (product.Code != null)
                   {
                        productHiddenField.Value = product.ProductId.ToString();
                        codeTextBox.Text = product.Code;
                        nameTextBox.Text = product.Name;
                        unitPriceTextBox.Text = product.UnitPrice.ToString();
                        quantityTextBox.Text = product.Quantity.ToString();
                        categoryDropDownList.SelectedValue = product.CategoryId.ToString();
                        saveButton.Text = "Update";
                    }
                }
            }
            LoadAllCategory();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product aProduct = new Product();
                aProduct.Code = codeTextBox.Text;
                aProduct.Name = nameTextBox.Text;
                aProduct.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
                int rowAffected = 0;
                if (saveButton.Text == "Update")
                {
                    if (productHiddenField.Value!="")
                    {
                        aProduct.ProductId = Convert.ToInt32(productHiddenField.Value);
                    }
                    rowAffected = productManager.Update(aProduct);

                    if (rowAffected > 0)
                    {
                        msgLabel.Text = "Update Successfull!";
                    }
                    else
                    {
                        msgLabel.Text = "Update Failed!";
                    }
                }
                else
                {
                    rowAffected = productManager.SaveProduct(aProduct);

                    if (rowAffected > 0)
                    {
                        msgLabel.Text = "Saved Successfull!";
                    }
                    else
                    {
                        msgLabel.Text = "Save Failed!";
                    }
                }

            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }



        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<Product> productList = productManager.GetAllProducts();
            productGridView.DataSource = productList;
            productGridView.DataBind();

        }

        public void LoadAllCategory()
        {
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories=categoryManager.GetAllCategoryList();
            categoryDropDownList.DataSource = categories;
            categoryDropDownList.DataTextField = "Name";
            categoryDropDownList.DataValueField = "CategoryId";
            categoryDropDownList.DataBind();


        }





    }
}