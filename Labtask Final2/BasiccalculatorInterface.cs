using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_Final2
{
    interface BasiccalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class BasicCalc : BasiccalculatorInterface
    {
        int result;
        public int sum(int number1, int number2)
        {
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            result = number1 / number2;
            return result;
        }
        public void printStates()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}