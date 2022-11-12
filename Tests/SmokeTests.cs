using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsPipeline
{
    [TestFixture]
    public class SmokeTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void SumOfArrayTest()
        {
            var testDataNumbers = new int[] { 1, 2, 3 };
            var expectedData = 6;
            var actualData = ExecuteManager.GetSummaryOfArray(testDataNumbers);

            Assert.That(actualData, Is.EqualTo(expectedData));
        }

        [Test]
        public void OddIndexNumbersOfArrayTest()
        {
            var testDataNumbers = new int[] { 1, 2, 3, 4, 5 };
            var expectedData = new int[] { 2, 4};
            var actualData = ExecuteManager.GetArrayOfOddIndexNumbers(testDataNumbers);

            Assert.That(actualData, Is.EqualTo(expectedData));
        }

        [Test]
        public void EvenIndexNumbersOfArrayTest()
        {
            var testDataNumbers = new int[] { 1, 3, 3, 4, 3 };
            var expectedData = new int[] { 3, 3 };
            var actualData = ExecuteManager.GetArrayOfEvenIndexNumbers(testDataNumbers);

            Assert.That(actualData, Is.EqualTo(expectedData));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
