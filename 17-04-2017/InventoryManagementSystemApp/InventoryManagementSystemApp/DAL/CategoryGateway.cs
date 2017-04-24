using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.DAL
{
    public class CategoryGateway
    {

        string connectionString = @"Server=BITM-TRAINER-30\SQLEXPRESS;DataBase=InvertoryDB_42;Integrated Security=true;";
        public List<Category> GetAllCategorics()
        {
            List<Category> categories = new List<Category>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Category category = new Category();
                    category.CategoryId = (int)reader["CategoryId"];
                    category.Name = reader["Name"].ToString();
                    categories.Add(category);

                }
                reader.Close();
            }
            connection.Close();
            return categories;
        }
    }
}
