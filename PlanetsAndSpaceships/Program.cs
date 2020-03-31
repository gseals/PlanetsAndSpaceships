using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            // this and below are the same: planetList.AddRange(new List<string>() { "Jupiter", "Saturn" });
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");

            // .Add() places new items at the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            // .AddRange() is useful to add more than one string to a list
            planetList.AddRange(lastPlanets);
            // .Insert() accepts an index to place an item and the item itself
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            // GetRange() accepts a beginning index and an ending index
            var rockyPlanets = planetList.GetRange(0, 4);
            // Remove() finds a specific item and removes it
            planetList.Remove("Pluto");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
                Console.ReadLine();
            }

            var satellites = new Dictionary<string, List<string>>();

            satellites.Add("Mariner 10", new List<string> {"Mercury, Earth, Jupiter, Uranus" });
            satellites.Add("Voyager 1", new List<string> { "Venus, Mars, Saturn, Neptune" });
            satellites.Add("Cassini", new List<string> { "Mercury, Neptune" });
            satellites.Add("Ulysses", new List<string> { "Venus, Uranus"});
            satellites.Add("Pioneer 11", new List<string> { "Earth, Saturn" });
            satellites.Add("Sputnik", new List<string> { "Mars, Jupiter" });

            foreach (var (satellite, planets) in satellites)
            {
                Console.Write($"Satellite: {satellite}. Planets: ");
                for (int i = 0; i < planets.Count; i++)
                {
                    Console.Write($"{planets[i]}");
                };
                Console.ReadLine();
            }
        }
    }
}
