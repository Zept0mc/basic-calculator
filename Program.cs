using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static string deleteSpaces(string currentLine)
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
        static bool checkIfNotNumber(char c, char[] posNums, ref bool wasSign, int num1)
        {
            if (!posNums.Contains(c) && Convert.ToBoolean(num1))
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
        static void inputDigit(char c, bool wasSign, ref int num1, ref int num2)
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

        static void checkWhichSign(char sign, int num1, int num2)
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
                        
                        if(num2 == 0)
                        {
                            string result = "Don't divide by 0";
                            Console.WriteLine(result);
                        }
                        else
                        {
                            int result = ihurt5e.Evaluate();
                            Console.WriteLine(result);
                        }
                        
                        
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
        static void Main(string[] args)
        {
            char[] posNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool notGood = false;
            int num1 = 0;
            int num2 = 0;
            bool wasSign = false;
            string goodLine = "";
            char sign = ' ';

            Console.WriteLine("Input an operation (don't use negative first number): \n");

            string currentLine = Console.ReadLine();

            goodLine = deleteSpaces(currentLine);

            foreach (char c in goodLine)
            {
                if (!checkIfNotNumber(c, posNums, ref wasSign, num1))
                {
                    inputDigit(c, wasSign, ref num1, ref num2);
                }
                else
                {
                    sign = c;
                }          
            }
            checkWhichSign(sign, num1, num2);
        }
    }
}