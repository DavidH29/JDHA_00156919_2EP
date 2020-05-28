using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2_POO.Controlador
{
    public class ConsultaADDRESS
    {

        public static List<ADDRESS> getLista(int idUser)
        {
            string sql = "SELECT idAddress, address FROM ADDRESS WHERE idUser = " + idUser;

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            List<ADDRESS> list = new List<ADDRESS>();
            foreach (DataRow row in dt.Rows)
            {
                ADDRESS ad = new ADDRESS();
                ad.idAddress = Convert.ToInt32(row[0].ToString());
                ad.address = row[1].ToString();
                ad.idUser = idUser;
                
                list.Add(ad);
            }

            return list;
        }
        public static void Add(ADDRESS a)
        {
            string sql = String.Format("INSERT INTO ADDRESS(idUser, address) VALUES({0},'{1}')", a.idUser, a.address);
            
            ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}