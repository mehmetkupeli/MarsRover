using MarsRove.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRove.Models.Abstract
{
    public interface IRover
    {
        IGround RoverGround { get; set; }
        IPosition RoverPosition { get; set; }
        Directions RoverDirection { get; set; }
        void Process(string commands);
        string ToString();
    }
}
