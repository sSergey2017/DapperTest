using Microsoft.Data.SqlClient;

namespace DapperTest.DAL.Implementation
{
    public class DBConnection
    {
        public static SqlConnection CreateConnection()
        {
            // return new SqlConnection("Data Source=.;Initial Catalog=DapperTest; Integrated Sequrity=true;Trusted Server Certificate=true;");
            return new SqlConnection("Data Source=DESKTOP-8D4EL6M;Initial Catalog=DapperTest;Integrated Security=True;Trust Server Certificate=true;");
        }
    }
}

// "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=loftBlogASPCoreDb;Trusted_Connection=True;MultipleActiveResultSets=true"
