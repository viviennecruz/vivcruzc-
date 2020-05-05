/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

**Question found on leetcode: https://leetcode.com/problems/two-sum/ */

public class Solution {
    int [] newArr;
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i ++){
           int val = target-nums[i];
            bool found = false;
            int secondNum =0;
            for(int j = 0; j < nums.Length; j++){
                if (j == i){
                    continue;
                }
                if(nums[j] == val){
                    secondNum = j;
                    found = true;
                    break;
                }
            }

            if (found){
                newArr = new int []{i,secondNum};
            }

        }

        return newArr;

    }
}
