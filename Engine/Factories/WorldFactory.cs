﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    //Static Class
    internal static class WorldFactory
    {
        //Static Method
        internal static World CreateWorld()
        {
            //Instantiate World and create the World locations
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field", 
                "There are rows of corn growning here, with giant rats hiding between them.", 
                "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, -1, "Farmer's House", 
                "This is the house of your neighbor, Farmed Ted", 
                "/Engine;component/Images/Locations/FarmHouse.png");
            newWorld.AddLocation(0, -1, "Home", 
                "This is your home.", 
                "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-1, 0, "Trading Shop", 
                "The shop of Susan, the trader.", 
                "/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town Square", 
                "You see a fountain here.", 
                "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", 
                "There is a gate here, protecting the town from giant spiders.", 
                "/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", 
                "The trees in this forest are covered in spider webs.", 
                "/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's Hut", 
                "You see a small hut, with plants drying from the roof.", 
                "/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herbalist's Garden", 
                "There are many plants here, with snakes hiding behind them.", 
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            return newWorld;
        }
    }
}
