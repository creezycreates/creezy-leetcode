namespace LeetCode.Easy.PalindromeNumber;

public class Driver
{
    public void Run()
    {
        var solver = new PalindromeNumberSolver();

        while (true)
        {
            Console.WriteLine("\n>> Enter 0 to exit");
            Console.Write(">> Enter a number:");
            var input = int.Parse(Console.ReadLine() ?? string.Empty);
            if (input == 0)
            {
                break;
            }
            Console.WriteLine(">> Is the number a palindrome " +
                              "(Use String Approach)? " + 
                              solver.CheckIfIsPalindromeUsingString(input));
            
            Console.WriteLine(">> Is the number a palindrome " +
                              "(Use Digit Array Approach)? " + 
                              solver.CheckIfIsPalindromeUsingDigitArray(input));
        }
    }
}