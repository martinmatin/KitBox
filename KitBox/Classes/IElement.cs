using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public interface IElement
    {
        string Code { get; }
        string Color { get; set; }
        int Height { get; set; }
        int Depth { get; }
        int Width { get; }

        void GenerateCode();
    }
}