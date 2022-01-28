class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        minP, maxP = float('inf'), 0
        
        for price in prices:
            maxPSell = price - minP
            maxP = max(maxP, maxPSell)
            minP = min(minP, price)
        return maxP
