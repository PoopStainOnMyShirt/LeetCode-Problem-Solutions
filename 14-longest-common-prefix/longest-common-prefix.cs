public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //STEP 1: Assign first string to prefix
        string prefix = strs[0];
        //STEP 2: run a loop until prefix is zero
        while (prefix.Length > 0)
        {
            int i = 0;
            for(i = 0; i < strs.Length; i++)
            {
                if(!strs[i].StartsWith(prefix)) break;
            }
            if(i == strs.Length) return prefix;
            else
            {
                prefix = prefix.Remove(prefix.Length - 1);
            }
        }
        return "";
    }
}