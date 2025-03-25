using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Substraction : Operation
    {
        public int num1;
        public int num2;

        public Substraction(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Evaluate()
        {
            return num1 - num2;
        }

    }
}
