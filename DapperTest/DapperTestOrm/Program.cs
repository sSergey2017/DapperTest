// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using DapperTestOrm;

Console.WriteLine("Dapper Test ORM!");
TestOrm testOrm = new TestOrm();
testOrm.Run();

//private const string conectionString = "Data Source=DESKTOP-8D4EL6M;Initial Catalog=DapperTestCat;Integrated Security=True;Trust Server Certificate=true;";
//const string conectionString = "Data Source=DESKTOP-8D4EL6M;Initial Catalog=DapperTestCat;Integrated Security=True;Trust Server Certificate=true;";

//using (var connection = new SqlConnection(conectionString))
//{
//    var cats = GetCatsSimple(connection);
//}

// static IEnumerable<Cat> GetCatsSimple(SqlConnection connection)
//{
//    return connection.Query<Cat>("SELECT * FROM CAT");
//}