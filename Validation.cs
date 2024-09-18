using System;

class Validation
{
    static void Main()
    {
        // Input mobile number
        Console.Write("Enter your mobile number in the format XXXX-XXXXXX: ");
        string mobileNumber = Console.ReadLine();

        // Validate mobile number format
        if (ValidateMobileNumber(mobileNumber))
        {
            Console.WriteLine("The mobile number is valid.");
        }
        else
        {
            Console.WriteLine("The mobile number is invalid.");
        }
    }

    static bool ValidateMobileNumber(string mobileNumber)
    {
        // Check if the format matches the pattern XXXX-XXXXXX
        if (mobileNumber.Length != 11 || mobileNumber[4] != '-')
        {
            return false;
        }

        // Extract the first part (before the hyphen) and second part (after the hyphen)
        string firstPart = mobileNumber.Substring(0, 4);
        string secondPart = mobileNumber.Substring(5, 6);

        // Check if both parts are numeric
        if (!IsNumeric(firstPart) || !IsNumeric(secondPart))
        {
            return false;
        }

        // Check the length and first digit rules
        string fullNumber = firstPart + secondPart;
        if (fullNumber.Length != 10 || (fullNumber[0] != '9' && fullNumber[0] != '8'))
        {
            return false;
        }

        return true;
    }

    static bool IsNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
