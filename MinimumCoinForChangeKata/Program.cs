using System;

namespace MinimumCoinForChangeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of money you need broken up into change.");
            string userInput = Console.ReadLine();

        }

        public bool CheckIfUserInputIsValid(string numb)
        {
            bool result = true;
            try
            {
                double convertNum = Convert.ToDouble(numb);
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
