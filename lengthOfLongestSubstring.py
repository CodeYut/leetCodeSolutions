class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        charSet = set()
        lp = 0
        res = 0
        
        for r in range(len(s)):
            while s[r] in charSet:
                charSet.remove(s[lp])
                lp += 1
            charSet.add(s[r])
            res = max(res, r - lp + 1)
        return res    
