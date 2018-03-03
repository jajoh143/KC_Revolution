using Dapper;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.Queries
{
    public class GetSmallGroupData
    {
        const string connectionString = "Server=mi3-wsq2.a2hosting.com;database=jakejohn_kcrev;User Id=jakejohn_rev;password=KcRev2018!";
        public static List<SmallGroupDTO> ListSmallGroups()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string query = @"                                
                              SELECT
	                                id,
	                                title,
	                                description,
	                                event_times EventTimes, 
	                                promo_img PromoImg,
	                                group_link GroupLink
                                FROM
	                                small_groups";
                dbConnection.Open();
                return dbConnection.Query<SmallGroupDTO>(query).ToList();
            }
        }
    }
}
