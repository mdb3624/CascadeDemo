using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WinCal.NUnitTests
{
    class CalculatorTests : BaseAutoIT
    {
        private static Calculator SUT = new Calculator();

        [OneTimeSetUp]
        public void Initialize()
        {
            SUT.Open();
        }

        [OneTimeTearDown]
        public void Shutdown()
        {
            SUT.Close();
        }

        [Test]
        public void Add2to10()
        {
            int result = SUT.Add(2, 10);
            Assert.AreEqual(12,result);
        }
        [Test]
        public void AboutBoxOpen()
        {
            SUT.ShowAboutBox();
        }
    }
}
