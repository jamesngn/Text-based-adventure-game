using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory = new Inventory();
        public Bag (string[] ids, string name, string desc) : base (ids, name, desc) {}
        public GameObject Locate(string id)
        {
            if (this.areYou(id))
            {
                return this;
            }
            else
            {
                Item fetchItem = Inventory.Fetch(id);
                if (fetchItem != null)
                {
                    return fetchItem;
                }
            }
            return null;
        }
        public override string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see:\n" + Inventory.ItemList;
            }
        }
        public Inventory Inventory
        {
            get
            {
                return this._inventory;
            }
        }
    }
}
