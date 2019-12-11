using System;
using System.Collections.Generic;
using System.Text;

namespace NASARover
{
    class RoverRotator
    {
        private readonly Rover mainRoverDevice;
        private string CurrentDirection
        {
            get { return mainRoverDevice.CurrentDirection; }
            set { mainRoverDevice.CurrentDirection = value; }
        }
        public RoverRotator(Rover rover)
        {
            mainRoverDevice = rover;
        }

        public void Turn(string nextDirection)
        {
            LinkedListNode<string> node = Directions.direction.Find(CurrentDirection);
            if (nextDirection.ToUpper() == "R")
            {
                CurrentDirection = node.NextNode().Value;
            }
            else if (nextDirection.ToUpper() == "L")
            {

                CurrentDirection = node.PreviousNode().Value;
            }          
        }
    }
}
