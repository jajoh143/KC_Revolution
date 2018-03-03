using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.DTO;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.ViewModels
{
    public class SmallGroupsViewModel
    {
        public List<SmallGroupDTO> SmallGroups { get; set; }

        public SmallGroupsViewModel()
        {
            SmallGroups = GetSmallGroupData.ListSmallGroups();
        }
    }
}
