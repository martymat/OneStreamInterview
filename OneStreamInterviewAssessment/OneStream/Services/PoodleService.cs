using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OneStream
{
    class PoodleService : AnimalService
    {

        private readonly ExampleCacheDatabase _exampleCacheDatabase;

        /// <summary>
        /// Constructor for PoodleService that uses Dependency Injection for ExampleCacheDatabase
        /// </summary>
        /// <param name="exampleCacheDatabase"></param>
        public PoodleService(ExampleCacheDatabase exampleCacheDatabase)
        {
            _exampleCacheDatabase = exampleCacheDatabase;
        }
        
        /// <summary>
        /// Async task that overrides GetAnimalsAsync
        /// </summary>
        /// <returns>Poodles from example cache database</returns>
        public override async Task<IEnumerable<IAnimal>> GetAnimalsAsync()
        {
            int _waitTime = 5000;
            await Task.Delay(_waitTime);

            return _exampleCacheDatabase.GetPoodles();
        }

        /// <summary>
        /// Async task that overrides CreateAnimalAsync
        /// </summary>
        /// <returns>Newly created poodle</returns>
        public override async Task<IAnimal> CreateAnimalAsync(IAnimal animal)
        {
            int _waitTime = 1000;
            await Task.Delay(_waitTime);

            return _exampleCacheDatabase.CreatePoodle(animal as Poodle);
        }
    }
}
