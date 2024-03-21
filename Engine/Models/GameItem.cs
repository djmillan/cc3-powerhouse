using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Engine.Models
{
	public class GameItem
	{
		public int ItemTypeId { get; set; }
		public string Name { get; set; }
		public string Price { get; set; }
		public string Image { get; set; }
		public bool IsUnique { get; set; }

		public GameItem(int itemTypeId, string name, int price, string image, bool isUnique = false)
		{
			ItemTypeId = itemTypeId;
			Name = name;
			Price = price;
			Image = image;
			IsUnique = isUnique;
		}

		public GameItem Clone()
		{
			return new GameItem(ItemTypeId, Name, Price, Image, IsUnique);
		}
	}
}
