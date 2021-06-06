from typing import List


def twoSumBruteForce(nums: List[int], target: int) -> List[int]:  # O(n^2) time

    SIZE = len(nums)
    indices = []

    for i in range(0, SIZE - 1):
        for j in range(i + 1, SIZE):
            if (nums[i] + nums[j] == target):
                indices.append(i)
                indices.append(j)

        return indices


def twoSumOnePassHashtable(nums: List[int], target: int) -> List[int]:
    indices = [None] * 2
    numsHashtable = {}

    for i in range(len(nums)):
        complement = target - nums[i]
        if(complement in numsHashtable):
            indices = [numsHashtable[complement], i]
            return indices

        numsHashtable[nums[i]] = i

    return None

    # test
nums = [2, 4, 4, 7]
target = 8
print(twoSumOnePassHashtable(nums, target))
