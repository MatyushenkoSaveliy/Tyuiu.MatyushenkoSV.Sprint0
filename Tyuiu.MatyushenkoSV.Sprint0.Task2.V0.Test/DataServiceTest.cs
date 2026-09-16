using Tyuiu.MatyushenkoSV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MatyushenkoSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Савва";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Савва", res);
        }
    }
}
