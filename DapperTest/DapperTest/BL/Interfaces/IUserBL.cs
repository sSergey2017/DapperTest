using DapperTest.DAL.Models;

namespace DapperTest.BL.Interfaces
{
    public interface IUserBL
    {
        int? Autentificate(string email, string password);
        User GetUserById(int userid);
    }
}
