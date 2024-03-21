﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

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
        public List<ItemQuantity> ItemsToComplete { get; set; }

		public Quest ()
    }
}
