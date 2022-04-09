namespace CaseStudy
{
    class Take_Command : Command
    {
        public Take_Command() : base(new string[] { "take", "pickup" }) { }
        public override string Execute(Player p, string[] text)
        {
            if (text.Length == 2)
            {
                if (p.Location.Inventory.HasItem(text[1].ToLower()))
                {
                    Item takenItem = p.Location.Inventory.Take(text[1].ToLower());
                    p.Inventory.Put(takenItem);
                    return "You have taken " + takenItem.Name + " from " + p.Location.Name;
                }
            }
            return null;
        }
   }
}
