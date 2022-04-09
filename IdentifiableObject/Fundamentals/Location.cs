using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public class Location : GameObject, IHaveInventory
    {
        private readonly Inventory _inventory = new Inventory();
        private Direction _dir;
        private string _desc;
        public Location(string[] ids, string name, string desc, Direction dir) : base(ids, name, desc)
        {
            _dir = dir;
            _desc = desc;
        }
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
                return null;
            }
        }
        public string ExitDescription
        {
            get
            {
                return "There are exits to the " + Direction.Exit;
            }
        }
        public override string FullDescription
        {
            get { return "You are in " + Name + "\n" + LocationDescription + "\nIn this room you can see:\n" + Inventory.ItemList + "\n" + ExitDescription; }
        }
        public string LocationDescription
        {
            get { return this._desc; }
        }
        public Inventory Inventory
        {
            get { return this._inventory; }
        }
        public Direction Direction
        {
            get { return this._dir; }
        }
    }
}
