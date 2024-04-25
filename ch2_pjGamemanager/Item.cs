using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyItem
{
    public class Item
    {
        public string name;
        public string description;
        public int attack;
        public int defense;
        public int price;
        public bool equipped;
        public bool purchased;

        public Item(string name, string description, int attack, int defense, int price)
        {
            this.name = name;
            this.description = description;
            this.attack = attack;
            this.defense = defense;
            this.price = price;
            this.equipped = false;
            this.purchased = false;
        }

        public Item(Item item)
        {
            this.name = item.name;
            this.description = item.description;
            this.attack = item.attack;
            this.defense = item.defense;
            this.price = item.price;
            this.equipped = item.equipped;
            this.purchased = item.purchased;
        }
    }
}
