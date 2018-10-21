﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_IrynaKyman
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }

        //constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        //constrains
        
    }
    //enum
    public enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };
}
