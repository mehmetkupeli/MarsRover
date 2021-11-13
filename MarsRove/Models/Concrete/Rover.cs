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

        private void TurnLeft()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverDirection = Directions.S;
                    break;
                case Directions.E:
                    RoverDirection = Directions.N;
                    break;
                case Directions.S:
                    RoverDirection = Directions.W;
                    break;
                case Directions.W:
                    RoverDirection = Directions.E;
                    break;
                default:
                    break;
            }
        }

        private void TurnRight()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverDirection = Directions.E;
                    break;
                case Directions.E:
                    RoverDirection = Directions.W;
                    break;
                case Directions.S:
                    RoverDirection = Directions.N;
                    break;
                case Directions.W:
                    RoverDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Move()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverPosition.PosY++;
                    break;
                case Directions.E:
                    RoverPosition.PosX++;
                    break;
                case Directions.S:
                    RoverPosition.PosX--;
                    break;
                case Directions.W:
                    RoverPosition.PosY--;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPosition.PosX, RoverPosition.PosY, RoverDirection);
        }
    }
}
