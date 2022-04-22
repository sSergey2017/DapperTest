using DapperTest.BL.Interfaces;
using DapperTest.DAL.Interfaces;
using DapperTest.DAL.Models;

namespace DapperTest.BL.Implementation
{
    public class UserBL : IUserBL
    {
        private readonly IUserDAL userDAL;

        public UserBL(IUserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        public int? Autentificate(string email, string password)
        {
            var encpass = Encrypt(password);
            foreach (User user in userDAL.FindByEmail(email))
            {
                if (user.Password == encpass)
                {
                    return user.UserId;
                } 
            }
            return null;
        }

        public User GetUserById(int userid)
        {
            return userDAL.FindById(userid);
        }

        private string Encrypt(string password)
        {
            return password;
        }
    }
}
