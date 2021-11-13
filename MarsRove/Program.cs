using MarsRove.Enums;
using MarsRove.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mars Rover Application");
            Console.Write("Please Ground X Values: ");
            int grX = int.Parse(Console.ReadLine());
            Console.Write("Please Ground Y Values: ");
            int grY = int.Parse(Console.ReadLine());
            Ground ground = new Ground(new Position(grX, grY));
            Console.Write("Please Rover Position X Values: ");
            int roverX = int.Parse(Console.ReadLine());
            Console.Write("Please Rover Y Position Values: ");
            int roverY = int.Parse(Console.ReadLine());
            Console.Write("Please Rover Direction Integer Values: ");
            Console.WriteLine("N:1 E:2 S:3 W:4");
            int roverDrInt = int.Parse(Console.ReadLine());
            Directions roverDr = (Directions)roverDrInt;
            Rover rover = new Rover(ground, new Position(roverX, roverY), roverDr);
            Console.WriteLine("L:Left R:Right M:Move");
            Console.WriteLine("Please Rover Commands Values: ");
            string commands = Console.ReadLine();
            rover.Process(commands);
            Console.WriteLine("Result : " + rover.ToString());
            Console.ReadLine();
        }
    }
}
