using MarsRove.Enums;
using MarsRove.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRove.Models.Concrete
{
    public class Rover:IRover
    {
        //Implement Interface
        public IGround RoverGround
        {
            get;
            set;
        }
        public IPosition RoverPosition
        {
            get;
            set;
        }
        public Directions RoverDirection
        {
            get;
            set;
        }
        //Add Constructor
        public int x;
        public int y;
        public int z;
        public string direction;
        public Rover(string location)
        {
            Int32.TryParse(location.Split(' ')[0], out x);
            Int32.TryParse(location.Split(' ')[1], out y);
            direction = location.Split(' ')[2];
        }
        public void Process(string commands)
        {
            
        }
        public void Move(string direct)
        {
            switch (direct)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    x--;
                    break;
                case "W":
                    y--;
                    break;
                default:
                    break;
            }

        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "S";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction ="W";
                    break;
                case "W":
                    direction = "E";
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "W";
                    break;
                case "S":
                    direction ="N";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    break;
            }
        }
    }
}
