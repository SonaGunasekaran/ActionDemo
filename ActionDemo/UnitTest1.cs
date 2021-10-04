using NUnit.Framework;

namespace ActionDemo
{
    public class Tests:Base.Baseclass
    {
        [Test]
        public void Test1()
        {
            ActionClass.CheckDargAndDrop();
        }
    }
}