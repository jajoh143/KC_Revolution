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
    public class GetBlogData
    {
        const string connectionString = "Server=mi3-wsq2.a2hosting.com;database=jakejohn_kcrev;User Id=jakejohn_rev;password=KcRev2018!";

        public static List<BlogDTO> GetListSermons()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = @"                                
                                SELECT TOP 10
                                b.id as BlogId,
                                b.title,
                                b.long_description LongDescription,
                                b.body,
                                b.author_id AuthorId,
                                a.first_name FirstName,
                                a.last_name LastName
                                FROM
                                blog b
                                join author a on b.author_id = a.id";
                dbConnection.Open();
                return dbConnection.Query<BlogDTO>(query).ToList();
            }
        }

        public static BlogDTO GetBlogDetail(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = @"
                        SELECT
                            b.id as BlogId,
                                b.title,
                                b.long_description LongDescription,
                                b.body,
                                b.author_id AuthorId,
                                a.first_name FirstName,
                                a.last_name LastName,
                                b.created_date CreatedDate
                        FROM 
                            blog b 
                        join author a on b.author_id = a.id
                        WHERE b.id = @BlogId;";

                dbConnection.Open();
                return dbConnection.QuerySingle<BlogDTO>(query, new
                {
                    BlogId = id
                });
            }
        }
    }
}
