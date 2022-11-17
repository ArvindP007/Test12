namespace PasswordValidator.Tests
{
    public class PasswordTests
    {
        [Fact]
        public void Validate_GivenNoUpperrCase_ReturnsFalse()
        {
            var TestTarget = new DefaultPasswordValidator();
            var Password = "aaaaaaaabc";
            var ValidationResult = TestTarget.Validate(Password);
            Assert.False(ValidationResult);
        }
        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var TestTarget = new DefaultPasswordValidator();
            var Password = "aBaaaaaac";
            var ValidationResult = TestTarget.Validate(Password);
            Assert.True(ValidationResult);
        }
        [Fact]
        public void Validate_GivenOneNumber_ReturnsTrue()
        {
            var TestTarget = new DefaultPasswordValidator();
            var Password = "aBaaaaaac1";
            var ValidationResult = TestTarget.Validate(Password);
            Assert.True(ValidationResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8_ReturnsFalse()
        {
            var TestTarget = new DefaultPasswordValidator();
            var Password = "aBaaa1";
            var ValidationResult = TestTarget.Validate(Password);
            Assert.False(ValidationResult);
        }
    }
}