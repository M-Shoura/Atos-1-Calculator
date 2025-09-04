using Atos_Task_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atos_Task_1
{
    internal class Logger : ILogger
    {
        public List<string> Logs { get; set; }
        public Logger()
        {
            Logs = new List<string>();   
        }
        public void OneOperand(decimal a, decimal ans)
        {
            Logs.Add($"Sqrt({a}) = {ans}");
        }
        public void TwoOperands(decimal a, decimal b, decimal ans, char op)
        {
            Logs.Add($"{a} {op} {b} = {ans}");
        }
    }
}