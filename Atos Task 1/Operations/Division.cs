using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atos_Task_1.Interfaces;

namespace Atos_Task_1.Operations
{
    internal class Division : IOperation
    {
        private ILogger _logger;

        public Division(ILogger logger)
        {
            _logger = logger;
        }
        public decimal Perform(params decimal[] operands)
        {
            if (operands[1] == 0)
                throw new DivideByZeroException();

            decimal ans = operands[0] / operands[1];
            _logger.TwoOperands(operands[0], operands[1], ans, '/');
            return ans;
        }
    }
}