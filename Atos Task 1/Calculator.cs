using Atos_Task_1.Interfaces;

namespace Atos_Task_1
{
    internal class Calculator
    {
        private static Calculator instance = new Calculator();
        private Calculator()
        {

        }
        public static Calculator GetCalculator()
        {
            return instance;
        }

        public decimal Apply(IOperation operation, params decimal[] numbers)
        {
            return operation.Perform(numbers);
        }
    }
}