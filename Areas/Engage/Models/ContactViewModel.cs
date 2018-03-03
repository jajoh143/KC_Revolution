using DOTNETWEB_KCREVOLUTION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNETWEB_KCREVOLUTION.Areas.Engage.Models
{
    public class ContactViewModel
    {
        public EmailDTO EmailForm { get; set; }

        public ContactViewModel()
        {
            EmailForm = new EmailDTO();
        }
    }
}
