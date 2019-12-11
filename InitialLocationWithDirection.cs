using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    public struct InitialLocationWithDirection
    {
        public Coordinates Coords { get; set; }
        public string Direction { get; set; }
        public InitialLocationWithDirection(Coordinates coordinates, string direction)
        {
            Coords = coordinates;
            Direction = direction;
        }
    }
}
