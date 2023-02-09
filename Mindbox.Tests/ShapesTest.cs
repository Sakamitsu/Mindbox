using ShapesLibrary;
using Xunit;

namespace Mindbox.Tests.ShapesLibrary
{
    public class ShapesTest
    {
        [Fact]
        public void CircleGetArea()
        {
            Assert.Equal(Math.PI*9, new Circle(3).GetArea());
        }

        [Fact]
        public void Circle()
        {
            Assert.Throws<Exception>(() => new Circle(-2));
            Assert.Throws<Exception>(() => new Circle(0));
        }

        [Fact]
        public void TriangleGetArea()
        {
            Assert.Equal(84, new Triangle(new double[] { 14, 13, 15 }).GetArea());
        }
        
        [Fact]
        public void IsRightTriangle()
        {
            Assert.True(new Triangle(new double[] { 3, 4, 5 }).IsRightTriangle());
            Assert.False(new Triangle(new double[] { 1, 2, 3 }).IsRightTriangle());
        }

        [Fact]
        public void Triangle()
        {
            double[]? array = null;
            Assert.Throws<Exception>(() => new Triangle(new double[] { 1, 2, }));
            Assert.Throws<Exception>(() => new Triangle(new double[] { 1, -3, 6}));
            Assert.Throws<Exception>(() => new Triangle(array!));
        }

    }
}