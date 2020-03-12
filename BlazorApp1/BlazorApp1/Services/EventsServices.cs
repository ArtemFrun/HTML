using BlazorApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class EventsServices : IEventsServices
    {
        public HttpClient _httpClient { get; }

        public EventsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<EventsForecast>> GetEvents()
        {
            var requestMessage = await _httpClient.GetAsync("EventByDate");
            requestMessage.EnsureSuccessStatusCode();

            using var responseContent = await requestMessage.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<EventsForecast>>(responseContent);

        }
    }
}
