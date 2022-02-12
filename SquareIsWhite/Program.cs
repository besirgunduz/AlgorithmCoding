using System;

namespace SquareIsWhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determine Color of a Chessboard Square
            //Return true if the square is white, and false if the square is black. 
            //The coordinate will always represent a valid chessboard square. The coordinate will always have the letter first, and the number second.

            //Input: coordinates = "a1"
            //Output: false

            Console.WriteLine(SquareIsWhite("h3"));
        }
        private static bool SquareIsWhite(string coordinates)
        {
            var harf = coordinates[0] - 'a';
            var rakam = coordinates[1] - '0';

            return (harf + rakam) % 2 == 0;
        }
    }
}
