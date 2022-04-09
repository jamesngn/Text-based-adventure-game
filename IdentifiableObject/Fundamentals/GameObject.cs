namespace CaseStudy
{
    public abstract class GameObject : IdentifiableObject
    {
        private readonly string _description;
        private readonly string _name;

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            this._name = name;
            this._description = desc;
        }
        public string Name
        {
            get { return _name; }
        }
        public string ShortDescription
        {
            get { return _name + " (" + FirstID + ")"; }
        }
        public virtual string FullDescription
        {
            get { return _description; }
        }

    }
}
