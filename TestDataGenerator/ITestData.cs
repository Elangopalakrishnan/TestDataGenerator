using System;
namespace TestDataGenerator
{
    public interface ITestData
    {

        DateTime GetDateOfBirth(bool IsSeniorCitizen = false, bool underEighteen = false);

        String GetName(bool IncludingSpecialCharacter = false);

        String GetEmail();

        String GetMobileNumber();

        String GetLandlineNumber();       

    }
}
