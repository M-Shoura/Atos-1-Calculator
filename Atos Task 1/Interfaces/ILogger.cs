using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_Task_1.Interfaces
{
    internal interface ILogger
    {
        public List<string> Logs { get; set; }
        public void OneOperand(decimal a, decimal ans);
        public void TwoOperands(decimal a, decimal b, decimal ans, char op);
    }
}