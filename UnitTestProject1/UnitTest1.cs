using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = StringCalculator.Calculate();
            Assert.AreEqual(res, 0);
            Console.WriteLine();
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            int res = StringCalculator.Calculate("4");
            Assert.AreEqual(res, 4);
            Console.WriteLine();
            

        }

        [TestMethod]
        public void TestMethod3()
        {
            int res = StringCalculator.Calculate("4,5");
            Assert.AreEqual(res, 9);
            Console.WriteLine();

        }

        [TestMethod]
        public void TestMethod4()
        {
            int res = StringCalculator.Calculate("4\n5");
            Assert.AreEqual(res, 9);
            Console.WriteLine();

        }

        //[TestMethod]
        //public void TestMethod5()
        //{
        //    int res = StringCalculator.Calculate("1,3\n7,8");
        //    Assert.AreEqual(res, 19);
        //    Console.WriteLine();
           

        //}

        //[TestMethod]
        //public void TestMethod6()
        //{
        //    int res = StringCalculator.Calculate("-6");

        //    Action throwingAction = () =>
        //    {
        //        throw new IndexOutOfRangeException();
        //    };
        //    Assert.ThrowsException<IndexOutOfRangeException>(throwingAction);
        //    Console.WriteLine();


        //}



    }
}
