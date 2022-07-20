using System;

namespace TestDataGenerator
{
    public class TestData : ITestData
    {

        private readonly Random _random;

        public TestData()
        {
            _random = new Random();
        }


        public string GetEmail()
        {

            return "epkmca@gmail.com";
        }

        public string GetMobileNumber()
        {
            return "07438177532";
        }

        public string GetLandlineNumber()
        {
            return "44743817753";
        }

        public DateTime GetDateOfBirth(bool IsSeniorCitizen = false, bool underEighteen = false)
        {
            return DateTime.Now.AddYears(-20);
        }

        public string GetName(bool IncludingSpecialCharacter = false)
        {
            return "epkmca";
        }
    }

}
