using HE.Challenge.Business;
using NUnit.Framework;

namespace QE.Challenge.Test
{
    public class NumberCalculatorTest
    {
        private  NumberCalculator _calculator { get; set; }
        
        [OneTimeSetUpAttribute]
        public void OneTimeSetUp()
        {
            _calculator = new NumberCalculator();
        }

        [Test]
        public void BothArrayNulls_Test()
        {
            var result = _calculator.SumValuesFromArraysReversingSecond(null, null);
            Assert.IsNull(result);
        }

        [Test]
        public void FirstArrayNull_Test()
        {
            var secondArray = new int[] {1, 2, 3 };
            var result = _calculator.SumValuesFromArraysReversingSecond(null, secondArray);
            Assert.AreEqual(secondArray, result);
        }

        [Test]
        public void SecondArrayNull_Test()
        {
            var firstArray = new int[] { 1, 2, 3 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, null);
            Assert.AreEqual(firstArray, result);
        }


        [Test]
        public void FirstArrayEmpty_Test()
        {
            var firstArray = new int[0];
            var secondArray = new int[] { 2 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 2 }, result);
        }

        [Test]
        public void SecondArrayEmpty_Test()
        {
            var firstArray = new int[] { 1 };
            var secondArray = new int[0];
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 1 }, result);
        }

        [Test]
        public void BothArrayEmpty_Test()
        {
            var firstArray = new int[0];
            var secondArray = new int[0];
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[0], result);
        }

        [Test]
        public void FirstArrayEmptySecondArrayNull_Test()
        {
            var firstArray = new int[0];
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, null);
            Assert.AreEqual(new int[0], result);
        }

        [Test]
        public void FirstArrayNullSecondArrayEmpty_Test()
        {
            var secondArray = new int[0];
            var result = _calculator.SumValuesFromArraysReversingSecond(null, secondArray);
            Assert.AreEqual(new int[0], result);
        }

        [Test]
        public void SingleSum_Test()
        {
            var firstArray = new int[] { 1 };
            var secondArray = new int[] { 2 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 3 }, result);
        }

        [Test]
        public void ProvidedExampleSum_Test()
        {
            var firstArray = new int[] {1, 2, 3, 4, 5, 6};
            var secondArray = new int[] {1, 2, 3, 4, 5, 6};
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] {7, 7, 7, 7, 7, 7}, result);
        }
        [Test]
        public void ThreeNumberSum_Test()
        {
            var firstArray = new int[] { 1, 4, 5 };
            var secondArray = new int[] { 2, 4, 11 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 12, 8, 7 }, result);
        }

        [Test]
        public void FirstArrayShorter_Test()
        {
            var firstArray = new int[] { 10, 20 };
            var secondArray = new int[] { 1, 2, 3, 4 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 14, 23, 2, 1 }, result);
        }

        [Test]
        public void FirstArrayShorterWithNegative_Test()
        {
            var firstArray = new int[] { 10, 20 };
            var secondArray = new int[] { 1, -2, 3, 4 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 14, 23, -2, 1 }, result);
        }

        [Test]
        public void SecondArrayShorter_Test()
        {
            var firstArray = new int[] { 1, 2, 3, 4 };
            var secondArray = new int[] { 10, 20 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 21, 12, 3, 4 }, result);
        }

        [Test]
        public void SecondArrayShorterWithNegative_Test()
        {
            var firstArray = new int[] { 1, 2, 3, 4 };
            var secondArray = new int[] { 10, -20 };
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { -19, 12, 3, 4 }, result);
        }

        [Test]
        public void EachArray30ValuesSum_Test()
        {
            var firstArray = new int[] { 
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
            var secondArray = new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
            var result = _calculator.SumValuesFromArraysReversingSecond(firstArray, secondArray);
            Assert.AreEqual(new int[] { 
                31, 31, 31, 31, 31, 31, 31, 31, 31, 31,
                31, 31, 31, 31, 31, 31, 31, 31, 31, 31,
                31, 31, 31, 31, 31, 31, 31, 31, 31, 31
            }, result);
        }
    }
}