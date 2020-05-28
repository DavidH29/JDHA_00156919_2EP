using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2_POO.Controlador
{
    public static class ConsultaAPPUSER
    {
        public static List<APPUSER> getLista()
        {
            string sql = "SELECT * FROM APPUSER;";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            List<APPUSER> list = new List<APPUSER>();
            foreach (DataRow row in dt.Rows)
            {
                APPUSER user = new APPUSER();
                user.idUser = Convert.ToInt32(row[0].ToString());
                user.fullname = row[1].ToString();
                user.username = row[2].ToString();
                user.password = row[3].ToString();
                user.userType = (bool) (row[4]);
                
                list.Add(user);
            }

            return list;
        }
    }
}