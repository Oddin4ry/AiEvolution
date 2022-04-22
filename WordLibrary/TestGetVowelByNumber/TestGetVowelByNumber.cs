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
    }
}