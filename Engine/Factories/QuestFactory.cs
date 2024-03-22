using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
	internal static class QuestFactory
	{
		private static readonly List<Quest> _quest = new List<Quest>();

		static QuestFactory()
		{
			List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
			List<ItemQuantity> rewardItems = new List<ItemQuantity>();

			itemsToComplete.Add(new ItemQuantity(9001, 5));
			rewardItems.Add(new ItemQuantity(1002, 1));

			_quest.Add(new Quest(1,
								"Collect 3 Crystal Golem Hide from Crystal Caves (West of Rocky Fields) and bring it to the Alchemist (South of Village Outskirts).",
								" Rewards: +200 Gold, +100 Exp, and x1 Crystal Potion",itemsToComplete ));
            _quest.Add(new Quest(2,
                                 " Collect 3 Crystal Golem Hide from Crystal Caves (West of Rocky Fields) and bring it to the Alchemist (South of Village Outskirts)" ,
								 "Rewards: +200 Gold, +100 Exp, and x1 Crystal Potion", itemsToComplete));
            _quest.Add(new Quest(3, "Eliminate x3 Slimes and collect x3 Slimeballs in Green Valley (East of Village)" ,
				                 " Rewards: +20 Gold, +12 Exp, x2 Health potion, and x2 Mana potion", itemsToComplete));
            _quest.Add(new Quest(4, "Quest of the Rabid Dog Hunt: Objective: Kill x3 Rabid Dogs and gather x3 Hide/Meat in Infested Rocky Fields (South of Blacksmith, West of Village) " ,
				                 "Rewards: +25 Gold, +15 Exp, and x1 Rusty Dagger", itemsToComplete));
            _quest.Add(new Quest(5, "Quest of the Thief's Bounty: Objective: Slay at least 10 rats and defeat the Fetid Rat who can Paralyze the Player for turns in the Sewers " ,
				                  "Rewards: +50 Gold, +30 Exp, and x1 Goo Specialized Inscribe", itemsToComplete));
            _quest.Add(new Quest(6, "Quest of the Sun Temple Guardian: Objective: Defeat the Sun Temple Guardian and trade the Artifact to The Miner Zendric for some high-grade ore and a Considerable amount of Gold " ,
				                  "Rewards: +100 Gold, +50 Exp, and x1 Goo Specialized Inscribe", itemsToComplete));
            _quest.Add(new Quest(7, "Quest of the Blobby and Dark: Objective: Unlock Sewers and choose one of two quests to choose from: The Blacksmith or The Wandering Trader" ,
				                  " Rewards: +100 Gold, +50 Exp, and x1 Goo Specialized Inscribe (or x1 Random Medium Tier Loot)", itemsToComplete));
            _quest.Add(new Quest(8, "Quest of the Crystal Cave:\r\nObjective: Collect 3 Crystal Golem Hide from Crystal Caves (West of Rocky Fields) and bring it to the Alchemist (South of Village Outskirts)\r\n" ,
			                   	"Rewards: +200 Gold, +100 Exp, and x1 Crystal Potion\r\n", itemsToComplete));

        }

		internal static Quest GetQuestID(int id)
		{ 
			return _quest.FirstOrDefault(quest => quest.ID == id );
		}

	}
}
