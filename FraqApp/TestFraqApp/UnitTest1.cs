using FraqApp;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestFraqApp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestConstructorTwoParams()
        {

            Fraq f = new Fraq(1, 2);

            Assert.AreEqual(1, f.Chis);
            Assert.AreEqual(2, f.Znam);
        }

        [Test]
        public void TestConstructorZeroDiv()
        {
                        
            Assert.Throws<ArgumentException>(()=>new Fraq(1,0));
        }

        [Test]
        public void TestConstructorOneParam()
        {

            Fraq f = new Fraq(2);

            Assert.AreEqual(2, f.Chis);
            Assert.AreEqual(1, f.Znam);
        }
        [Test]
        public void TestConstructorNoParams()
        {

            var f = new Fraq();

            Assert.AreEqual(0, f.Chis);
            Assert.AreEqual(1, f.Znam);
            Assert.IsInstanceOf(typeof(Fraq), f);
        }


        [Test]
        public void TestOperatorPlus()
        {
            //Arrange
            var f1 = new Fraq(1,2);
            var f2 = new Fraq(3,5);

            //Act
            var f = f1 + f2;


            //Assert
            Assert.AreEqual(11, f.Chis);
            Assert.AreEqual(10, f.Znam);
        }



        [TestCase(3, 4, "3/4")]
        [TestCase(2, 1, "2")]
        [TestCase(-10, 20, "-10/20")]
        [TestCase(1,2,"1/2")]
        public void TestToString(int ch, int zn, string res)
        {
            //Arrange
            var f = new Fraq(ch, zn);
            
            //Act
            var str = f.ToString();

            //Assert
            Assert.AreEqual(res, str);
        }





    }
}