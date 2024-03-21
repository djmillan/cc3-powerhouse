using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Engine.Factories
{
	internal static class QuestFactory
	{
		private static readonly List<Quest> _quest = new List<Quest>();

		static QuestFactory()
		{
			List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
			List<ItemQuantity> rewardItems = new List<ItemQuantity>();

			itemsToComplete.Add(new ItemQuantity(100, 3));
			rewardItems.Add(new ItemQuantity(200, 8));

			_quest.Add(new Quest(1, "Collect 3 Crystal Golem Hide from Crystal Caves (West of Rocky Fields) and bring it to the Alchemist (South of Village Outskirts). Rewards: +200 Gold, +100 Exp, and x1 Crystal Potion"));

			
		}

		internal static Quest GetQuestID(int id)
		{ 
			return _quest.FirstOrDefault(quest => quest.ID == id );
		}

	}
}
