using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    interface IElement
    {
        string reference { get; }
        string code { get; }
        int height { get; }
        int depth { get; }
        int width { get; }
        int stock { get; }
        double clientprice { get; }
        int percase { get; }
        string supplier { get; }
    }
}