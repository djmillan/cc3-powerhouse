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
            this.ItemTypeId = itemTypeId;
            this.Name = name;
            this.Price = price;
            this.Image = image;
            this.IsUnique = isUnique;

		}
        public GameItem(int itemTypeId, string name, int price, bool isUnique = false)
        {
            this.ItemTypeId = itemTypeId;
            this.Name = name;
            this.Price = price;
            this.IsUnique= isUnique;

        }
        public GameItem(int itemTypeId, string name,string image, bool isUnique = false)
        {
            this.ItemTypeId = itemTypeId;
            this.Name = name;
            this.Image= image;
            this.IsUnique = isUnique;
        }

        public GameItem Clone()
		{
			return new GameItem(ItemTypeId, Name, Price, Image, IsUnique);
		}
	}
}
