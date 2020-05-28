namespace Parcial_2_POO
{
    public class PRODUCT
    {
        public int idProduct, idBusiness;
        public string name;

        public PRODUCT()
        {
        }

        public PRODUCT(int idProduct, int idBusiness, string name)
        {
            this.idProduct = idProduct;
            this.idBusiness = idBusiness;
            this.name = name;
        }
    }
}