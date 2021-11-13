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
    }
}
