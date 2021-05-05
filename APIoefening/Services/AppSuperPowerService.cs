using APIoefening.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIoefening.Services
{
    public class AppSuperPowerService : IAppSuperPowerService
    {
        private APIContext _apiContext;

        public AppSuperPowerService(APIContext context)
        {
            _apiContext = context;
        }

        public async Task<SuperPower> GetSuperPowerAsync(int id)
        {
            return await _apiContext.SuperPowers.FindAsync(id);
        }

        public async Task<List<SuperPower>> GetSuperPowersAsync()
        {
            return await _apiContext.SuperPowers.ToListAsync();
        }

        public async Task AddSuperPowerAsync(SuperPower superPower)
        {
            await _apiContext.SuperPowers.AddAsync(superPower);
            await _apiContext.SaveChangesAsync();
        }

        public async Task DeleteSuperPowerAsync(int id)
        {
            SuperPower superPower = await _apiContext.SuperPowers.FindAsync(id);
            _apiContext.SuperPowers.Remove(superPower);
            await _apiContext.SaveChangesAsync();
        }

        public async Task UpdateSuperPowerAsync(SuperPower superPower)
        {
            _apiContext.SuperPowers.Update(superPower);
            await _apiContext.SaveChangesAsync();
        }
    }
}