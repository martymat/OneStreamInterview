using System;

namespace OneStream
{
    public interface IAnimal
    {
        // Mammals, reptiles, etc.
        Class Class { get; }

        // Tarantula, swordfish, etc.
        Species Species { get; }

        // Male, female, unknown
        Sex Sex { get; set; }

        // Male, female, unknown
        string Name { get; set; }
    }
}
