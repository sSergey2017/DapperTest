using DapperTest.DAL.Models;

namespace DapperTest.DAL.Interfaces
{
    public interface IUserDAL
    {
        IEnumerable<User> FindByEmail(string email);
        User FindById(int id);
    }
}
