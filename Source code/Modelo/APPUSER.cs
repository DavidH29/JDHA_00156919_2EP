namespace Parcial_2_POO
{
    public class APPUSER
    {
        public int idUser;
        public string fullname, username, password;
        public bool userType;

        public APPUSER()
        {
        }

        public APPUSER(int idUser, string fullname, string username, string password, bool userType)
        {
            this.idUser = idUser;
            this.fullname = fullname;
            this.username = username;
            this.password = password;
            this.userType = userType;
        }
    }
}