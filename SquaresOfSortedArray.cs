public class Solution {
    public int[] SortedSquares(int[] A) {
        int[] res = new int[A.Length];
        int left = 0;
        int right = A.Length - 1;
        
        for(int i = A.Length - 1; i >= 0; i--)
        {
            if(Math.Abs(A[left]) >= Math.Abs(A[right]))
            {
                res[i] = A[left] * A[left];
                left++;
            }
            else
            {
                res[i] = A[right] * A[right];
                right--;
            }
        }
        return res;
    }
}
