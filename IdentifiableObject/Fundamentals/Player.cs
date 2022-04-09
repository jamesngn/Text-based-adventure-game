namespace CaseStudy
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory = new Inventory();
        private Path _path = new Path();
        private Location _location;
        public Player(string name, string desc) : base(new string[] { "me", "inventory", "inv" }, name, desc) 
        {
            Location = _path.Map[0];
        }
        public GameObject Locate(string id)
        {
            if (this.areYou(id))
            {
                return this;
            }
            if (Location.areYou(id))
            {
                return Location;
            }
            Item fetchItem = Inventory.Fetch(id);
            if (fetchItem != null)
            {
                return fetchItem;
            }
            fetchItem = Location.Inventory.Fetch(id);
            if (fetchItem != null)
            {
                return fetchItem;
            }
            return null; 
        }
        public override string FullDescription
        {
            get 
            {
                return "You are carrying:\n" + Inventory.ItemList;            
            }
        }
        public Location Location
        {
            get { return this._location; }
            set 
            {
                this._location = value;
                if (_location.Direction.North != -1)
                {
                    Path.addIdentifier("north");
                    Path.addIdentifier("n");
                }
                if (_location.Direction.South != -1)
                {
                    Path.addIdentifier("south");
                    Path.addIdentifier("s");
                }
                if (_location.Direction.East != -1)
                {
                    Path.addIdentifier("east");
                    Path.addIdentifier("e");
                }
                if (_location.Direction.West != -1)
                {
                    Path.addIdentifier("west");
                    Path.addIdentifier("w");
                }
            }
        }
        public Inventory Inventory
        {
            get { return _inventory; }
        }
        public Path Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
    }
}
