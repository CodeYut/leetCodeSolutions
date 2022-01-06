public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var i = 0;
        var j = nums.Length - 1;
        
        while(i < j)
        {
            if(nums[i] + nums[j] == target)
            {
                return new [] {i + 1, j + 1};
            }
            
            if(nums[i] + nums[j] < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return new [] {i + 1, j + 1};
            
    }
}
