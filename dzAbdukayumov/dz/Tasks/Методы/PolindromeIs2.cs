using System;


public class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;
        string cleanStr = input.Replace(" ", "").ToLower();

        for (int i = 0; i < cleanStr.Length / 2; i++)
        {
            if (cleanStr[i] != cleanStr[cleanStr.Length - 1 - i])
                return false;
        }


        return true;
    }
}
