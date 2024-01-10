using QihangProgram;
namespace featureTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CharacterNameValidatorTest()
        {
            //Arrange
            string name = "TestMoreThan10Characters";

            //Act
            bool moreThanTenChars = QihangCode.CharacterNameValidator(name);

            //Assert
            Assert.IsFalse(moreThanTenChars);
        }

        public void NumberInRangeTest()
        {
            //Arrange
            int number = 499;
            int min = 1;
            int max = 501;

            //Act
            int numberInRange = QihangCode.NumberInRange(min, max);

            //Assert
            Assert.AreEqual(number, numberInRange);
        }
    }
}