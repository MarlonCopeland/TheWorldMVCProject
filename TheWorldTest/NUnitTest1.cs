using System;
using NUnit.Framework;


namespace TheWorldTest
{
    [[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {

    }
    [TestFixture]
    class NUnitTest1
    {
        [Test]
        public void ShouldCheckFrame() {
            Assert.That(1 , Is.EqualTo(1));
        }
    }
}
