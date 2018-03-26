using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airlines.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeSpan t;
            TimeSpan.TryParseExact("22:28:00", "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out t);
        }
    }
}
