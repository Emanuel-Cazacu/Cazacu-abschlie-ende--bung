using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cazacu_abschlieﬂende_‹bung;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IstAufgeladenHandy()
        {
            Handy h = new Handy();

            h.Vollgeladen();
            Assert.IsTrue(h.Vollgeladen());

        }

        [TestMethod]
        public void IstAufgeladenLaptop()
        {
            Laptop l = new Laptop();
            l.Vollgeladen();
            Assert.IsTrue(l.Vollgeladen());



        }

        [TestMethod]
        public void LaptopAreEqual()
        {
            Ger‰t l = new Laptop();
            Assert.AreEqual(true, l.Vollgeladen());

        }

        [TestMethod]
        public void HandyAreEqual()
        {
           Ger‰t h = new Handy();
            Assert.AreEqual(true, h.Vollgeladen());

        }

        [TestMethod]
        public void HandyInstanceof()
        {
            Ger‰t h = new Handy();
            Assert.IsInstanceOfType(h, typeof(Handy));

        }

        [TestMethod]
        public void HandyInstancenotof()
        {
            Ger‰t l = new Laptop();
            Assert.IsNotInstanceOfType(l, typeof(Handy));

        }


    }
}
