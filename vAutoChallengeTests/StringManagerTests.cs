using Microsoft.VisualStudio.TestTools.UnitTesting;
using vAutoChallenge.Managers;

namespace vAutoChallengeTests
{
    [TestClass]
    public class StringManagerTests
    {
        private StringManager _stringManager;

        private string _basicString;
        private string _numberString;
        private string _nonAlphanumericString;
        private string _mixedString;
        private string _stringWithNoSpaces;
        private string _longString;

        [TestInitialize]
        public void StringManager_Initialize()
        {
            _stringManager = new StringManager();

            _basicString = "Automotive Parts";
            _numberString = "Automotive5Parts";
            _nonAlphanumericString = "@#()!_+#-02-21";
            _mixedString = "Automotive_Parts2";
            _stringWithNoSpaces = "AutomotiveParts";
            _longString = "I make Automotive Parts for the American working man, because that's who I am and that is who I care about.";
        }

        [TestCleanup]
        public void ProfileManager_Cleanup()
        {
            _stringManager = null;

            _basicString = null;
            _numberString = null;
            _nonAlphanumericString = null;
            _mixedString = null;
            _stringWithNoSpaces = null;
            _longString = null;
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithBasicStringInput()
        {
            var result = _stringManager.StringModifier(_basicString);
            
            Assert.AreEqual("A6e P3s", result);
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithStringThatHasNumbersForSpaces()
        {
            var result = _stringManager.StringModifier(_numberString);

            Assert.AreEqual("A6e 5 P3s", result);
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithNonAlphaNumericString()
        {
            var result = _stringManager.StringModifier(_nonAlphanumericString);

            Assert.AreEqual("@ # ( ) ! _ + # - 0 2 - 2 1", result);
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithMixedString()
        {
            var result = _stringManager.StringModifier(_mixedString);

            Assert.AreEqual("A6e _ P3s 2", result);
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithNoSpacesInString()
        {
            var result = _stringManager.StringModifier(_stringWithNoSpaces);

            Assert.AreEqual("A10s", result);
        }

        [TestMethod]
        public void StringManager_StringModifier_ReturnsAnswerWithLongString()
        {
            var result = _stringManager.StringModifier(_longString);

            Assert.AreEqual("I0I m2e A6e P3s f1r t1e A6n w5g m1n , b5e t2t ' s0s w1o I0I a0m a1d t2t i0s w1o I0I c2e a3t .", result);
        }
    }
}
