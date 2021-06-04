// https: //leetcode.com/problems/two-sum/

#include <iostream>
#include <vector>
using namespace std;

// 0(n^2)
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
				indices.push_back(i);
				indices.push_back(j);
			}
		}
	}

	return indices;
}

// HELPER
void print(vector<int> const &a)
{
	cout << "The vector elements are : ";

	for (int i = 0; i < a.size(); i++)
		cout << a.at(i) << ' ';
}

int main()
{
	vector<int> nums{2, 3, 7, 11, 15};
	int target = 9;

	vector<int> result = twoSumBruteForce(nums, target);
	print(result);
}