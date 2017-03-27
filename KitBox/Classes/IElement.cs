using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public interface IElement
    {
        string code { get; }
        string color { get; set; }
        int height { get; set; }
        int depth { get; }
        int width { get; }

        void generateCode();
    }

    //Bonjour commentaire inutile!
}