using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    public static class Directions
    {
        public static readonly LinkedList<string> direction = new LinkedList<string> ( new[] { "N", "S", "E", "W"} );
    }
}
