using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_Task_1.Interfaces
{
    internal interface IOperation
    {
        decimal Perform(params decimal[] operands);
    }
}
