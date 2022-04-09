namespace CaseStudy
{
    public class Look_Command : Command
    {
        public Look_Command() : base(new string[] { "look", "examine" }) { }

        public override string Execute(Player p, string[] text)
        {
            if (text[0].ToLower() == "look")
            {
                //look: return the current location and describe the contaned element in the room
                if (text.Length == 1) { return p.Location.FullDescription; }
                if (text[1].ToLower() != "at") { return "What do you want to look at?"; }
                if (text.Length == 3)
                {

                    if (p.Locate(text[2]) == p)
                    {
                        return p.FullDescription;
                    }
                    else if (p.Location.Inventory.HasItem(text[2].ToLower()))
                    {
                        return LookAtIn(text[2].ToLower(), p.Location);
                    }
                    return LookAtIn(text[2].ToLower(), p);
                }
                if (text.Length == 5)
                {
                    if (text[3].ToLower() != "in")
                    {
                        return "What do you want to look in?";
                    }
                    IHaveInventory container = FetchContainer(p, text[4].ToLower());
                    if (container == null)
                    {
                        return "I can't find the " + text[4].ToLower();
                    }
                    return LookAtIn(text[2].ToLower(), container);
                }
            }
            if (text[0].ToLower() == "examine")
            {
                if (text.Length == 2)
                {
                    return LookAtIn(text[1].ToLower(), p.Location);
                }
                return "Error in examine command input";
            }
            return null;
        }

        public IHaveInventory FetchContainer(Player p, string containerID)
        {
            return p.Locate(containerID) as IHaveInventory;
        }
        public string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject fetchItem = container.Locate(thingId);
            if (fetchItem != null)
            {
                return fetchItem.FullDescription;
            }
            else if (container is Player)
            {
                return "I can't find the " + thingId;
            }
            return "I can't find the " + thingId + " in the " + container.Name;
        }
    }
}
