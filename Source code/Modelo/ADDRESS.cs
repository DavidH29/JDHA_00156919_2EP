namespace Parcial_2_POO
{
    public class ADDRESS
    {
        public int idAddress, idUser;
        public string address;

        public ADDRESS()
        {
        }

        public ADDRESS(int idAddress, int idUser, string address)
        {
            this.idAddress = idAddress;
            this.idUser = idUser;
            this.address = address;
        }
    }
}