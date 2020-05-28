using System;

namespace Parcial_2_POO
{
    public class TABLE
    {
        public int idOrder;
        public string createDate;
        public string name, fullname, address;

        public TABLE()
        {
        }

        public TABLE(int idOrder, string date, string name, string fullname, string address)
        {
            this.idOrder = idOrder;
            createDate = date;
            this.name = name;
            this.fullname = fullname;
            this.address = address;
        }
    }
    
    
}