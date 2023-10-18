using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OneStream
{
    class AnacondaService : AnimalService
    {
        private readonly ExampleCacheDatabase _exampleCacheDatabase;

        /// <summary>
        /// Constructor for AnacondaService that uses Dependency Injection for ExampleCacheDatabase
        /// </summary>
        /// <param name="exampleCacheDatabase"></param>
        public AnacondaService(ExampleCacheDatabase exampleCacheDatabase)
        {
            _exampleCacheDatabase = exampleCacheDatabase;
        }

        /// <summary>
        /// Async task that overrides GetAnimalsAsync
        /// </summary>
        /// <returns>Anacondas from example cache database</returns>
        public override async Task<IEnumerable<IAnimal>> GetAnimalsAsync()
        {
            int _waitTime = 5000;
            await Task.Delay(_waitTime);

            return _exampleCacheDatabase.GetAnacondas();
        }        

        /// <summary>
        /// Async task that overrides CreateAnimalAsync
        /// </summary>
        /// <returns>Newly created anaconda</returns>
        public override async Task<IAnimal> CreateAnimalAsync(IAnimal animal)
        {
            int _waitTime = 1000;
            await Task.Delay(_waitTime);

            return _exampleCacheDatabase.CreateAnaconda(animal as Anaconda);
        }
    }
}
