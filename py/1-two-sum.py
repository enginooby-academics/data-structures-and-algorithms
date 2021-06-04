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


# test
nums = [2, 5, 6, 8]
target = 8
print(twoSumBruteForce(nums, target))
