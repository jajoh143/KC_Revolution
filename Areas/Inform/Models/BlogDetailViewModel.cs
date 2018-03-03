using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.DTO;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNETWEB_KCREVOLUTION.Areas.Inform.Models
{
    public class BlogDetailViewModel
    {
        public BlogDTO Blog { get; set; }

        public BlogDetailViewModel(int id)
        {
            Blog = GetBlogData.GetBlogDetail(id);
        }
    }
}
