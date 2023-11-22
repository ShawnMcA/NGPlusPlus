using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.Interfaces
{
    public interface IStat
    {
        int Current { get; set; }
        int Max { get; set; }
    }
}
