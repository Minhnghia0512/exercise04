using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindnum5()
        {
            int [] ar1 = new int[5]{1,3,4,5,6};
            bool result3 = Program.Findnum5(ar1);
            Assert.AreEqual(true, result3);

            int[] ar2 = new int[5] { 1, 3, 4, 7, 6 };
            bool result4 = Program.Findnum5(ar2);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void TestFindnum5or6()
        {
            int[] ar1 = new int[5] { 1, 3, 4, 5, 6 };
            bool result3 = Program.Findnum5or6(ar1);
            Assert.AreEqual(true, result3);

            int[] ar2 = new int[5] { 1, 3, 4, 7, 6 };
            bool result4 = Program.Findnum5or6(ar2);
            Assert.AreEqual(true, result4);

            int[] ar3 = new int[5] { 1, 3, 4, 7, 5 };
            bool result5 = Program.Findnum5or6(ar3);
            Assert.AreEqual(true, result4);

            int[] ar4 = new int[5] { 1, 3, 4, 7, 4 };
            bool result6 = Program.Findnum5or6(ar4);
            Assert.AreEqual(false, result6);
        }
        [TestMethod]
        public void TestFindnum5and6()
        {
            int[] ar1 = new int[5] { 1, 3, 4, 5, 6 };
            bool result3 = Program.Findnum5and6(ar1);
            Assert.AreEqual(true, result3);

            int[] ar2 = new int[5] { 1, 3, 4, 7, 6 };
            bool result4 = Program.Findnum5and6(ar2);
            Assert.AreEqual(false, result4);

            int[] ar3 = new int[5] { 1, 3, 4, 7, 5 };
            bool result5 = Program.Findnum5and6(ar3);
            Assert.AreEqual(false, result4);

            int[] ar4 = new int[5] { 1, 3, 4, 7, 4 };
            bool result6 = Program.Findnum5and6(ar4);
            Assert.AreEqual(false, result6);
        }
    }
}
