/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int lo = 0;
        int hi = n;
        
        while(lo < hi)
        {
            int mid = lo + (hi - lo)/2;
            
            if(IsBadVersion(mid))
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }
}
