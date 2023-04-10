namespace AreaCalculationTests;

[TestClass]
public class ListAreaTests
{
    [TestMethod]
    public void TestListArea()
    {
        var figures = new List<IAreaCalculatable>
        {
            new Circle(3), new Triangle(3, 4, 5), new Triangle(3, 3, 5)
        };

        var actualAreas = new List<double> { 28.27433, 6, 4.14578 };

        var expectedAreas = figures.Select(figure => Math.Round(figure.Area(), 5)).ToList();

        CollectionAssert.AreEqual(expectedAreas, actualAreas, "Wrong area");
    }
}