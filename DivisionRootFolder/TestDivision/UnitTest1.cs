using NUnit.Framework;
using DivisionLib;
namespace Tests
{
    public class Tests
    {
        

        [Test]
        public static void Test_Taking_Numbers()
        {
            double value1 = 36;
            double value2 = 6;
            double expected = 6;
           
            Assert.AreEqual(expected, DivisionLib.Division.DivisionMethod(value1, value2));

        }
        [Test]
        public static void Test_DivisionOf55_5_Equals_11()
        {
            double value1 = 55;
            double value2 = 5;
            double expected = 11;
           
            Assert.AreEqual(expected, DivisionLib.Division.DivisionMethod(value1, value2));

        }
        [Test]
        public static void Test_DivisionOf124_12_Equals_10p33()
        {
            double value1 = 124;
            double value2 = 12;
            double expected = 10.333333333333334d;
           
            Assert.AreEqual(expected, DivisionLib.Division.DivisionMethod(value1, value2));

        }
        [Test]
        public static void Test_DivisionOf124_12_Equals_11()
        {
            double value1 = 124;
            double value2 = 12;
            double expected = 11;
           
            Assert.AreEqual(expected, DivisionLib.Division.DivisionMethod(value1, value2));

        }

        
    }
}