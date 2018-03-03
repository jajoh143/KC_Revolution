using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.DTO;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.Services;

namespace DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.ViewModels
{ 
    public class CalendarViewModel
    {
        public List<EventDTO> Events { get; set; }
        public CalendarViewModel()
        {
            var cs = new GoogleCalendarService();
            Events = cs.GetListedEvents(cs._googleCalendarService);
        }
    }
}
