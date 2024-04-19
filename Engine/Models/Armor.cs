using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Models
{
    public class Armor : GameItem
    {
        public int MinimumBlock { get; set; }
        public int MaximumBlock { get; set; }
        public Armor(int itemTypeId, string name, int price, string image, int minimumBlock, int maximumBlock) :
            base(itemTypeId, name, price, image)
        {
            minimumBlock = MinimumBlock;
            maximumBlock = MaximumBlock;
        }
        public new Armor Clone() => new Armor(ItemTypeId, Name, (Price), Image, MinimumBlock, MaximumBlock);
    }
}
