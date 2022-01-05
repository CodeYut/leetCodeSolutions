public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int[] output = new int[nums.Length];
        int length = nums.Length;
        
        for(int i = 0; i < nums.Length; i++)
        {
            output[(i + k) % length] = nums[i];
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = output[i];
        }
    }
}
