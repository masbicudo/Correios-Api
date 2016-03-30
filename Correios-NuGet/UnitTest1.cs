using Correios;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Correios_NuGet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new CorreiosApi();
            var task = service.consultaCEPAsync("24710480");
            var result = task.Result;
            var bairro = result.@return.bairro;
        }
    }
}
