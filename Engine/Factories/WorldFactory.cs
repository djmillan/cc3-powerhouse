using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    // Static class
    internal static class WorldFactory
    {
        // Static method
        internal static World CreateWorld()
        {
            // Instantiate World and create the World locations
            World newWorld = new World();
            var locations = new Dictionary<(int x, int y), (string name, string description, string imagePath)>
            {
                (-2, -1, ("Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them.", "/Engine;component/Images/Locations/FarmFields.png")),
                (-1, -1, ("Farmer's House", "This is the house of your neighbor, Farmer Ted.", "/Engine;component/Images/Locations/FarmHouse.png")),
                (0, -1, ("Home", "This is your home.", "/Engine;component/Images/Locations/Home.png")),
                (-1, 0, ("Trading Shop", "The shop of Susan, the trader.", "/Engine;component/Images/Locations/Trader.png")),
                (0, 0, ("Town Square", "You see a fountain here.", "/Engine;component/Images/Locations/TownSquare.png")),
                (1, 0, ("Town Gate", "There is a gate here, protecting the town from giant spiders.", "/Engine;component/Images/Locations/TownGate.png")),
                (2, 0, ("Spider Forest", "The trees in this forest are covered in spider webs.", "/Engine;component/Images/Locations/SpiderForest.png")),
                (0, 1, ("Herbalist's Hut", "You see a small hut, with plants drying from the roof.", "/Engine;component/Images/Locations/HerbalistsHut.png")),
                (0, 2, ("Herbalist's Garden", "There are many plants here, with snakes hiding behind them.", "/Engine;component/Images/Locations/HerbalistsGarden.png"))
            };

            foreach (var location in locations)
            {
                newWorld.AddLocation(location.Key.x, location.Key.y, location.Value.name, location.Value.description, location.Value.imagePath);
            }

            return newWorld;
        }
    }
}
