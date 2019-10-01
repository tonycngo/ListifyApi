using NUnit.Framework;
using SpFishUtil;

namespace SpFishTest
{
    public class ListtiFyUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var mylist = new ListiFy(100, 200);

            var val = mylist[50];

            Assert.AreEqual(150, val);
        }
    }
}