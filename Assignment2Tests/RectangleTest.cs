using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2Rectangle;
using NUnit.Framework.Legacy;
using NUnit.Framework;
namespace Assignment2Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void TestGetLength_Input5_Output5()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(5,1);
            int expectedLength = 5;
            
            //Act
            int actualLength = rectangle.GetLength();

            //Assert
            ClassicAssert.AreEqual(expectedLength, actualLength);
        }

        [TestCase(6,6,6)]
        public void TestGetLength_Input6_Output6(int length, int width, int expectedLength)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length, width);

            //Act
            int actualLength = rectangle.GetLength();

            //Assert
            ClassicAssert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void TestGetLength_InputNegativeNum_ThrowsArgumentException()
        {
            // Arrange
            int length = -5;
            int width = 5;

            Rectangle rectangle = new Rectangle(length, width);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => rectangle.GetLength());
        }

        [Test]
        public void TestSetLength_Input2_Output2()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expectedLength = 2;

            //Act
            int actualLength = rectangle.SetLength(2);

            //Assert
            ClassicAssert.AreEqual(expectedLength, actualLength);
        }

        [TestCase(30, ExpectedResult = 30)]
        public int TestSetLength_Input30_Output30(int length)
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int actualLength = rectangle.SetLength(30);

            //Assert
            return actualLength;
           
        }

        [Test]
        public void TestSetLength_InputNegativeNum_ThrowsArgumentException()
        {
            // Arrange
            int length = -3;

            Rectangle rectangle = new Rectangle();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => rectangle.SetLength(length));
        }

        [Test]
        public void TestGetWidth_Input3_Output3()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(1, 3);
            int expectedWidth = 3;

            //Act
            int actualWidth = rectangle.GetWidth();

            //Assert
            ClassicAssert.AreEqual(expectedWidth, actualWidth);
        }

        [TestCase(6, 6, ExpectedResult =6)]
        public int TestGetWidth_Input6_Output6(int length, int width)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length, width);

            //Act
            int actualLength = rectangle.GetWidth();

            //Assert
            return actualLength;
        }

        [Test]
        public void TestGetWidth_InputNegativeNum_ThrowsArgumentException()
        {
            // Arrange
            int length = 5;
            int width = -10;

            Rectangle rectangle = new Rectangle(length, width);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => rectangle.GetWidth());
        }

        [Test]
        public void TestSetWidth_Input5_Output5()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            int expectedWidth = 5;

            //Act
            int actuaWidth = rectangle.SetWidth(5);

            //Assert
            ClassicAssert.AreEqual(expectedWidth, actuaWidth);
        }

        [TestCase(10, ExpectedResult = 10)]
        public int TestSetWidth_Input10_Output10(int width)
        {
            // Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int actualLength = rectangle.SetWidth(10);

            //Assert
            return actualLength;

        }

        [Test]
        public void TestSetWidth_InputNegativeNum_ThrowsArgumentException()
        {
            // Arrange
            int width = -110;

            Rectangle rectangle = new Rectangle();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => rectangle.SetWidth(width));
        }

        [Test]
        public void TestGetPerimeter_Input3and5_Output16()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(3,5);
            int expectedPerimeter = 16;

            //Act
            int actualPerimeter = rectangle.GetPerimeter();

            //Assert
            ClassicAssert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestCase(2,5, ExpectedResult = 14)]
        public int TestGetPerimeter_Input2and5_Output14(int length, int width)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length,width);

            //Act
            int actualPerimeter = rectangle.GetPerimeter();

            //Assert
            return actualPerimeter;

        }

        [TestCase(6, 6, 24)]
        public void TestGetPerimeter_Input6and6_Output24(int length, int width, int expectedPerim)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length, width);

            //Act
            int actualPerimeter = rectangle.GetPerimeter();

            ClassicAssert.AreEqual(expectedPerim, actualPerimeter);
        }


        [Test]
        public void TestGetArea_Input4and5_Output20()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(4, 5);
            int expectedArea = 20;

            //Act
            int actualArea = rectangle.GetArea();

            //Assert
            ClassicAssert.AreEqual(expectedArea, actualArea);
        }

        [TestCase(2, 5, ExpectedResult = 10)]
        public int TestGetArea_Input2and5_Output10(int length, int width)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length, width);

            //Act
            int actualArea = rectangle.GetArea();

            //Assert
            return actualArea;

        }

        [TestCase(10, 10, 100)]
        public void TestGetArea_Input6_Output6(int length, int width, int expectedArea)
        {
            // Arrange
            Rectangle rectangle = new Rectangle(length, width);

            //Act
            int actualArea = rectangle.GetArea();

            //Assert
            ClassicAssert.AreEqual(expectedArea, actualArea);
        }

    }
}
