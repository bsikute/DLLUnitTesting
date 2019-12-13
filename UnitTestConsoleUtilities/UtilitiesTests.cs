using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUtilities.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void WriteLineTest()
        {
            //Arrange
            Utilities utilities = new Utilities();
            string stringInputTest = "Hello World";

            //Act
            string output = utilities.WriteLine(stringInputTest);

            //Assert
            Assert.AreEqual(stringInputTest, output);
        }
    }
}