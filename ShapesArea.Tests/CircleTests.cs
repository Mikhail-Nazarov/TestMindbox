using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesArea.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle1_ZeroLengthRadius()
        {
            var circle = new Circle(0.0);
            var area = circle.Area;
        }

        [TestMethod]
        public void Circle2_NormalRadius()
        {
            var circle = new Circle(4.0);
            var area = circle.Area;
            Assert.AreEqual(area, 4 * 4 * Math.PI);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle3_NegativeRadius()
        {
            var circle = new Circle(-10.0);
            var area = circle.Area;
        }

        [TestMethod]
        public void Circle4_MaxDoubleArea()
        {
            var circle = new Circle(double.MaxValue / 2);
            var area = circle.Area;
            Assert.AreEqual(area, double.PositiveInfinity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle6_InfinityRadius()
        {
            var circle = new Circle(double.PositiveInfinity);
            var area = circle.Area;
        }
    }
}
