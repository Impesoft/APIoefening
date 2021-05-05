using APIoefening.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIoefening.Services
{
    public interface IAppSuperPowerService
    {
        Task AddSuperPowerAsync(SuperPower superPower);
        Task DeleteSuperPowerAsync(int id);
        Task<List<SuperPower>> GetSuperPowersAsync();
        Task<SuperPower> GetSuperPowerAsync(int id);
        Task UpdateSuperPowerAsync(SuperPower superPower);
    }
}