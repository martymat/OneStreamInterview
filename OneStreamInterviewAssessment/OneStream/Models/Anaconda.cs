using System;

namespace OneStream
{
    public class Anaconda : IAnimal
    {
        public Class Class { get; } = Class.Invertabrate;

        public Species Species { get; } = Species.Snake;

        public Sex Sex { get; set; }

        public string Name { get; set; }

        public bool IsLongerThan6Feet { get; set; }

        public Anaconda(Sex sex, bool isLongerThan6Feet, string name)
        {
            Sex = sex;
            IsLongerThan6Feet = isLongerThan6Feet;
            Name = name;
        }
    }
}
