public class Solution {
    public bool IsPalindrome(int x) {
        int rev = 0, temp = x;
        
        while (temp > 0)
        {
            rev = (rev * 10) + (temp % 10);
            temp /= 10;
            
        }
        return x == rev;
    }
}
