using System.Collections.Generic;

namespace CaseStudy
{
    public class IdentifiableObject
    {
        private readonly List<string> _identifiers = new List<string>();
        public IdentifiableObject(string[] identifiers)
        {
            foreach (string identifier in identifiers)
            {
                _identifiers.Add(identifier);
            }
        }
        public bool areYou(string id)
        {
            foreach (string identifier in _identifiers)
            {
                if (id.ToLower() == identifier.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        public string FirstID
        {
            get { return _identifiers[0]; }
        }

        public void addIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}
