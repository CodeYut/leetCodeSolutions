public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        Hashtable hash = new Hashtable();
        
        foreach(var item in nums)
        {
            if(hash.Contains(item))
            {
                return true;
            }
            else
            {
                hash.Add(item, null);
            }
        }
        return false;
    }
}
