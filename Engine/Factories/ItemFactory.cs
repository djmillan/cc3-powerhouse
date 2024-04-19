using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
	public static class ItemFactory
	{
		private static List<GameItem> _standardGameItems;
		static ItemFactory()
		{
			_standardGameItems = new List<GameItem>();
            //Weapon
            _standardGameItems.Add(new Weapon(1001, "Sparky Staff", 30, "", 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Frost Staff", 90, "", 3, 4));
            _standardGameItems.Add(new Weapon(1003, "Flameburst Staff", 140, "", 5, 6));
            _standardGameItems.Add(new Weapon(1004, "Crystal Staff", 200, "", 7, 8));
            _standardGameItems.Add(new Weapon(1005, "Wooden Bow", 30, "", 1, 2));
            _standardGameItems.Add(new Weapon(1006, "Long Bow", 90, "", 3, 4));
            _standardGameItems.Add(new Weapon(1007, "Recurve Bow", 140, "", 5, 6));
            _standardGameItems.Add(new Weapon(1008, "CrossBow", 200, "", 7, 8));
            _standardGameItems.Add(new Weapon(1009, "Rusty Dagger", 30, "", 1, 2));
            _standardGameItems.Add(new Weapon(1010, "Silver Dagger", 9, "", 1, 2));
            _standardGameItems.Add(new Weapon(1011, "Sai", 140, "", 1, 2));
            _standardGameItems.Add(new Weapon(1012, "Iron Gauntlet", 200, "", 1, 2));
            _standardGameItems.Add(new Weapon(1013, "Shortsword", 30, "", 1, 2));
            _standardGameItems.Add(new Weapon(1014, "Sword", 90, "", 1, 2));
            _standardGameItems.Add(new Weapon(1015, "Longsword", 140, "", 1, 2));
            _standardGameItems.Add(new Weapon(1001, "Great Sword", 200, "", 1, 2));
            //Equipment
            _standardGameItems.Add(new Armor(9001, "Sholar's Robe", 20, "",0,1));
            _standardGameItems.Add(new Armor(9002, "Wizard Robe", 50, "", 1, 3));
            _standardGameItems.Add(new Armor(9003, "Arcane Robe", 75, "", 2, 4));
            _standardGameItems.Add(new Armor(9004, "Bowman's Jacket", 20, "", 0, 1));
            _standardGameItems.Add(new Armor(9005, "Ranger Jacket", 60, "", 2, 3));
            _standardGameItems.Add(new Armor(9006, "Sniper Chestplate", 80, "", 3, 4));
            _standardGameItems.Add(new Armor(9007, "Silky Cloak", 20, "", 0, 1));
            _standardGameItems.Add(new Armor(9008, "Leather Chestplate", 50, "", 2, 3));
            _standardGameItems.Add(new Armor(9009, "Silk Cloaked Chestplate", 90, "", 3, 4));
            _standardGameItems.Add(new Armor(9010, "Iron Chestplate", 30, "", 2, 3));
            _standardGameItems.Add(new Armor(9011, "Chainmail Chestplate", 60, "", 4, 5));
            _standardGameItems.Add(new Armor(9012, "Steel-plated Chestplate", 100, "", 6, 7));

            //QuestItems
            _standardGameItems.Add(new GameItem(8001, "Rat Hide", 1,""));
            _standardGameItems.Add(new GameItem(8002, "Snake Hide", 1, ""));
            _standardGameItems.Add(new GameItem(8003, "Snake Fang", 1, ""));
            _standardGameItems.Add(new GameItem(8004, "Spider Eye", 1, ""));
            _standardGameItems.Add(new GameItem(8005, "Spider Silk", 2, ""));
            _standardGameItems.Add(new GameItem(8006, "Theif's Scarf", 5, ""));
            _standardGameItems.Add(new GameItem(8007, "SlimeBall", 2, ""));
            _standardGameItems.Add(new GameItem(8008, "Rabid Dog Tooth ", 3, ""));
            _standardGameItems.Add(new GameItem(8009, "Wolf Fur", 5, ""));
            _standardGameItems.Add(new GameItem(8010, "Wolf Fang", 3, ""));
            _standardGameItems.Add(new GameItem(8011, "Crab Meat", 2, ""));
            _standardGameItems.Add(new GameItem(8012, "Fetid Coarpse", ""));
            _standardGameItems.Add(new GameItem(8013, "Black Gel", ""));
            _standardGameItems.Add(new GameItem(8014, "Goblin Ear", 3, ""));
            _standardGameItems.Add(new GameItem(8015, "Troll Tears", 5, ""));
            _standardGameItems.Add(new GameItem(8016, "Stone Shard", 5, ""));
            _standardGameItems.Add(new GameItem(8017, "Crystal Shard", 10, ""));
            _standardGameItems.Add(new GameItem(8018, "Lizhard Eye", 5, ""));
            _standardGameItems.Add(new GameItem(8019, "Stone Wing", 20, ""));
            _standardGameItems.Add(new GameItem(8020, "Sunfire Artifact", ""));
            

        }
        public static GameItem CreateGameItem()
		{
			if (_standardGameItems.Count > 0) 
			{
				if(_standardGameItems is Weapon)
				{
					return _standardGameItems [0].Clone();
				}
			}
			return null;
		}
	}
}
