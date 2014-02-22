using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHandCalculator;

namespace PokerHandCalculatorTests
{
    [TestClass]
    public class FaceTests
    {
        

        [TestMethod]
        public void Test_Ace_Equals_Ace()
        {
            var ace = new Face(Card.Face.Ace);
            var a = new Face(Card.Face.Ace);
            Assert.IsTrue(ace.Equals(a));
        }

        [TestMethod]
        public void Test_Ace_Does_Not_Equal_Jack()
        {
            var ace = new Face(Card.Face.Ace);
            var jack = new Face(Card.Face.Jack);
            Assert.IsFalse(ace.Equals(jack));
        }
    }
}
