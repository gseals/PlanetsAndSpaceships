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
            Console.WriteLine(planetList);
        }
    }
}
