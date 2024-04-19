using System;
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
                "There are rows of corn growing here, with giant rats hiding between them.", 
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
            newWorld.AddLocation(-1, 1, "Smith Station ",
                "The blacksmith Ojrn, await your request.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-1, 2, "Alchemy Station ",
                "The chemist Mantra, await you.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(0, 0, "Town Square", 
                "You see a fountain here.", 
                "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", 
                "There is a gate protecting the town from the dangers outside. ", 
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
            newWorld.AddLocation(0, 2, "Wandering Trader",
                "Neil the wandering trader, here to sell you weapons and trinkets.",
                 "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-2, 0, "Town's Gate ",
                "There is a gate protecting the town from the dangers outside.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-3, 0, "Rocky Fields ",
                "There are baron rock sorround us us we journey.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-3, 1, "Miners Cave",
                "A cave full of crystals here ready to explore.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-3, 2, "Crystal Cave",
                "A cave full of crystals here ready to explore.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(0, 3, "Green Village",
                "An abandoned vilage that became the home for most slimes.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-1, 3, "Thieves Hideout",
                "A place home to theives that steals from new adventurer that pass there land.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-4, 0, "Ruined Temple ",
                "A temple full of treasure aswell as traps.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(-3, -1, "Sewer",
                "An underground tunnel system full of rats and other entities.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            //Creating Quests
            newWorld.LocationAt(0, 1).AvailableQuest.Add(QuestFactory.GetQuestID(1));
            newWorld.LocationAt(-1, 1).AvailableQuest.Add(QuestFactory.GetQuestID(2));
            newWorld.LocationAt(0, -3).AvailableQuest.Add(QuestFactory.GetQuestID(3));
            newWorld.LocationAt(-3, 0).AvailableQuest.Add(QuestFactory.GetQuestID(4));
            newWorld.LocationAt(-3, -1).AvailableQuest.Add(QuestFactory.GetQuestID(4));

            //Monsters and their respective location
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);
            newWorld.LocationAt(2, 0).AddMonster(3, 100);
            newWorld.LocationAt(0, 2).AddMonster(1, 100);
            return newWorld;
        }
    }
}
