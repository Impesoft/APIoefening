using APIoefening.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIoefening.Services
{
    public class AppSuperHeroService : IAppSuperHeroService
    {
        private APIContext _apiContext;

        public AppSuperHeroService(APIContext context)
        {
            _apiContext = context;
        }

        public async Task<SuperHero> GetSuperHeroAsync(int id)
        {
            return await _apiContext.SuperHeroes.FindAsync(id);
        }

        public async Task<List<SuperHero>> GetSuperHeroesAsync()
        {
            return await _apiContext.SuperHeroes.ToListAsync();
        }

        public async Task AddSuperHeroAsync(SuperHero superHero)
        {
            await _apiContext.SuperHeroes.AddAsync(superHero);
            await _apiContext.SaveChangesAsync();
        }

        public async Task DeleteSuperHeroAsync(int id)
        {
            SuperHero superHero = await _apiContext.SuperHeroes.FindAsync(id);
            _apiContext.SuperHeroes.Remove(superHero);
            await _apiContext.SaveChangesAsync();
        }

        public async Task UpdateSuperHeroAsync(SuperHero superHero)
        {
            _apiContext.SuperHeroes.Update(superHero);
            await _apiContext.SaveChangesAsync();
        }
    }
}