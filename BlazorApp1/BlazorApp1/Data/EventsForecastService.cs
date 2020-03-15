using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class EventsForecastService
    {
        public IList<EventsForecast> events = new List<EventsForecast>
        {   new EventsForecast{name = "Event 1", description = "Description Event 1", date = new DateTime(2020,03,05), category = "Category 1", owner = "User 1", location = "locations 1", photo = @"C:\Users\tjomka777tjomka777\Source\Repos\BlazorApp1\BlazorApp1\s375.webp"},
            new EventsForecast{name = "Event 2", description = "Description Event 2", date = new DateTime(2020,05,15), category = "Category 2", owner = "User 2", location = "locations 2", photo = @"C:\Users\tjomka777tjomka777\Source\Repos\BlazorApp1\BlazorApp1\s375.webp"},
            new EventsForecast{name = "Event 3", description = "Description Event 3", date = new DateTime(2020,04,10), category = "Category 3", owner = "User 3", location = "locations 3", photo = @"C:\Users\tjomka777tjomka777\Source\Repos\BlazorApp1\BlazorApp1\s375.webp"},
            new EventsForecast{name = "Event 4", description = "Description Event 4", date = new DateTime(2020,06,20), category = "Category 4", owner = "User 4", location = "locations 4", photo = @"C:\Users\tjomka777tjomka777\Source\Repos\BlazorApp1\BlazorApp1\s375.webp"},
        };

        public async Task<IEnumerable<EventsForecast>> GetEvents()
        {
            return events;
        }

        public async Task<EventsForecast> GetEvent(string name)
        {
            return events.FirstOrDefault(e => e.name == name);
        }
    } 
}
