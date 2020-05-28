using System;

namespace Parcial_2_POO
{
    public class APPORDER
    {
        public int idOrder;
        public DateTime createDate;
        public int idProduct, idAddress;

        public APPORDER()
        {
        }

        public APPORDER(int idOrder, DateTime date, int idProduct, int idAddress)
        {
            this.idOrder = idOrder;
            createDate = date;
            this.idProduct = idProduct;
            this.idAddress = idAddress;
        }
    }
}