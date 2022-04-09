using System.Collections.Generic;

namespace CaseStudy
{
    public class Inventory
    {
        private List<Item> _items = new List<Item>();

        public Inventory() { }
        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.areYou(id))
                {
                    return true;
                }
            }
            return false;
        }
        public void Put(Item itm)
        {
            _items.Add(itm);
        }
        public Item Take(string id)
        {
            foreach (Item item in _items)
            {
                if (item.areYou(id))
                {
                    _items.Remove(item);
                    return item;
                }
            }
            return null;
        }
        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.areYou(id))
                {
                    return item;
                }
            }
            return null;
        }
        public string ItemList
        {
            get {
                string descItemList = "";
                if (_items.Count == 0) { descItemList = "\tNothing"; }
                else
                {
                    for (int i = 0; i < _items.Count; i++)
                    {
                        descItemList = descItemList + "\t" + _items[i].ShortDescription + "\n";
                    }
                }
                return descItemList;
            }
        }
    }
}
