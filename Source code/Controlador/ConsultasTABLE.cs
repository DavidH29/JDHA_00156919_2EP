using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2_POO.Controlador
{
    public class ConsultasTABLE
    {
        public static List<TABLE> getLista(int id)
        {
            string sql = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
            "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                "WHERE ao.idProduct = pr.idProduct " +
            "AND ao.idAddress = ad.idAddress " +
            "AND ad.idUser = au.idUser " +
            "AND au.idUser = " + id;

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            List<TABLE> list = new List<TABLE>();
            foreach (DataRow row in dt.Rows)
            {
                TABLE ad = new TABLE();
                ad.idOrder = Convert.ToInt32(row[0].ToString());
                ad.createDate = row[1].ToString();
                ad.name = row[2].ToString();
                ad.fullname = row[3].ToString();
                ad.address = row[4].ToString();
                
                list.Add(ad);
            }

            return list;
        }
    }
}