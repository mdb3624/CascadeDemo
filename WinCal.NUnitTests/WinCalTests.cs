using NUnit.Framework;
//using AutoItX3Lib;

namespace WinCal.NUnitTests
{
    [TestFixture]
    public class WinCalTests
    {

        private static WinCal SUT = new WinCal();

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
        public void WinCalIsOpen()
        {
            int result = SUT.IsApplicationOpen();
            Assert.AreEqual(1, result);
        }
    }
}
