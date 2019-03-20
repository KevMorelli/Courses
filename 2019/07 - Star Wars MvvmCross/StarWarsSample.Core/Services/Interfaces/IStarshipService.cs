using System;
using System.Threading.Tasks;
using StarWarsSample.Core.Models;

namespace StarWarsSample.Core.Services.Interfaces
{
    public interface IStarshipService
    {
        Task<PagedResult<Starship>> GetStarhipsAsync(string url = null);
    }
}
