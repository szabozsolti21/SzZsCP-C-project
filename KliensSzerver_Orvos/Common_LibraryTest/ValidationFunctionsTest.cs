using Common_Library.ValidationFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common_LibraryTest
{
    [TestClass]
    public class ValidationFunctionsTest
    {
        [TestMethod]
        public void ValidateName_WithValidArgument_Returns0()
        {

            //Arrange
            var name = "Teszt János";
            var expected = 0;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateName(name));
        }

        [TestMethod]
        public void ValidateName_WithInvalidArgument_Returns1()
        {

            //Arrange
            var name = "";
            var expected = 1;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateName(name));
        }

        [TestMethod]
        public void ValidateName_WithInvalidArgument_Returns2()
        {

            //Arrange
            var name = "Teszt János12";
            var expected = 2;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateName(name));
        }

        [TestMethod]
        public void ValidateTAJ_WithValidArgument_Returns0()
        {

            //Arrange
            var taj = "000 000 001";
            var expected = 0;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateTAJ(taj));
        }

        [TestMethod]
        public void ValidateTAJ_WithInvalidArgument_Returns1()
        {

            //Arrange
            var taj = "";
            var expected = 1;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateTAJ(taj));
        }

        [TestMethod]
        public void ValidateTAJ_WithInvalidArgument_Returns2()
        {

            //Arrange
            var taj = "000 000 0001";
            var expected = 2;

            //Act + Assert
            Assert.AreEqual(expected, ValidationFunctions.ValidateTAJ(taj));
        }


    }
}
