using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    class RoverNavigator
    {
        public Coordinates CurrentCoordinates
        {
            get
            {
                return MainRoverDevice.CurrentCoordinates;
            }
            set
            {
                MainRoverDevice.CurrentCoordinates = value;
            }
        }
        public string CurrentDirection
        {
            get
            {
                return MainRoverDevice.CurrentDirection;
            }
        }
        private Rover MainRoverDevice { get; set; }      

        public RoverNavigator(Rover rover)
        {
            MainRoverDevice = rover;
        }

        public void Navigate()
        {
            switch (CurrentDirection)
            {
                case "N":
                    MoveNorth();
                    break;
                case "S":
                    MoveSouth();
                    break;
                case "E":
                    MoveEast();
                    break;
                case "W":
                    MoveWest();
                    break;

            }
        }
        public void BoundaryViolation()
        {
            Console.WriteLine("Boundary Violation!");
        }
        public void MoveNorth()
        {
            if ((CurrentCoordinates.Y != Program.GlobalBounds.Y) || (CurrentCoordinates.Y < Program.GlobalBounds.Y))
                CurrentCoordinates.Y += 1;
            else
                BoundaryViolation();
        }
        public void MoveSouth()
        {
            if (CurrentCoordinates.Y > 0)
                CurrentCoordinates.Y -= 1;
            else
                BoundaryViolation();
        }

        public void MoveEast()
        {
            if ((CurrentCoordinates.X != Program.GlobalBounds.X) || (CurrentCoordinates.X < Program.GlobalBounds.X))
                CurrentCoordinates.X += 1;
            else
                BoundaryViolation();
        }

        public void MoveWest()
        {
            if (CurrentCoordinates.X > 0)
                CurrentCoordinates.X -= 1;
            else
                BoundaryViolation();
        }
    }
}
