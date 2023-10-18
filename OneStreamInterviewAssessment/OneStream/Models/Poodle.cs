using System;

namespace OneStream
{
    public class Poodle : IAnimal
    {
        public Class Class { get; } = Class.Mammal;

        public Species Species { get; } = Species.Dog;

        public Sex Sex { get; set; }

        public string Name { get; set; }

        public bool IsMiniature { get; set; }

        public Poodle(Sex sex, bool isMiniature, string name)
        {
            Sex = sex;
            IsMiniature = isMiniature;
            Name = name;
        }
    }
}
