using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2_POO.Controlador
{
    public class ConsultasORDER
    {
        //public APPORDER orden = new APPORDER();
        //public PRODUCT product = new PRODUCT();
        
        public static List<APPORDER> getLista()
        {
            string sql = "SELECT * FROM APPORDER";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            List<APPORDER> list = new List<APPORDER>();
            foreach (DataRow row in dt.Rows)
            {
                APPORDER ad = new APPORDER();
                ad.idOrder = Convert.ToInt32(row[0].ToString());
                ad.createDate = Convert.ToDateTime(row[1].ToString());
                ad.idProduct = Convert.ToInt32(row[2].ToString());
                ad.idAddress = Convert.ToInt32(row[3].ToString());
                
                list.Add(ad);
            }

            return list;
        }
        public static void Add(ADDRESS a)
        {
            string sql = String.Format("INSERT INTO ADDRESS(idUser, address) VALUES({0},'{1}')", a.idUser, a.address);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }

        public static void Delete(int id)
        {
            string sql = "DELETE FROM APPORDER WHERE idOrder = " + id;

            ConnectionDB.ExecuteNonQuery(sql);
        }
        
    }
}