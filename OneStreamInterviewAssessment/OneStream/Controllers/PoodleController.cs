using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneStream
{
    [Route("[controller]")]
    [ApiController]
    public class PoodleController : ControllerBase
    {
        private readonly IPoodleService _animalService;

        /// <summary>
        /// Constructor for OneStreamController that uses Dependency Injection for IAnimalService
        /// </summary>
        /// <param name="animalService"></param>
        public PoodleController(IPoodleService animalService)
        {
            _animalService = animalService;
        }

        /// <summary>
        /// GET request
        /// Returns poodles from example cache database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<IAnimal>> GetAnimals()
        {
            return await _animalService.GetAnimalsAsync();
        }

        /// <summary>
        /// POST request
        /// Creates given animal and returns it
        /// </summary>
        /// <param name="poodle"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IAnimal> CreatePoodle([FromBody] Poodle poodle)
        {
            return await _animalService.CreateAnimalAsync(poodle);
        }
    }
}