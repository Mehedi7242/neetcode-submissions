public class Solution {
public int ClimbStairs(int n) 
    {     
        int totalStairs = n;
        if (totalStairs <= 1) 
        {
            return 1;
        }

        int[] waysToReachStep = new int[totalStairs + 1];

        waysToReachStep[1] = 1;
        waysToReachStep[2] = 2; 

        for (int currentStep = 3; currentStep <= totalStairs; currentStep++)
        {
            int oneStepBehind = waysToReachStep[currentStep - 1];
            int twoStepsBehind = waysToReachStep[currentStep - 2];
            
            waysToReachStep[currentStep] = oneStepBehind + twoStepsBehind;
            Console.WriteLine($"Step {currentStep}: {oneStepBehind} ways + {twoStepsBehind} ways = {waysToReachStep[currentStep]} total ways");
        }
        return waysToReachStep[totalStairs];
    }
}
