using Atos_Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Atos_Task_1.Operations
{
    internal class Modulo : IOperation
    {
        private ILogger _logger;

        public Modulo(ILogger logger)
        {
            _logger = logger;
        }
        public decimal Perform(params decimal[] operands)
        {
            decimal ans = operands[0] - ((Math.Floor(operands[0] / operands[1])) * operands[1]);
            _logger.TwoOperands(operands[0], operands[1], ans, '%');
            return ans;
        }
    }
}