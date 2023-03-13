using Figures;

namespace FiguresTest
{
    /// <summary>
    /// Проверка метода получения площади
    /// </summary>
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var figures = new Dictionary<Figure, double>
            {
                { new Circle(1),  Math.PI},
                { new Triangle(3, 4, 5), 6},
                { new Triangle(5, 3, 4), 6},
                { new Triangle(4, 5, 3), 6},
            };
            foreach(var f in figures)
            {
                Assert.AreEqual(f.Value, f.Key.GetArea());
            }
        }
        /// <summary>
        /// Проверка метода является ли треугольник прямоугольным
        /// </summary>
        [TestMethod]
        public void RightTriangleTest()
        {
            var triangles = new Dictionary<Triangle, bool>
            {
                { new Triangle(3, 4, 5), true},
                { new Triangle(5, 3, 4), true},
                { new Triangle(4, 5, 3), true},
                {new Triangle(3, 4, 6),  false}
            };
            foreach(var t in triangles)
            {
                Assert.AreEqual(t.Value, t.Key.IsRight());
            }

        }
    }
}