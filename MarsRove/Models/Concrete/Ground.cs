﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRove.Models.Concrete
{
    public class Ground
    {
        public Position GroundPosition { get; set; }
        //Add Constructor 
        public Ground(Position position)
        {
            GroundPosition = position;
        }
    }
}
