using APIoefening.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIoefening.Services
{
    public interface IAppSuperHeroService
    {
        Task AddSuperHeroAsync(SuperHero superHero);

        Task<List<SuperHero>> GetSuperHeroesAsync();

        Task<SuperHero> GetSuperHeroAsync(int id);

        Task DeleteSuperHeroAsync(int id);

        Task UpdateSuperHeroAsync(SuperHero superHero);
    }
}