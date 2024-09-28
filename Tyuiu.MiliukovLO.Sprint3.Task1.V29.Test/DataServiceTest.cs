using Tyuiu.MiliukovLO.Sprint3.Task1.V29.Lib;


namespace Tyuiu.MiliukovLO.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(13051.34, dataService.GetMultiplySeries(0.25, 1, 11));
        }
    }
}