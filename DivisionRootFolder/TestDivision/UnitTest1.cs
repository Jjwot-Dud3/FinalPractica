using NUnit.Framework;
using DivisionLib;
namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void Test_Taking_Numbers()
        {
            double value1 = 36;
            double value2 = 6;
            double expected = 6;
            Division division = new Division();
            Assert.AreEqual(expected, division.DivisionMethod(value1, value2));

        }
    }
}