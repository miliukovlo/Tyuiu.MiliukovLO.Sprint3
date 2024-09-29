using Tyuiu.MiliukovLO.Sprint3.Task2.V5.Lib;

namespace Tyuiu.MiliukovLO.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual(1, dataService.GetSumSeries(0.75, 1, 20));
        }
    }
}