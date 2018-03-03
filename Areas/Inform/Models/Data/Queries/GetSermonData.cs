using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.DTO;

namespace DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.Queries
{
    public class GetSermonData
    {
        const string connectionString = "Server=mi3-wsq2.a2hosting.com;database=jakejohn_kcrev;User Id=jakejohn_rev;password=KcRev2018!";

        public static List<SermonDTO> GetListSermons()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = @"                                
                                SELECT TOP 10
                                s.id,
                                s.sermon_name as SermonName,
                                s.sermon_description as SermonDescription,
                                s.sermon_file_location as SermonFileLocation,
                                a.first_name as AuthorFirstName, 
                                a.last_name as AuthorLastName,
                                s.created_date as CreatedDate,
                                ss.title AS SeriesTitle,
                                ss.id as SeriesId
                                FROM
                                sermon s
                                JOIN author a ON s.author_id = a.id
                                JOIN sermon_series ss on s.series_id = ss.id";
                dbConnection.Open();
                return dbConnection.Query<SermonDTO>(query).ToList();
            }
        }
    }
}
