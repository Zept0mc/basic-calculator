using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] posNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool notGood = false;
            int num1 = 0;
            int num2 = 0;
            bool wasSign = false;
            string goodLine = "";
            char sign = ' ';

            string deleteSpaces(string currentLine)
            {
                string goodLine = "";
                foreach (char c in currentLine)
                {
                    if (c == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        goodLine += c;
                    }
                }
                return goodLine;
            }
            //Tu JEST COŚ NIE TAK----------------------------------------------------------------------------------------------------------------------------------
            bool checkIfNotNumber(char c, char[] posNums, bool wasSign)
            {
                if (!posNums.Contains(c))
                {

                    wasSign = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Tu JEST COŚ NIE TAK----------------------------------------------------------------------------------------------------------------------------------
            void inputDigit(char c, bool wasSign)
            {
                if (!wasSign)
                {
                    num1 *= 10;
                    num1 += c - '0';
                }
                else
                {
                    num2 *= 10;
                    num2 += c - '0';
                }
            }

            void checkWhichSign(char sign, int num1, int num2)
            {
                switch (sign)
                {
                    case '+':
                        {
                            Addition ihurt5e = new Addition(num1, num2);
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                            break;
                        }
                    case '-':
                        {
                            Substraction ihurt5e = new Substraction(num1, num2);
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                            break;
                        }
                    case '*':
                        {
                            Multiplication ihurt5e = new Multiplication(num1, num2);
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                            break;
                        }
                    case '/':
                        {
                            Division ihurt5e = new Division(num1, num2);
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                            break;
                        }
                    case '^':
                        {
                            Poweroination ihurt5e = new Poweroination(num1, num2);
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                            break;
                        }
                }
            }

            Console.WriteLine("Input an operation: \n");

            string currentLine = Console.ReadLine();

            goodLine = deleteSpaces(currentLine);

            foreach (char c in goodLine)
            {
                if (checkIfNotNumber(c, posNums, wasSign))
                {
                    checkIfNotNumber(c, posNums, wasSign);
                }
                else
                {
                    inputDigit(c, wasSign);
                }

                checkWhichSign(sign, num1, num2);
            }
        }
    }
}