using System;
using System.Collections.Generic;
using System.Text;

namespace MinimumCoinForChangeKata
{
    public interface IUtilities
    {
        bool CheckIfUserInputIsValid(string numb);
        double ConvertStringToNumber(string numb);

    }
    public class Utilities : IUtilities
    {
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

        public double ConvertStringToNumber(string userInput)
        {
            return Convert.ToDouble(userInput);
        }
    }
}
