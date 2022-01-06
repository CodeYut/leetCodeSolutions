public class Solution {
    public void MoveZeroes(int[] nums) {
        int count = 0;
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(nums[i] == 0)
            {
                for(int j = i; j < nums.Length - 1 - count; j++)
                {
                    nums[j] = nums[j + 1];
                    nums[j + 1] = 0;
                    
                }
                count++;
            }
        }
    }
}
