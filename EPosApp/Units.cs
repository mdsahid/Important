using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPosApp
{
  public class Units
    {

      public void insertUnit(int parent_id, string name, int qty, int value)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[4];

            //parameters[0] = new SqlParameter("@c_id", SqlDbType.Int);
            //parameters[0].Value = cid;

            parameters[0] = new SqlParameter("@p_id", SqlDbType.Int);
            parameters[0].Value = parent_id;

            parameters[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[2].Value = qty;

            parameters[3] = new SqlParameter("@value", SqlDbType.Int);
            parameters[3].Value = value;

            //parameters[4] = new SqlParameter("@create", SqlDbType.DateTime);
            //parameters[4].Value = created;

            

            db.setData("spr_insert_unit", parameters);
            db.closeConnection();

        }

        public DataTable getUnits()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_units", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getUnit(int id)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            tab = db.getData("spr_get_unit_by_id", parameters);
            db.closeConnection();
            return tab;
        }

        //public DataTable getProductsByCategory(int cat_id)
        //{
        //    DB db = new DB();
        //    DataTable table = new DataTable();
        //    SqlParameter[] parameters = new SqlParameter[1];
        //    parameters[0] = new SqlParameter("@cid", SqlDbType.Int);
        //    parameters[0].Value = cat_id;
        //    table = db.getData("spr_products_by_category", parameters);
        //    db.closeConnection();
        //    return table;
        //}


        public DataTable searchUnit(string valueToSearch)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Units", parameters);
            db.closeConnection();
            return table;
        }

        public void deleteUnits(int unit_id)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@uid", SqlDbType.Int);
            parameters[0].Value = unit_id;

            db.openConnection();
            db.setData("spr_delete_Units", parameters);
            db.closeConnection();

        }

        public void updateUnit(int parent_id, string name, int qty, int value)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            //parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            //parameters[0].Value = cid;

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = parent_id;

            //parameters[1] = new SqlParameter("@c_id", SqlDbType.Int);
            //parameters[1].Value = cid;

            parameters[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[2].Value = qty;

            parameters[3] = new SqlParameter("@value", SqlDbType.Int);
            parameters[3].Value = value;

           

                              

            db.setData("spr_update_Unit", parameters);
            db.closeConnection();

        }
    }
}
