using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class DivEvalutor : IEvaluate
    {
        public double evaluate(double number1, double number2)
        {
            return number1 / number2;
        } 
    }
}
