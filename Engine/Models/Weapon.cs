using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Models
{
	public class Weapon : GameItem
	{
		public int MinimumDamage { get; set; }
		public int MaximumDamage { get; set; }
		public Weapon(int itemTypeId, string name, int price, string image, int minimumDamage, int maximumDamage):
			base(itemTypeId, name, price, image)
		{
			MinimumDamage = minimumDamage;
			MaximumDamage = maximumDamage;
		}
		public new Weapon Clone()
		{
			return new Weapon(ItemTypeId, Name, int.Parse(Price), Image, MinimumDamage, MaximumDamage);
		}
	}
}