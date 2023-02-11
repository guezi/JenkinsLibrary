namespace JenkinsLibraryTest
{
    using System;
    using JenkinsLibrary;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new Calculator();
        }

        [Test]
        public void CanCallAdd()
        {
            // Arrange
            var x = 2026422924;
            var y = 1186429131;

            // Act
            var result = _testClass.Add(x, y);

            // Assert
             Assert.AreEqual(x + y, result);
        }
    }
}
