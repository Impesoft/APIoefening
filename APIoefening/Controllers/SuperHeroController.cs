using APIoefening.Entities;
using APIoefening.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIoefening.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class SuperHeroController : ControllerBase
    {
        private IAppSuperHeroService _service;

        public SuperHeroController(IAppSuperHeroService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<SuperHero>> GetSuperHeroesAsync()
        {
            return await _service.GetSuperHeroesAsync();
        }

        [HttpGet("{id}")]
        public async Task<SuperHero> GetSuperHeroAsync(int id)
        {
            return await _service.GetSuperHeroAsync(id);
        }

        [HttpPost]
        public async Task AddSuperHeroAsync(SuperHero superHero)
        {
            await _service.AddSuperHeroAsync(superHero);
        }

        [HttpPut]
        public async Task UpdateSuperHeroAsync(SuperHero superHero)
        {
            await _service.UpdateSuperHeroAsync(superHero);
        }

        [HttpDelete]
        public async Task DeleteSuperHero(int id)
        {
            await _service.DeleteSuperHeroAsync(id);
        }
    }
}