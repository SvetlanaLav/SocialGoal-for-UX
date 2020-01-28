using NUnit.Framework;

namespace SocialGoal.Tests.Controllers
{
    public class MyTest
    {
        [Test]
        public void MyTest1()
        {
            var value = 2;
            Assert.True(IsOdd(value));
        }
        bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
    }
}