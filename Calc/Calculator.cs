using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculator
    {
        double number1;
        double number2;
        Dictionary<string, IEvaluate> mapOfOperations;

        public Calculator(String input1, String input2)
        {
            this.number1 = double.Parse(input1);
            this.number2 = double.Parse(input2);
            RegisterEvaluators();
        }

        private void RegisterEvaluators()
        {
            mapOfOperations = new Dictionary<string, IEvaluate>();
            mapOfOperations.Add("+", new SumEvaluator());
            mapOfOperations.Add("-",new SubEvaluator());
            mapOfOperations.Add("*", new MulEvaluator());
            mapOfOperations.Add("/", new DivEvalutor());
        }

        public double Calculate(string operation)
        {
            if (!String.IsNullOrEmpty(operation))
            {
                IEvaluate evaluator = mapOfOperations[operation];
                return evaluator.evaluate(this.number1, this.number2);
            }
            else
                return 0.0d;
        }
    }
}
