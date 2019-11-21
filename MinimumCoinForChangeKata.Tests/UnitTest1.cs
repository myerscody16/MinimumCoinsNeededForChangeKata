using NUnit.Framework;
using MinimumCoinForChangeKata;

namespace Tests
{
    public class Tests
    {
        private Program program;
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("1.01",true)]
        [TestCase("Hello",false)]
        [TestCase(".078",true)]
        [TestCase("no",false)]
        public void Is_User_input_a_number(string numb, bool result)
        {
            Program program = new Program();
            bool output = program.CheckIfUserInputIsValid(numb);
            Assert.AreEqual(result, output);
        }
    }
}