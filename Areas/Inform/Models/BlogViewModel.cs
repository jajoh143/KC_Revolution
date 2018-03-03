using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.DTO;
using DOTNETWEB_KCREVOLUTION.Areas.Inform.Models.Data.Queries;

namespace DOTNETWEB_KCREVOLUTION.Areas.Inform.Models
{
    public class BlogViewModel
    {
        public List<BlogDTO> Blogs { get; set; }

        public BlogViewModel()
        {
            Blogs = GetBlogData.GetListSermons();
        }
    }
}
