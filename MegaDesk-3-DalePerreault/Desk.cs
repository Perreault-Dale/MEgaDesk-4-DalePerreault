using System;

namespace MegaDesk_3_DalePerreault
{
    enum Surface
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    class Desk
    {
        // class members
        public int width { get; set; }
        public int depth { get; set; }
        public int drawers { get; set; }
        public Surface surface { get; set; }

        // constructor method
        public Desk(int wide, int deep, int draw, Surface surface)
        {
            width = wide;
            depth = deep;
            drawers = draw;
            this.surface = surface;
        }
    }
}
