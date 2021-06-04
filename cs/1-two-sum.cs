using System;
class TwoSum {
        static void Main(string[] args) {
                // int[] nums = new int[5] { 2, 5, 46, 14, 9 };
                int[] nums = new int[2] { 3, 3 };
                int target = 11;

                int[] result = TwoSumTwoPassHashtable(nums, target);
                Array.ForEach(result, Console.WriteLine);
        }

        // O(n^2) time - O(1) space
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

        // O(n) time & space
        public static int[] TwoSumTwoPassHashtable(int[] nums, int target) {
                int size = nums.Length;
                int[] indices;
                var nums_hash = new System.Collections.Hashtable(); // num & index
                // var nums_hash = new System.Collections.Generic.Dictionary<int, int>();

                // generate hash table from array
                for (int i = 0; i < size; i++) {
                        int num = nums[i];

                        if (!nums_hash.ContainsKey(num)) {
                                nums_hash.Add(num, i);
                                continue;
                        }

                        // corner case: duplicated key
                        if (num == target / 2) {
                                indices = new int[2] { (int)nums_hash[num], i };
                                return indices;
                        }
                }

                // find the complement
                foreach (int num in nums_hash.Keys) {
                        int complement = target - num;
                        if (nums_hash.ContainsKey(complement) && nums_hash[complement] != nums_hash[num]) {
                                indices = new int[2] { (int)nums_hash[num], (int)nums_hash[complement] };
                                return indices;
                        }
                }

                throw new ArgumentException("Not found");
        }

        // O(n) time & space
        public static int[] TwoSumTwoPassDictionary(int[] nums, int target) {
                int size = nums.Length;
                int[] indices;
                var nums_hash = new System.Collections.Generic.Dictionary<int, int>(); // num & index

                // generate dictionary from array
                for (int i = 0; i < size; i++) {
                        int num = nums[i];

                        if (!nums_hash.ContainsKey(num)) {
                                nums_hash.Add(num, i);
                                continue;
                        }

                        // corner case: duplicated key
                        if (num == target / 2) {
                                indices = new int[2] { nums_hash[num], i };
                                return indices;
                        }
                }

                // find the complement
                foreach (int num in nums_hash.Keys) {
                        int complement = target - num;
                        if (nums_hash.ContainsKey(complement) && nums_hash[complement] != nums_hash[num]) {
                                indices = new int[2] { nums_hash[num], nums_hash[complement] };
                                return indices;
                        }
                }

                throw new ArgumentException("Not found");
        }
}

