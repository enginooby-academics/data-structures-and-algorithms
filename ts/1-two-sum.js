"use strict";
// Time: 0(n^2)
function twoSumBruteForce(nums, target) {
        const size = nums.length;
        let indices = new Array(2);
        for (var i = 0; i < size - 1; i++) {
                for (var j = i + 1; j < size; j++) {
                        if (nums[i] + nums[j] == target) {
                                return indices = [i, j];
                        }
                }
        }
        return indices;
}
;
function twoSumOnePassHashtable(nums, target) {
        let indices = new Array(2);
        let numsHashtable = new Map();
        for (let i = 0; i < nums.length; i++) {
                let complement = target - nums[i];
                if (numsHashtable.has(complement)) {
                        // use non-null assertion operator (!) since we already checked the map has that key
                        return indices = [numsHashtable.get(complement), i];
                }
                numsHashtable.set(nums[i], i);
        }
        return indices;
}
// test
var nums = [2, 2, 8];
var target = 4;
console.log(twoSumOnePassHashtable(nums, target));
