using System;

namespace OneStream
{
    public class EmptyAnimal : IAnimal
    {
        public Class Class { get; } = Class.Unknown;

        public Species Species { get; } = Species.Unknown;

        public Sex Sex { get; set; } = Sex.Unknown;

        public string Name { get; set; } = "Empty";
    }
}
