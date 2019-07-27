using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Abstractions;
using Shapes.Shapes;

namespace Shapes.Tests
{
    [TestClass]
    public class Shapes
    {

        [TestMethod]
        public void CalculateCircleArea()
        {
            //Arrange

            IShape circule = new Circle(2);

            //Act

            var area = circule.CalculateArea();

            //Assert

            Assert.AreEqual(12.57, Math.Round(area, 2));
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            //Arrange

            IShape triangle = new Triangle(3, 4, 5);

            //Act

            var area = triangle.CalculateArea();

            //Assert

            Assert.AreEqual(6, area);            
        }

        [TestMethod]
        public void Triangle_CheckIsRight_True()
        {
            //Arrange

            ITriangle triangle = new Triangle(3, 4, 5);

            //Act

            var result = triangle.IsRightTriangle;

            //Assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Triangle_CheckIsRight_False()
        {
            //Arrange

            ITriangle triangle = new Triangle(2, 3, 3);

            //Act

            var result = triangle.IsRightTriangle;

            //Assert

            Assert.AreEqual(false, result);
        }        
    }
}
