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
    public class AnacondaController : ControllerBase
    {
        private readonly IAnacondaService _animalService;

        /// <summary>
        /// Constructor for OneStreamController that uses Dependency Injection for IAnimalService
        /// </summary>
        /// <param name="animalService"></param>
        public AnacondaController(IAnacondaService animalService)
        {
            _animalService = animalService;
        }

        /// <summary>
        /// GET request
        /// Returns anacondas from example cache database
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
        /// <param name="anaconda"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IAnimal> CreateAnaconda([FromBody] Anaconda anaconda)
        {
            return await _animalService.CreateAnimalAsync(anaconda);
        }
    }
}