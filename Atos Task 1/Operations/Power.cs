using Atos_Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_Task_1.Operations
{
    internal class Power : IOperation
    {
        private ILogger _logger;

        public Power(ILogger logger)
        {
            _logger = logger;
        }
        public decimal Perform(params decimal[] operands)
        {
            double a = (double)operands[0], b = (double)operands[1];
            decimal ans = (decimal) Math.Pow(a,b);
            _logger.TwoOperands(operands[0], operands[1], ans, '^');
            return ans;
        }
    }
}