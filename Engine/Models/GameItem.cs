using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Engine.Models
{
	public class GameItem
	{
		public int ItemTypeId;
		public string Name;
		public int Price;
		public string Image;
		public bool IsUnique;

		public GameItem(int itemTypeId, string name, int price, string image, bool isUnique = false)
		{
            itemTypeId = ItemTypeId;
			name = Name;
			price = Price;
			image = Image;
			isUnique = IsUnique;
		}

		public GameItem Clone()
		{
			return new GameItem(ItemTypeId, Name, Price, Image, IsUnique);
		}
	}
}
