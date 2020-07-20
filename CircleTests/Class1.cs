using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SENG8040A1;
using NUnit.Framework;

namespace CircleTests
{
    [TestFixture]
    public class Class1
    {

        private Circle circle;

        [SetUp]
        public void Circle_23point5_Expected23point5()
        {
            //Arrange
            double initialRadius = 23.5;
            double expected = 23.5;
            
            //Act
            circle = new Circle(initialRadius);
            double actual = circle.Radius;

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [Test]
        public void AddToRadius_Input5point5_Expected29point0()
        {
            //Arrange
            double number = 5.5;
            double expected = 29.0;

            //Act
            double actual = circle.AddToRadius(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddToRadius_Input9_Expected32point5()
        {
            //Arrange
            double number = 9;
            double expected = 32.5;

            //Act
            double actual = circle.AddToRadius(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddToRadius_InputNegative3_ExpectedMessageRadiusCannotBeNegative()
        {
            //Arrange
            double number = -3;
            double expected = 20.5;

            string stringMessageExpected = "Unable to perform this operation, radius cannot be negative";

            //Act
            double actual = circle.AddToRadius(number);
        
            //Assert
            Assert.AreNotEqual(expected, actual, stringMessageExpected);
        }

        [Test]
        public void SubtractFromRadius_Input7point3_Expected16point2()
        {
            //Arrange
            double number = 7.3;
            double expected = 16.2;
            
            //Act
            double actual = circle.SubtractFromRadius(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractFromRadius_Input1_Expected22point5()
        {
            //Arrange
            double number = 1;
            double expected = 22.5;

            //Act
            double actual = circle.SubtractFromRadius(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractFromRadius_Input24_ExpectedMessageRadiusCannotBeNegative0point5()
        {
            //Arrange
            double number = 24;
            double expected = 0.5;

            String stringMessageExpected = "Unable to perform this operation, radius cannot be negative";

            //Act
            double actual = circle.SubtractFromRadius(number);
            
            //Assert
            Assert.AreNotEqual(expected, actual, stringMessageExpected);
        }
        
        [Test]
        public void SubtractFromRadius_Input0_Expected23point5()
        {
            //Arrange
            double number = 0;
            double expected = 23.5;

            //Act
            double actual = circle.SubtractFromRadius(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractFromRadius_InputNegative3_ExpectedMessageRadiusCannotBeNegative()
        {
            //Arrange
            double number = -3;
            double expected = 20.5;

            String stringMessageExpected = "Unable to perform this operation, radius cannot be negative";

            //Act
            double actual = circle.SubtractFromRadius(number);

            //Assert
            Assert.AreNotEqual(expected, actual, stringMessageExpected);
        }

        [Test]
        public void GetCircumference_InputRadius23Point5_Expected147point65()
        {
            //Arrange
            double expected = Math.Round(2 * Math.PI * circle.Radius, 2);
            double expctedCompare = Math.Round(2 * 3.14159265358979 * 23.5, 2);
            double actual = 0; ;

            //Act
            if (expected == expctedCompare)
            {
                actual = circle.GetCircumference();
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCircumference_InputRadius17_Expected106point81()
        {
            //Arrange
            circle = new Circle(17);

            double expected = Math.Round(2 * Math.PI * circle.Radius, 2);
            double expctedCompare = 106.81;
            double actual = 0; ;

            //Act
            if (expected == expctedCompare)
            {
                actual = circle.GetCircumference();
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCircumference_InputRadius3_Expected118point65()
        {
            //Arrange
            circle = new Circle(3);
            double expected = Math.Round(2 * 3.14159265358979 * 3, 2); 

            //Act
            double actual = circle.GetCircumference();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_InputRadius23point5_Expected1734point94()
        {
            //Arrange
            double expected = Math.Round(Math.PI * circle.Radius * circle.Radius, 2);

            //Act
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_InputRadius3_Expected28point27()
        {
            //Arrange
            circle = new Circle(3);
            double expected = 28.27;

            //Act
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_InputRadius16_Expected804point25()
        {
            //Arrange
            circle = new Circle(16);
            double expected = Math.Round(3.14159265358979 * 16 * 16, 2);

            //Act
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
