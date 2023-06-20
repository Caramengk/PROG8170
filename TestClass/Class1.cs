using ConsoleApp2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class PixelTest
    {
        [TestFixture] 
        public class PixelTest1
        {
            [Test] public void InvalidInput_Input0and0and0_OutputInvalidInput()
            {
                //Arrange
                int width = 0;
                int height = 0;
                int diagonal = 0;
                string expected = "At least one of your input is negative or zero. Please enter positive integers.";

                //Act
                string actual = PixelCalc.CalcPixel(width, height, diagonal);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
