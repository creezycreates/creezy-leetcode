namespace LeetCode.Easy.PalindromeNumber;

public class PalindromeNumberSolver
{
    public bool CheckIfIsPalindromeUsingString(int x)
    {
        bool isPalindrome = false;
        string text = x.ToString();
        string reversedText = ReverseText(text);

        if (text == reversedText)
        {
            isPalindrome = true;
        }
        
        return isPalindrome;
    }

    public bool CheckIfIsPalindromeUsingDigitArray(int x)
    {
        var isPalindrome = true;
        
        if (x < 0)
        {
            return false;
        }

        var digits = ConvertIntegerToDigitsArray(x);
        var left = 0;
        var right = digits.Length - 1;

        while (left < right)
        {
            if (digits[left] != digits[right])
            {
                isPalindrome = false;
                break;
            }
            
            left++;
            right--;
        }
        
        return isPalindrome;
    }



    private int[] ConvertIntegerToDigitsArray(int x)
    {
        var digitsCollection = new List<int>();
        var highestDivisor = ComputeHighestDivisor(x);
        var remainder = x;

        while (highestDivisor != 0)
        {
            var digit = remainder / highestDivisor;
            remainder = x % highestDivisor;
            highestDivisor /= 10;
            digitsCollection.Add(digit);
        }
       
        var digits = digitsCollection.ToArray();
        return digits;
    }

    private int ComputeHighestDivisor(int x)
    {
        int highestDivisor = 1;

        while (highestDivisor <= x)
        {
            if (highestDivisor * 10 > x)
            {
                break;
            }
            
            highestDivisor *= 10;
        }
        
        return highestDivisor;
    }

    private string ReverseText(string text)
    {
        string reversedText = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedText += text[i];
        }
        
        return reversedText;
    }
}