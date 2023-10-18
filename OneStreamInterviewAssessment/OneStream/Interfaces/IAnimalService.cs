using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneStream
{
    public interface IAnimalService
    {
        Task<IEnumerable<IAnimal>> GetAnimalsAsync();

        Task<IAnimal> CreateAnimalAsync(IAnimal animal);
    }
}
