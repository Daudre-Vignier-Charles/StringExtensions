using StringExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensionsTest
{
    [TestClass]
    public class StringExtensionsTest
    {
        public string testString1 = "Hèllô-Wörld ! Àre yoù hérê ?";
        public string testString2 = "c _daudre?-vignier !";

        [TestMethod]
        public void LimitLengthTest() =>
            Assert.AreEqual("Hèllô-Wö", testString1.LimitLength(8));

        [TestMethod]
        public void RemoveDiacriticalTest() =>
            Assert.AreEqual("Hello-World ! Are you here ?", testString1.RemoveDiacritical());

        [TestMethod]
        public void RemoveNonAlphaNumTest() =>
            Assert.AreEqual("cdaudrevignier", testString2.RemoveNonAlphaNum());

        [TestMethod]
        public void RemoveNonAlphaNumTest_KeepBlank() =>
            Assert.AreEqual("c daudrevignier", testString2.RemoveNonAlphaNum(keepBlank: true));
    }
}
