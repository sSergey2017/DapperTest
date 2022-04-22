using DapperTest.DAL.Interfaces;
using DapperTest.DAL.Models;
using Dapper;

namespace DapperTest.DAL.Implementation
{
    public class UserDAL : IUserDAL
    {
        public IEnumerable<User> FindByEmail(string email)
        {
            using(var connection = DBConnection.CreateConnection()){
               return connection.Query<User>("select * from [User] where Email = @e", 
                    new { e = email });
            }
        }

        public User FindById(int id)
        {
            using (var connection = DBConnection.CreateConnection())
            {
                return connection.Query<User>("select * from [User] where UserId = @id",
                     new { id = id }).FirstOrDefault();
            }
        }
    }
}
