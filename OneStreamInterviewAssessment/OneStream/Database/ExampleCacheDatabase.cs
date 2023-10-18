using System;
using System.Collections.Generic;

namespace OneStream
{
    class ExampleCacheDatabase
    {
        public static List<Poodle> _poodles { get; set; }
        public static List<Anaconda> _anacondas { get; set; }

        public ExampleCacheDatabase()
        {
            CreatePoodles();
            CreateAnacondas();
        }

        public static void CreatePoodles()
        {
            var poodles = new List<Poodle>()
            {
                new Poodle(Sex.Female, false, "Annie"),
                new Poodle(Sex.Male, false, "Gizmo"),
                new Poodle(Sex.Female, false, "Lola"),
                new Poodle(Sex.Female, false, "Gala"),
            };

            _poodles = poodles;
        }

        public static void CreateAnacondas()
        {
            var anacondas = new List<Anaconda>()
            {
                new Anaconda(Sex.Male, true, "Trent"),
                new Anaconda(Sex.Male, true, "Holland"),
                new Anaconda(Sex.Female, true, "Aretha"),
                new Anaconda(Sex.Female, false, "Queen"),
            };

            _anacondas = anacondas;
        }

        public List<Poodle> GetPoodles()
        {
            return _poodles;
        }

        public List<Anaconda> GetAnacondas()
        {
            return _anacondas;
        }

        public Poodle CreatePoodle(Poodle poodle)
        {
            _poodles.Add(new Poodle(poodle.Sex, poodle.IsMiniature, poodle.Name));
            return poodle;
        }

        public Anaconda CreateAnaconda(Anaconda anaconda)
        {
            _anacondas.Add(new Anaconda(anaconda.Sex, anaconda.IsLongerThan6Feet, anaconda.Name));
            return anaconda;
        }
    }

}
