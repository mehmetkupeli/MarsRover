using MarsRove.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRove.Models.Abstract
{
    public interface IGround
    {
        Position GroundPosition { get; }
    }
}
