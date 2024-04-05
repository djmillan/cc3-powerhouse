﻿using System;
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
			_standardGameItems.Add(new Weapon(1001, "Magical Bow", 1,"", 1, 2));
			_standardGameItems.Add(new Weapon(1002, "Iron Dagger", 5,"", 1, 3));
			_standardGameItems.Add(new GameItem(9001, "Wizard Boots", 4,""));
			_standardGameItems.Add(new GameItem(9002, "Golden Dagger", 1, ""));
			_standardGameItems.Add(new GameItem(9003, "Shield", 10, ""));
			_standardGameItems.Add(new GameItem(9004, "Snipers Chestplate", 8, ""));
			_standardGameItems.Add(new GameItem(9004, "Iron Sword", 6, ""));
			_standardGameItems.Add(new GameItem(9004, "Leather Hood", 2, ""));
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
