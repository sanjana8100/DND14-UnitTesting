namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        public UserRegistrationProblem.UserRegistration userRegistration = new UserRegistrationProblem.UserRegistration();

        [TestMethod]
        [DataRow ("Sanjana", true)]
        [DataRow ("shreyas", false)]
        public void CheckAndReturnTrueIfFirstNameIsValid(string name, bool expected)
        {
            bool result = userRegistration.ValidateFirstName(name);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Shetty", true)]
        [DataRow("guptha", false)]
        public void CheckAndReturnTrueIfLastNameIsValid(string name, bool expected)
        {
            bool result = userRegistration.ValidateLastName(name);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Sanjana@gmail.com", true)]
        [DataRow("shreyasgmail.co", false)]
        public void CheckAndReturnTrueIfEmailIsValid(string email, bool expected)
        {
            bool result = userRegistration.ValidateEmail(email);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("+91 9535397690", true)]
        [DataRow("9005234567", false)]
        public void CheckAndReturnTrueIfPhoneNumberIsValid(string phone, bool expected)
        {
            bool result = userRegistration.ValidatePhoneNumber(phone);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Sanjana001", true)]
        [DataRow("shreyas", false)]
        public void CheckAndReturnTrueIfPasswordIsValid(string password, bool expected)
        {
            bool result = userRegistration.ValidatePassword(password);
            Assert.AreEqual(expected, result);
        }
    }
}