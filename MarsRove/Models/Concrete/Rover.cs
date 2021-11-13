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
        public Rover(IGround roverGround, IPosition roverPosition, Directions roverDirection)
        {
            RoverGround = roverGround;
            RoverPosition = roverPosition;
            RoverDirection = roverDirection;
        }
        public void Process(string commands)
        {
            foreach (var cmd in commands)
            {
                switch (cmd)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", cmd));
                }
            }
        }
    }
}
