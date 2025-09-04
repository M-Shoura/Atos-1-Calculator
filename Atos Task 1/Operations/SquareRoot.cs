using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atos_Task_1.Interfaces;

namespace Atos_Task_1.Operations
{
    internal class SquareRoot : IOperation
    {
        private ILogger _logger;

        public SquareRoot(ILogger logger)
        {
            _logger = logger;
        }
        public decimal Perform(params decimal[] operands)
        {
            double x = (double)operands[0];
            decimal ans = (decimal)Math.Sqrt(x);
            _logger.OneOperand(operands[0], ans);
            return ans;
        }
    }
}