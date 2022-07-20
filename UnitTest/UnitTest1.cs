using System;
using FluentAssertions;
using TestDataGenerator;
using Xunit;


namespace UnitTest
{
    public class UnitTest1
    {

        private readonly TestData _tst;


        public UnitTest1()
        {
            _tst = new TestData();

        }

        [Fact]
        public void WhenGenerateNewEmailThenItShouldNotReturnEmptyOrNullValue()
        {
            var email = _tst.GetEmail();
            email.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void WhenGenerateNewNameThenItShouldNotReturnEmptyOrNullValue()
        {
            var name = _tst.GetName();
            name.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void WhenGenerateNewMobileNumberThenItShouldNotReturnEmptyOrNullValue()
        {
            var number = _tst.GetMobileNumber();
            number.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void WhenGenerateNewDateOfBirthThenItShouldNotReturnEmptyOrNullValue()
        {
            var dob = _tst.GetDateOfBirth();
            dob.Should().BeOnOrBefore(DateTime.Now);
        }
    }
}
