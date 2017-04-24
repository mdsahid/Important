using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystemApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS;DataBase=InvertoryDB_42;Integrated Security=true;";
        protected void saveButton_Click(object sender, EventArgs e)
        {
            //connection
           
            SqlConnection connection = new SqlConnection(connectionString);
            
            Product aProduct=new Product();
            aProduct.Code = codeTextBox.Text;
            aProduct.Name = nameTextBox.Text;
            aProduct.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);

            //query 
            string query = "INSERT INTO Products (Code, Name, UnitPrice, Quantity)VALUES('"+aProduct.Code+"','"+aProduct.Name+"','"+aProduct.UnitPrice+"','"+aProduct.Quantity+"')";

            //execuite
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffected= command.ExecuteNonQuery();
            //result

            if (rowAffected>0)
            {
                msgLabel.Text = "Saved Successfull!";
            }
            else
            {
                msgLabel.Text = "Save Failed!";
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<Product> productList=new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product=new Product();
                    product.Code = reader["Code"].ToString();
                    product.Name = reader["Name"].ToString();
                    product.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]) ;
                    productList.Add(product);
                }
               
                reader.Close();
            }
            connection.Close();
            productGridView.DataSource = productList;
            productGridView.DataBind();

        }
    }
}