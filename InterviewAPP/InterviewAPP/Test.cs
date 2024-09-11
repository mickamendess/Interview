using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    [TestFixture]
    public class Test
    {
        Logger Logger = new Logger();

        [TestCase("WARNING", "NUnit 1")]
        [TestCase("WARNING", "NUnit 2 - !@#$%123")]
        [TestCase("DEBUG", "NUnit 3")]
        [TestCase("DEBUG", "")]
        public void AddingLog(string Type, string Message) {
            Logger.Log("application.log", Type, Message);
        }

        [Test]
        public void VerifyFile() {
            Assert.That(Path.Exists(AppDomain.CurrentDomain.BaseDirectory + "application.log"));
        }

    }
}
