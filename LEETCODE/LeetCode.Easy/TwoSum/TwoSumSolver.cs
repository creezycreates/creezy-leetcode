namespace LeetCode.Easy.TwoSum;


/// <summary>
///     Class implementing the solution to the
///     LeetCode TwoSum problem. The goal is
///     to find the two numbers in an array that add up to
///     a given target number.
/// </summary>
public class TwoSumSolver
{
    public int[] SolveWithBruteForce(int[] nums, int target)
    {
        int[] indices = [-1, -1];

        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices[0] = i;
                    indices[1] = j; 
                    return indices;
                }
            }
        }
        
        return indices;
    }

    public int[] SolveWithHashMap(int[] nums, int target)
    {
        int[] indices = [-1, -1];
        Dictionary<int, int> complementsMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (complementsMap.ContainsKey(complement))
            {
                indices[0] = i;
                indices[1] = complementsMap[complement];
                return indices;
            }
            
            complementsMap.Add(nums[i], i);
        }
        
        return indices;
    }
}

