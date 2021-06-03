using System;
class TwoSum {
        static void Main(string[] args) {
                int[] nums = new int[4] { 2, 5, 3, 14 };
                int target = 11;

                int[] result = TwoSumBruteForce(nums, target);
                Array.ForEach(result, Console.WriteLine);
        }

        //Time: O(n^2)
        public static int[] TwoSumBruteForce(int[] nums, int target) {
                int size = nums.Length;
                int[] indices = new int[2];

                for (int i = 0; i < size - 1; i++) {
                        for (int j = i + 1; j < size; j++) {
                                if (nums[i] + nums[j] == target) {
                                        indices[0] = i;
                                        indices[1] = j;

                                        return indices;
                                }
                        }
                }

                throw new ArgumentException("Not found");
        }
}
