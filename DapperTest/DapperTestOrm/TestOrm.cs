using Microsoft.Data.SqlClient;
using Dapper;
using DapperTestOrm;
internal class TestOrm
{
    const string conectionString = "Data Source=DESKTOP-8D4EL6M;Initial Catalog=DapperTestCat;Integrated Security=True;Trust Server Certificate=true;";


    internal void Run()
    {
        using (SqlConnection? connection = new SqlConnection(conectionString))
        {
            var cats = GetCatsSimple(connection);
            var owner = GetOwnerWithParams(connection);
            var exposition = GetExpositionWithParams(connection);
            var reportList = GetDto(connection);
            var catWithChildren = GetWithChildren(connection);
        }
    }

    private IEnumerable<Cat> GetWithChildren(SqlConnection connection)
    {
        var result = new Dictionary<string, Cat>();
        return connection.Query<Cat, Owner, Exposition, Cat>(@"
            SELECT 
                c.NameCat,
                o.NameOvner,
                e.DateExpo,
                e.City,
                e.Country
            from Cat c
            inner Join Owners o on o.id = c.ownerid
            inner Join Participants p on p.Catid = c.id
            inner Join Exposition e on e.id = p.ExpoId

        ", (cat, owner, expoision ) =>
        {
            var current = cat;
            if (!result.TryGetValue(cat.NameCat, out current))
            {
                current = cat;
                current.Expositions = new HashSet<Exposition>();
                result.Add(cat.NameCat, current);
            }
            current.Owner = owner;
            current.Expositions.Add(expoision);
            return current;
        },
        splitOn: "NameCat, NameOvner, DateExpo");
        return result.Values;
    }

    private IEnumerable<ExpositionReportItemDTO> GetDto(SqlConnection connection)
    {
        return connection.Query<ExpositionReportItemDTO>(@"
            SELECT 
                e.DateExpo,
                e.City,
                e.Country,
                o.NameOvner as Ovner,
                c.NameCat as Cat
            from Cat c
            inner Join Owners o on o.id = c.ownerid
            inner Join Participants p on p.Catid = c.id
            inner Join Exposition e on e.id = p.ExpoId

        ");
    }

    private IEnumerable<Exposition> GetExpositionWithParams(SqlConnection connection)
    {
        return connection.Query<Exposition>("SELECT * FROM exposition where country = @country", new Exposition { Country = "Country" });

    }

    private IEnumerable<Owner> GetOwnerWithParams(SqlConnection connection)
    {
        return connection.Query<Owner>("SELECT * FROM owners where NameOvner = @NameOvner", new {NameOvner = "Ow1" } );
    }

    private IEnumerable<Cat> GetCatsSimple(SqlConnection connection)
    {
        //var res = connection.Query<object>("SELECT * FROM CAT");
        //return null;
        //var c = connection.Query<Cat>("SELECT * FROM CAT");
        return connection.Query<Cat>("SELECT * FROM CAT");
    }
}

//        private IEnumerable<Cat> GetCatsSimple(SqlConnection connection)
//{
//    return connection.Query<Cat>("SELECT * FROM CAT");
//}