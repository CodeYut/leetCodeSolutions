public class Solution {
    public int Search(int[] nums, int target) {
        
        if(nums == null || nums.Length == 0)
        {
            return -1;
        }
        
        int l = 0;
        int r = nums.Length - 1;
        
        while(l <= r)
        {
            int mid = (r - l) / 2 + l;
            
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] < target)
                l = mid + 1;
            else 
                r = mid - 1;
        }
        return -1;
    }
}
