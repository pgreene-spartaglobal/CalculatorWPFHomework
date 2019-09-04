using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorMSTest
{
    [TestClass]
    public class UnitTest1
    {
        
        CalculatorUnderTest calc;

        // 1. Setup
        [TestInitialize]
        public void Initialize()
        {
            calc = new CalculatorUnderTest();
        }

        // 2. Running the test
        [TestMethod]
        public void TestAddMethod()
        {          
            double valueInput1 = 8;
            double valueInput2 = 5;
            double expectedOutput = 13;
   
            double result = calc.Add(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);  
        }

        [TestMethod]
        public void TestSubtactMethod()
        {
            double valueInput1 = 15;
            double valueInput2 = 3;
            double expectedOutput = 12;

            double result = calc.Subtract(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);          
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            double valueInput1 = 6;
            double valueInput2 = 2;
            double expectedOutput = 12;

            double result = calc.Multiply(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);         
        }

        [TestMethod]
        public void TestDivideMethod()
        {
            double valueInput1 = 10;
            double valueInput2 = 2;
            double expectedOutput = 5;

            double result = calc.Divide(valueInput1, valueInput2);
            Assert.AreEqual(expectedOutput, result);          
        }

        // 3. Cleanup
        [TestCleanup]
        public void CleanupMethod()
        {
            calc = null;
        }
    }
}
