class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        index = 1
        
        for i in range(2, len(nums)):
            if nums[index] != nums[i] or nums[index] != nums[index - 1]:
                nums[index + 1] = nums[i]
                index += 1
        return index + 1
