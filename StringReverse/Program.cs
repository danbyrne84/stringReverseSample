using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var toReverse = "The cat sat on the mat.";
                Console.WriteLine(ReverseString(toReverse));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static string ReverseString(string inputStr, int maxLength = 2048)
        {
            if(inputStr == null) throw new ArgumentNullException("String must not be null");
            if(inputStr.Length > maxLength) throw new ArgumentException($"String must not be greater than {maxLength} characters in length");

            int i = 0;
            int j = inputStr.Length - 1;

            char[] workingStr = inputStr.ToCharArray();

            while(i < j)
            {
                char leftMostChar = workingStr[i];

                workingStr[i] = workingStr[j];
                workingStr[j] = leftMostChar;

                i++;
                j--;
            }

            return new string(workingStr);
        }
    }
}
