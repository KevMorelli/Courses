using System;
using System.Net.Http;
using System.Threading.Tasks;
using StarWarsSample.Core.Models;
using StarWarsSample.Core.Rest.Interfaces;
using StarWarsSample.Core.Services.Interfaces;

namespace StarWarsSample.Core.Services.Implementations
{
    public class StarshipService : IStarshipService
    {
        private readonly IRestClient _restClient;

        public StarshipService(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public Task<PagedResult<Starship>> GetStarhipsAsync(string url = null)
        {
            return string.IsNullOrEmpty(url)
                         ? _restClient.MakeApiCall<PagedResult<Starship>>($"{Constants.BaseUrl}/starships/", HttpMethod.Get)
                         : _restClient.MakeApiCall<PagedResult<Starship>>(url, HttpMethod.Get);
        }
    }
}
