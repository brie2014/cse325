using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Sambrano
{
    public class Desk
    {
        // Desk Constraints
        public const int MINWIDTH = 24;

        // Properties of desk
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }
        public DesktopMaterial Material { get; set; }
        public int getSurfaceArea()
        {
            return Width * Depth;

        }

    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veener
    }
}
