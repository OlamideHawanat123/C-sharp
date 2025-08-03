using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BackToSenderLogistics.Tests;

[TestClass]
public class BackToSenderLogisticsTest
{

    [TestMethod]
    public void testThatLogisticReturnsTheRightWage()
    {
        var newObject = new BackToSenderLogistics();
        
        var expected = 45_000;
        Assert.AreEqual(expected, newObject.CalculateWageOfTheDay(80));
        
    }
}