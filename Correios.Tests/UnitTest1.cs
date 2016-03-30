using System;
using Correios.CorreiosServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Correios.Tests
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

        }
    }
}
