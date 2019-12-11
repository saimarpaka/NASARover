using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NASARover
{
    public static class InputValidator
    {
        public static Coordinates? ValidateBoundsInputAndReturnCoordinates(string bounds)
        {

            var boundCoordinates = bounds.Trim().Split(' ');
            if (boundCoordinates.Length != 2)
            {
                Console.WriteLine("Invalid bounds");
            }
            else
            {
                var coordinates = boundCoordinates.Select(int.Parse).ToList();
                return new Coordinates(coordinates[0], coordinates[1]);
            }

            return null;
        }
        public static InitialLocationWithDirection? ValidateRoverCurrentLocation(string initialPosition)
        {
            var position = initialPosition.Trim().Split(' ');
            if (position.Length == 3)
            {
                var isNumericX = int.TryParse(position[0], out int x);
                var isNumericY = int.TryParse(position[1], out int y);
                if (!isNumericX || !isNumericY)
                {
                    Console.WriteLine("Invalid Current location coordinates");
                    return null;
                }
                else
                {
                    if (Directions.direction.Find(position[2]) != null)
                    {
                        return new InitialLocationWithDirection(new Coordinates(x, y), position[2]);
                    }
                }
            }
            Console.WriteLine("Invalid Current location");
            return null;

        }

        public static char[] ValidateInstructions(string instructions)
        {
            var arInstructions = instructions.Trim().ToCharArray();
            foreach (var instruction in arInstructions)
            {
                switch (instruction)
                {
                    case 'L': break;
                    case 'M': break;
                    case 'R': break;
                    default:
                        Console.WriteLine("Invalid Instructions");
                        return null;
                }
            }
            return arInstructions;
        }

    }
}
