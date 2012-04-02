using Gallio.Model;
using MbUnit.Framework;

namespace Fixtures
{
    [TestFixture]
    public class BasicAttributes
    {
        [Test, Author("Ben"), Category("Test Category One")]
        public void Test1()
        {
        }

        /// <summary>
        /// This is a test
        /// </summary>
        [Test, Author("Holly"), Category("Test Category One")]
        public void Test2()
        {
        }

        [Test, Author("Plum"), Category("Test Category Two"), Description("This is another test")]
        public void Test3()
        {
        }

        [Test, Importance(Importance.Severe)]
        public void Test4()
        {
        }

        [Test, Importance(Importance.Critical)]
        public void Test5()
        {
        }

        [Test, TestsOn("System")]
        public void Test6()
        {
        }

        [Test, Annotation(AnnotationType.Info, "Some Info")]
        public void Test7()
        {
        }
    }
}