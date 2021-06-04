"use strict";
// Time: 0(n^2)
function twoSumBruteForce(nums, target) {
	const size = nums.length;
	let indices = new Array(2);
	for (var i = 0; i < size - 1; i++) {
		for (var j = i + 1; j < size; j++) {
			if (nums[i] + nums[j] == target) {
				indices = [i, j];
			}
		}
	}
	return indices;
}
;
// test
var nums = [2, 4, 8];
var target = 7;
console.log(twoSumBruteForce(nums, target));
