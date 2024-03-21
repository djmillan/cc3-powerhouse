using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;
using Engine.Models;

namespace Engine.Models
{
	public class Weapon : class GameItem
	{
		public int MinimumDamage { get; set; }
		public int MaximumDamage { get; set; }
		public Weapon(int itemTypeId, string name, int price, string image, int minimumDamage, int maximumDamage):
			base(itemTypeId, name, price, image, true)
		{
			MinimumDamage = minimumDamage;
			MaximumDamage = maximumDamage;
		}
		public new Weapon Clone()
		{
			return new Weapon (itemTypeId, name, price, image,minimumDamage, maximumDamage)
		}
	}
}
