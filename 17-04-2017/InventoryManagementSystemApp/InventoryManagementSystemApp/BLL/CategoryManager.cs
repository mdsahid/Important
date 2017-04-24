using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryManagementSystemApp.DAL;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.BLL
{
    public class CategoryManager
    {
        CategoryGateway categoryGateway=new CategoryGateway();
        public List<Category> GetAllCategoryList()
        {
            List<Category> categories = categoryGateway.GetAllCategorics();
            return categories;
        }
    }
}