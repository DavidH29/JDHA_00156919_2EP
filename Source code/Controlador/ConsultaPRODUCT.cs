using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2_POO.Controlador
{
    public class ConsultaPRODUCT
    {
        public static List<PRODUCT> getLista()
        {
            string sql = "SELECT * FROM PRODUCT";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            List<PRODUCT> list = new List<PRODUCT>();
            foreach (DataRow row in dt.Rows)
            {
                PRODUCT ad = new PRODUCT();
                ad.idProduct = Convert.ToInt32(row[0].ToString());
                ad.idBusiness = Convert.ToInt32(row[1].ToString());
                ad.name = row[2].ToString();
                
                list.Add(ad);
            }

            return list;
        }
        
        public static int getId(string p)
        {
            string sql = String.Format("SELECT idProduct FROM PRODUCT WHERE name = '{0}';", p);
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            int id = 0;
            foreach (DataRow row in dt.Rows)
            {
                id = Convert.ToInt32(row[0].ToString());
            }
            
            return id;
        }
    }
}