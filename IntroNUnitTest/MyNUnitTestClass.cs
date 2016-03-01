using System;
using NUnit.Framework;

namespace IntroNUnitTest
{
    [TestFixture]
    public class MyNUnitTestClass
    {
        [Test]
        public void PositiveTest()
        {
            int x = 20, y = 20;
            Assert.AreEqual(x,y);
        }

        [Test]
        public void NagativeTest()
        {
            if(true)
                Assert.Fail("This test is a failure");
        }

        [Test, ExpectedException(typeof (NotSupportedException))]
        public void ExpectedExceptionTest()
        {
            throw new NotSupportedException();
        }

        [Test, Ignore]
        public void NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}