using otus_architecture_lab_7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace otus_architecture_lab_7_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibonachiComputeTest()
        {
            Fibonachi fc = new Fibonachi();

            Assert.IsTrue(fc.Compute(1) == 1);
            Assert.IsTrue(fc.Compute(5) == 5);
            Assert.IsTrue(fc.Compute(10) == 55);
        }


        [TestMethod]
        public void FibonachiIteratorUpTest()
        {
            List<int> expectedResult = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            FibonachiIteratorUp iterator = new FibonachiIteratorUp(1, expectedResult.Count);

            int i = 0;
            while (iterator.HasNext())
            {
                Assert.IsTrue(expectedResult[i] == iterator.Next());
                i++;
            }

            Assert.IsTrue(expectedResult.Count == i);
        }


        [TestMethod]
        public void FibonachiIteratorDownTest()
        {
            List<int> expectedResult = new List<int>() { 55, 34, 21, 13, 8, 5, 3, 2, 1, 1 };

            FibonachiIteratorDown iterator = new FibonachiIteratorDown(expectedResult.Count, 1);

            int i = 0;
            while (iterator.HasNext())
            {
                Assert.IsTrue(expectedResult[i] == iterator.Next());
                i++;
            }

            Assert.IsTrue(expectedResult.Count == i);
        }
    }
}
