using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.DTO;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.Queries;

namespace DOTNETWEB_KCREVOLUTION.Areas.Inform.Models
{
    public class WorshipSeriesViewModel
    {
        public IEnumerable<SermonDTO> Sermons { get; set; }

        public WorshipSeriesViewModel()
        {
            Sermons = GetSermonData.GetListSermons();
        }

    }
}
