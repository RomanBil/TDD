using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDs;

namespace testTDD
{
    [TestFixture]
    public class test
    {
        private TDD tdd = new TDD();

        [Test]
        public void TestDiscriminator()
        {
            int d = tdd.Discriminator(1, 2, 1);

            Assert.AreEqual(0, d);
        }

        [Test]
        public void TestWork()
        {
            int[] i = tdd.Work(1, 2, 1);

            Assert.AreEqual(-1, i[0]);

            Assert.AreEqual(-1, i[1]);
        }
    }
}
