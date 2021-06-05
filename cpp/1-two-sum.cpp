#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

// HELPER
void printHashMap(unordered_map<int, int> hashmap)
{
	for (const auto &n : hashmap)
	{
		std::cout << "Key:[" << n.first << "] Value:[" << n.second << "]\n";
	}
}

void printVector(vector<int> const &a)
{
	cout << "The vector elements are : ";

	for (int i = 0; i < a.size(); i++)
		cout << a.at(i) << ' ';
}

// 0(n^2) time - O(1) space
vector<int> twoSumBruteForce(vector<int> &nums, int target)
{
	const int size = nums.size();
	vector<int> indices;

	for (int i = 0; i < size - 1; i++)
	{
		for (int j = j + 1; j < size; j++)
		{
			if (nums[i] + nums[j] == target)
			{
				// indices.push_back(i);
				// indices.push_back(j);
				indices = {i, j};
			}
		}
	}

	return indices;
}

// O(n) time - O(n) space
vector<int> twoSumOnePassHashtable(vector<int> nums, int target)
{
	vector<int> indices;
	unordered_map<int, int> numsHashtable; //num & index

	for (int i = 0; i < nums.size(); ++i)
	{
		int complement = target - nums[i];

		if (numsHashtable.find(complement) != numsHashtable.end())
		{
			indices = {numsHashtable[complement], i};
			return indices;
		}

		// numsHashtable.insert({nums[i], i});
		numsHashtable[nums[i]] = i;
	}

	return indices;
}

int main()
{
	vector<int> nums{3, 3, 4};
	int target = 61;

	vector<int> result = twoSumOnePassHashtable(nums, target);
	printVector(result);
}