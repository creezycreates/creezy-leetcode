namespace LeetCode.Easy.TwoSum;

public class Driver
{
    public void Run()
    {
        var solver = new TwoSumSolver();
    
    
        Console.WriteLine(">> SOLVE WITH BRUTE FORCE: " +
                          "nums = [2, 7 , 11, 15] , target = 9");
        var startDate = DateTime.Now;
        var result = solver.SolveWithBruteForce(
            [2, 7, 11, 15], 9);
        var endDate = DateTime.Now;
        var elapsedTime = (endDate - startDate).TotalMilliseconds;
        Console.WriteLine(">> indices = [" + result[0] + ", " + 
                          result[1] + "] ; run time = " + elapsedTime + 
                          "milliseconds"+ "\n");
    
        Console.WriteLine(">> SOLVE WITH HASH MAP: " +
                          "nums = [2, 7 , 11, 15] , target = 9");
        startDate = DateTime.Now;
        result = solver.SolveWithHashMap(
            [2, 7, 11, 15], 9);
        endDate = DateTime.Now;
        elapsedTime = (endDate - startDate).TotalMilliseconds;
        Console.WriteLine(">> indices = [" + result[0] + ", " + 
                          result[1] + "] ; run time = " + elapsedTime + 
                          "milliseconds"+ "\n");
    }
    
   
}