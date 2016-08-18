using System;
using DesignPatterns;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSingleton
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreTheSameInstanceTest()
        {
            // Arrange
            Singleton s1;
            Singleton s2;

            // Act
            s1 = Singleton.Instance;
            s2 = Singleton.Instance;

            // Assert
            Assert.AreSame(s1, s2);
        }
    }
}
