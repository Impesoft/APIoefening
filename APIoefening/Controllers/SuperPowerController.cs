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

    public class SuperPowerController : ControllerBase
    {
        private IAppSuperPowerService _service;

        public SuperPowerController(IAppSuperPowerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<SuperPower>> GetSuperPowersAsync()
        {
            return await _service.GetSuperPowersAsync();
        }

        [HttpGet("{id}")]
        public async Task<SuperPower> GetSuperPowerAsync(int id)
        {
            return await _service.GetSuperPowerAsync(id);
        }

        [HttpPost]
        public async Task AddSuperPowerAsync(SuperPower superPower)
        {
            await _service.AddSuperPowerAsync(superPower);
        }

        [HttpPut]
        public async Task UpdateSuperPowerAsync(SuperPower superPower)
        {
            await _service.UpdateSuperPowerAsync(superPower);
        }

        [HttpDelete]
        public async Task DeleteSuperPower(int id)
        {
            await _service.DeleteSuperPowerAsync(id);
        }
    }
}