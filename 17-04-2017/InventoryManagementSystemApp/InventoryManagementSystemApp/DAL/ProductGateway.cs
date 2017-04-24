using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.DAL
{
    public class ProductGateway
    {
        string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS;DataBase=InvertoryDB_42;Integrated Security=true;";
        public List<Product> GetAllProducts()
        {
            List<Product> productList = new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    product.Code = reader["Code"].ToString();
                    product.Name = reader["Name"].ToString();
                    product.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    product.Quantity = Convert.ToInt32(reader["Quantity"]);
                    productList.Add(product);
                }

                reader.Close();
            }
            connection.Close();
            return productList;
        }
        public Product GetProductByCode(string code)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Products  where Code='" + code + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Product product = new Product();
            if (reader.HasRows)
            {
                reader.Read();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["Name"].ToString();
                product.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                product.Quantity = Convert.ToInt32(reader["Quantity"]);

                reader.Close();
            }
            connection.Close();
            return product;
        }
        public int SaveProduct(Product aProduct)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Products (Code, Name, UnitPrice, Quantity,CategoryId)VALUES('" + aProduct.Code + "','" +
                           aProduct.Name + "','" + aProduct.UnitPrice + "','" + aProduct.Quantity + "','"+aProduct.CategoryId+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public int Update(Product aProduct)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Products Set Code='" + aProduct.Code + "'," +
                           "Name='" + aProduct.Name + "'," +
                           "UnitPrice='" + aProduct.UnitPrice + "'," +
                           " Quantity='" + aProduct.Quantity + "'," +
                           "CategoryId='"+aProduct.CategoryId+"' WHERE ProductId='" + aProduct.ProductId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}