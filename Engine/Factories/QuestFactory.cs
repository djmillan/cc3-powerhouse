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
			List<ItemQuantity> itemsToCompleteQ1 = new List<ItemQuantity>();
			List<ItemQuantity> rewardItemsQ1 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ2 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ3 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ4 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ4 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ5 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ5 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ6 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ6 = new List<ItemQuantity>();
            List<ItemQuantity> itemsToCompleteQ7 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItemsQ7 = new List<ItemQuantity>();

            itemsToCompleteQ1.Add(new ItemQuantity(8001, 5));
			rewardItemsQ1.Add(new ItemQuantity(1013,1));
            itemsToCompleteQ2.Add(new ItemQuantity(8017, 3));
            rewardItemsQ2.Add(new ItemQuantity(1004, 1));
            itemsToCompleteQ3.Add(new ItemQuantity(8007, 3));
            rewardItemsQ3.Add(new ItemQuantity(9010, 1));
            itemsToCompleteQ4.Add(new ItemQuantity(8008, 3));
            rewardItemsQ4.Add(new ItemQuantity(1009, 1));
            itemsToCompleteQ5.Add(new ItemQuantity(8001, 5));
            rewardItemsQ5.Add(new ItemQuantity(1013, 1));
            itemsToCompleteQ6.Add(new ItemQuantity(8020, 1));
            rewardItemsQ6.Add(new ItemQuantity(9011, 1));
            itemsToCompleteQ7.Add(new ItemQuantity(8013, 1));
            rewardItemsQ7.Add(new ItemQuantity(1007, 1));

            _quest.Add(new Quest(1, "Rat Extermination","Slay 5 or more rats in (Farmer's Field) and bring the rat hide as proof of extermination.",rewardItemsQ1,50,100,itemsToCompleteQ1 ));
            _quest.Add(new Quest(2, "Crystal Heist"," Collect 3 Crystals dropped by Crystal Golem from Crystal Caves (North of Rocky Fields) and bring it to the Alchemist (South of Village Outskirts)" ,rewardItemsQ2,30,150, itemsToCompleteQ2));
            _quest.Add(new Quest(3, "Messy and Blobby","Eliminate x3 Slimes and collect x3 Slimeballs in Green Valley (East of Village)",rewardItemsQ3 ,20, 12, itemsToCompleteQ3));
            _quest.Add(new Quest(4, "Rabid Dog Hunt","Kill x3 Rabid Dogs and gather x3 Rabid Dog Tooth in Infested Rocky Fields (South of Blacksmith, West of Village) ",rewardItemsQ4 ,25,15, itemsToCompleteQ4));
            _quest.Add(new Quest(5, "They call me The Fetid Rat"," Slay at least 10 rats and defeat the Fetid Rat who can Paralyze the Player for turns in the Sewers " ,rewardItemsQ5,50,30, itemsToCompleteQ5));
            _quest.Add(new Quest(6, "Sun God Slayer","Defeat the Sun Temple Guardian and trade the Artifact to The Miner Zendric for some high-grade ore and a Considerable amount of Gold " ,rewardItemsQ6,100,50, itemsToCompleteQ6));
            _quest.Add(new Quest(7, "The Dark Blob ", "Quest of the Blobby and Dark: Objective: Unlock Sewers and choose one of two quests to choose from: The Blacksmith or The Wandering Trader",rewardItemsQ7,100,50, itemsToCompleteQ7));
          
        }

		internal static Quest GetQuestID(int id)
		{ 
			return _quest.FirstOrDefault(quest => quest.ID == id );
		}

	}
}
