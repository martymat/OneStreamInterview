using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OneStream
{
    public class AnimalService : IPoodleService, IAnacondaService
    {
        public async virtual Task<IEnumerable<IAnimal>> GetAnimalsAsync()
        {
            return Enumerable.Empty<IAnimal>();
        }

        public async virtual Task<IAnimal> CreateAnimalAsync(IAnimal animal)
        {
            return new EmptyAnimal();
        }
    }
}
