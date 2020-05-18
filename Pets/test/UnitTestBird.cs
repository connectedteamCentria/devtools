using NUnit.Framework;


namespace Pets 
{
    public class BirdTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]

        public void BirdTalkToOwnerReturnsCoocoo()
        {
            Bird bird = new Bird();
            Assert.AreEqual(MakeSound(), "Coocoo!");
            //Assert.Pass();
        }

            
    }
}