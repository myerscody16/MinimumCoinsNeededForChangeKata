﻿using System;

namespace MinimumCoinForChangeKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
