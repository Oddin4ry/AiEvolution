using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordLibrary;

namespace WordLibrary
{
    [TestClass]
    public class TestGetVowelByNumber
    {
        [TestMethod]
        public void GetVowelByNumber_0_Assert()
        {
            // Arrange
            string lActualResponse = "";
            bool lExceptionRaised = false;

            // Act
            try
            {
                lActualResponse = WordLibrary.GetVowelByNumber(0);
            }
            catch (System.ArgumentNullException)
            {
                lExceptionRaised = true;
            }

            // Assert
            Assert.IsTrue(lExceptionRaised);
        }
        
        [TestMethod]
        public void GetVowelByNumber_1_A()
        {
            // ARRANGE


            // ACT
            var result = WordLibrary.GetVowelByNumber(1);

            // ASSERT
            Assert.AreEqual("a", result);
        }
        [TestMethod]
        public void GetVowelByNumber_2_E()
        {
            // ARRANGE


            // ACT
            var result = WordLibrary.GetVowelByNumber(2);

            // ASSERT
            Assert.AreEqual("e", result);
        }
        [TestMethod]
        public void GetVowelByNumber_3_I()
        {
            // ARRANGE


            // ACT
            var result = WordLibrary.GetVowelByNumber(3);

            // ASSERT
            Assert.AreEqual("i", result);
        }
        [TestMethod]
        public void GetVowelByNumber_4_O()
        {
            // ARRANGE


            // ACT
            var result = WordLibrary.GetVowelByNumber(4);

            // ASSERT
            Assert.AreEqual("o", result);
        }
        [TestMethod]
        public void GetVowelByNumber_5_U()
        {
            // ARRANGE


            // ACT
            var result = WordLibrary.GetVowelByNumber(5);

            // ASSERT
            Assert.AreEqual("u", result);
        }
    }
}