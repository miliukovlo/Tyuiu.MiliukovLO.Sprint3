using Tyuiu.MiliukovLO.Sprint3.Task4.V14.Lib;

namespace Tyuiu.MiliukovLO.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual(1, dataService.Calculate(-5,5));
        }
    }
}