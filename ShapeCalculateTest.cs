using NUnit.Framework;

namespace GeometryTest
{
    internal class ShapeCalculateTest
    {
        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);

            double actualArea = circle.Square();

            double expectedArea = 78.53981633;

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(5, 8, 10);

            double actualArea = triangle.Square();

            double expectedArea = 19.810035177;

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void RightAngleTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 8);

            bool isRightAngle = triangle.IsRightAngleTriangle();

            Assert.IsTrue(isRightAngle);
        }

        [Test]
        public void PolyhedronAreaTest()
        {
            Polyhedron polyhedron = new Polyhedron(new double[] { 10, 10, 10, 10, 10, 10, 10, 10 });

            double actualArea = polyhedron.Square();

            double expectedArea = 482.842712474619;

            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}