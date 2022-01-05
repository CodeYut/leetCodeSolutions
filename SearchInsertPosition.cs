public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        if(nums == null || nums.Length == 0)
        {
            return -1;
        }
        int i = 0;
        int j = nums.Length - 1;
        
        while(i <= j)
        {
            int m = j + (i - j) /2;
            
            if(nums[m] == target)
            {
                return m;
            }
            
            else if(nums[m] < target)
            {
                i = m + 1;
            }
            
            else
            {
                j = m - 1;
            }
        }
        
        return i;
    }
}
