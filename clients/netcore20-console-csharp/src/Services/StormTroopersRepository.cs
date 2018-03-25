using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using NetCore20.Models;

namespace NetCore20.Services
{
    public class StormTroopersRepository : IDisposable
    {
        private HttpClient _httpClient;

        public StormTroopersRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5000/api/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetAllAsync(CancellationToken cancellationToken)
        {
            using(HttpResponseMessage response = await _httpClient.GetAsync("stormtroopers", cancellationToken))
            {
                if(response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                return String.Empty;
            };
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }
                disposedValue = true;
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}