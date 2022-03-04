using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        // DONE
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false) ? true : false;
        }

        // DONE
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var oddsOnlySum = numbers.Where(num => num % 2 != 0).Sum();
            return oddsOnlySum % 2 != 0 ? true : false;
        }


        // DONE
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upperCheck = password.Any(char.IsUpper);
            bool lowerCheck = password.Any(char.IsLower);
            bool numberCheck = password.Any(char.IsDigit);

            if (upperCheck == true && lowerCheck == true && numberCheck == true)
            {
                return true;
            }
            else return false;
        }

        // DONE
        public char GetFirstLetterOfString(string val)
        {
            var firstLetter = val[0];
            return firstLetter;
        }

        // DONE
        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        // DONE
        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            decimal result = dividend / divisor ;
            return result;
        }

        // DONE
        public int LastMinusFirst(int[] nums)
        {
            var firstItem = nums[0];
            var lastItem = nums[nums.Length - 1];
            var result = lastItem - firstItem;
            return result;
        }

        // DONE
        public int[] GetOddsBelow100()
        {
            IEnumerable<int> arr1 = Enumerable.Range(1, 100).Where(x => x % 2 != 0);
            return arr1.ToArray();
        }

        // DONE
        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
