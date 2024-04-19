using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
	public class Quest
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public  List<ItemQuantity> ItemsToComplete { get; set; }
		public int RewardExpPoints { get; set; }
		public int RewardGold { get; set; }
		public List<ItemQuantity> RewardItems {  get; set; }

		public Quest (int id, string name, string description, List<ItemQuantity> rewardItems, int rewardExpPoints, int rewardGold, List<ItemQuantity> itemsToComplete)
		{
			this.ID = id;
			this.Name = name;
			this.Description = description;
			this.RewardItems = rewardItems;
			this.RewardExpPoints = rewardExpPoints;
			this.RewardGold = rewardGold;
            this.ItemsToComplete = itemsToComplete;

        }
        public Quest(int id, string name, string description, List<ItemQuantity> rewardItems, int rewardExpPoints, int rewardGold)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardItems = rewardItems;
            this.RewardExpPoints = rewardExpPoints;
            this.RewardGold = rewardGold;

        }
        public Quest(int id, string name, string description, List<ItemQuantity> rewardItems, int rewardExpPoints)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardItems = rewardItems;
            this.RewardExpPoints = rewardExpPoints;

        }
        public Quest(int id, string name, string description, List<ItemQuantity> rewardItems)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.RewardItems = rewardItems;

        }
        public Quest(int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;


        }

    }
}
