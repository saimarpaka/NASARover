using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    class Rover
    {
        public RoverNavigator RoverNavigator { get; set; }
        public RoverRotator RoverRotator { get; set; }
        public Coordinates CurrentCoordinates { get; set; }
        public string CurrentDirection { get; set; }
        public Rover(Coordinates coordinates, string direction)
        {
            CurrentCoordinates = coordinates;
            RoverNavigator = new RoverNavigator(this);
            RoverRotator = new RoverRotator(this);
            CurrentDirection = direction;
        }
        public Rover()
        {

        }
        public void Navigate(char[] instructions)
        {
            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'M':
                        RoverNavigator.Navigate();
                        break;
                    case 'L':
                        RoverRotator.Turn("L");
                        break;

                    case 'R':
                        RoverRotator.Turn("R");
                        break;
                };
            }
        }
    }
}
