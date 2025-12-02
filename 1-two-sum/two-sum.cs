public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hashMap = new Dictionary<int,int>(); //Here first number will be the number seen, second will be index

        //STEP 1. Read through all the numbers in the array
        for(int i=0; i < nums.Length; i++)
        {
            //Step 2. find complement = target - arr[i]
            int complement = target - nums[i];
            //Step 3. Look through the hashMap to see if we have the complement
            if(hashMap.ContainsKey(complement))
            {
                //Step 4. If found, return. answer is [<i>,<hashMap[complement]>]
                return new int[] {i, hashMap[complement]};
            }
            
            //Step 5. If not found, store in hashMap
            hashMap[nums[i]] = i;

        }
        return new int[0];
    }
}