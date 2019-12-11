using System;
using System.Collections.Generic;

namespace NASARover
{
    class Program
    {
        public static Coordinates? GlobalBounds { get; set; }

        static void Main(string[] args)
        {
            string boundsInput;
            List<Rover> rovers = new List<Rover>();

            Console.WriteLine("Please enter the Bounds");

            boundsInput = Console.ReadLine();         
           
            GlobalBounds = InputValidator.ValidateBoundsInputAndReturnCoordinates(boundsInput);

            if (GlobalBounds != null)
            {

                Console.WriteLine("Enter the # of Rovers");

                var numOfRovers = int.Parse(Console.ReadLine());

                for (int i = 0; i < numOfRovers; i++)
                {

                    Console.WriteLine("Enter the Current Postion for Rover " + i);

                    var initialPosition = InputValidator.ValidateRoverCurrentLocation(Console.ReadLine());

                    if (initialPosition != null)
                    {
                        var rover = new Rover(initialPosition.Value.Coords,
                                                     initialPosition.Value.Direction);
                        rovers.Add(rover);

                        Console.WriteLine("\n");
                        Console.WriteLine("Enter the Instructions for Rover " + i);

                        var instructions = InputValidator.ValidateInstructions(Console.ReadLine());

                        if (instructions != null && instructions.Length > 0)
                            rovers[i].Navigate(instructions);

                    }

                }
                Console.WriteLine("\n");
                for (int i = 0; i < rovers.Count; i++)
                {
                    Console.WriteLine(string.Format("Rover {0} Coordinates {1} {2} {3}", i, rovers[i].CurrentCoordinates.X, rovers[i].CurrentCoordinates.Y, rovers[i].CurrentDirection));
                }
            }        

        }
    }
}
