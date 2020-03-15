using BlazorApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    interface IEventsServices
    {
        public Task<IEnumerable<EventsForecast>> GetEvents();

        public Task<EventsForecast> GetEventById();
    }
}
