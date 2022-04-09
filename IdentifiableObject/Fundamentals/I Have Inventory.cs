using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name { get; }
    }
}
