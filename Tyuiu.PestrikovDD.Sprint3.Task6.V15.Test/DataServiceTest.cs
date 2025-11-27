using Tyuiu.PestrikovDD.Sprint3.Task6.V15.Lib;
namespace Tyuiu.PestrikovDD.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 168;
            Assert.AreEqual(varForTest, ds.GetSumTheDivisors(6, 15));
        }
    }
}