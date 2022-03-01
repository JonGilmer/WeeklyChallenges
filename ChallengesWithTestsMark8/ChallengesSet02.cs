using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {

        // *** Check for null values first ***
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() <= 0)
                return 0;
            return Enumerable.Max(numbers) + Enumerable.Min(numbers);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers) => (numbers == null) ? 0 : Enumerable.Sum(numbers);

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
            {
                return 0;
            }

            var evensOnly = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0 || numbers[i] % 2 == 0)
                {
                    evensOnly[i] = numbers[i];
                }
            }
            return Enumerable.Sum(evensOnly);
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0) return false;

            int listSum = Enumerable.Sum(numbers);

            if (listSum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number) => number <= 0 ? 0 : number / 2;

    }
}
