using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        // DONE
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;

            //if(num1 == num2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        // DONE
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        // DONE
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        // DONE
        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        // DONE
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }


        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return $"Hello!";
            }
        }


        public string GetHey()
        {
            return "HEY!";
        }
    }
}
