using Tyuiu.MiliukovLO.Sprint3.Task6.V28.Lib;

namespace Tyuiu.MiliukovLO.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(15, ds.GetSumTheDivisors(13, 19));
        }
    }
}