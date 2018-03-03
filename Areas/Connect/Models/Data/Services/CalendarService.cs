using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Http;
using Google.Apis.Services;
using Microsoft.AspNetCore.Hosting;
using Google.Apis.Calendar.v3;
using DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.DTO;

namespace DOTNETWEB_KCREVOLUTION.Areas.Connect.Models.Data.Services
{
    public class GoogleCalendarService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public CalendarService _googleCalendarService;
        public GoogleCalendarService()
        {
            var serviceAccountEmail = "kcrev-274@annular-axe-192103.iam.gserviceaccount.com";
            var path = Directory.GetCurrentDirectory() + "\\Areas\\Connect\\Models\\Data\\Services\\secret.p12";
            var secret = "notasecret";
            string[] scopes = new string[] { CalendarService.Scope.Calendar};

            var cert = new X509Certificate2(path, "notasecret", X509KeyStorageFlags.Exportable);
            try
            {
                ServiceAccountCredential cred = new ServiceAccountCredential(
                    new ServiceAccountCredential.Initializer(serviceAccountEmail)
                    {
                        Scopes = scopes
                    }.FromCertificate(cert));
                CalendarService calendarService = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = cred,
                    ApplicationName = "My Project"
                });
                _googleCalendarService = calendarService;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            }

        }

        public List<EventDTO> GetListedEvents(CalendarService cs)
        {
            EventsResource.ListRequest request = cs.Events.List("kcrevolutionoffice@gmail.com");
            Events eventRequest = request.Execute();
            var eventItems = eventRequest.Items.ToList().Where(x => x.Start != null);
            List<EventDTO> events = new List<EventDTO>();
            foreach (var ev in eventItems)
            {
                events.Add(new EventDTO()
                {
                    ID = ev.Id,
                    Title = ev.Summary,
                    Description = ev.Summary,
                    StartTime = ev.Start.Date,
                    EndTime = ev.End.Date
                });
            }

            Console.WriteLine(events);
            return events;
        }
    }
}
