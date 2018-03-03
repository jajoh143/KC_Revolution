using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.DTO
{
    public class SermonDTO
    {
        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string SermonName { get; set; }
        public string SermonDescription { get; set; }
        public string SermonFileLocation { get; set; }
        public string SeriesTitle { get; set; }
        public int SeriesId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
