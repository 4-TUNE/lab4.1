using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_lab4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int R = 100;
            int result = lab4_1.Program.StudentRating(R);
            Assert.AreEqual(3, result);
        }
    }
}

