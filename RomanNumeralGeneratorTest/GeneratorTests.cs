using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RomanNumeralGeneratorTest
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        public void WhenNumberIs_1_GenerateShouldReturn_I ()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(1);

            Assert.AreEqual("I", result);
        }
        
        [TestMethod]
        public void WhenNumberIs_5_GenerateShouldReturn_V()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(5);

            Assert.AreEqual("V", result);
        }
        
        [TestMethod]
        public void WhenNumberIs_10_GenerateShouldReturn_X()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(10);

            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void WhenNumberIs_20_GenerateShouldReturn_XX()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(20);

            Assert.AreEqual("XX", result);
        }

        [TestMethod]
        public void WhenNumberIs_3999_GenerateShouldReturn_MMMCMXCIX()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(3999);

            Assert.AreEqual("MMMCMXCIX", result);
        }

        [TestMethod]
        public void WhenNumberIs_LessThan1_GenerateShouldThrow_IndexOutOfRangeException()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();
            Exception result = null;

            try
            {
                romanNumeralGenerator.Generate(0);
            }
            catch (Exception exception)
            {
                result = exception;
            }
            finally
            {
                Assert.IsInstanceOfType(result, typeof(ArgumentOutOfRangeException));
            }
        }

        [TestMethod]
        public void WhenNumberIs_GreaterThan3999_GenerateShouldThrow_IndexOutOfRangeException()
        {
            IRomanNumeralGenerator romanNumeralGenerator = new RomanNumeralGenerator();
            Exception result = null;

            try
            {
                romanNumeralGenerator.Generate(4000);
            }
            catch (Exception exception)
            {
                result = exception;
            }
            finally
            {
                Assert.IsInstanceOfType(result, typeof(ArgumentOutOfRangeException));
            }
        }
    }
}
