public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        int maxLen = -1;
        Dictionary<char, int> dic = new Dictionary<char,int>(); //Will store new characters and their position
        int start = 0;
        for(int end = 0; end < s.Length; end++)
        {
            char cur = s[end];
            if(dic.ContainsKey(cur) && dic[cur] >= start) start = dic[cur] + 1;
            dic[cur] = end;
            maxLen = Math.Max(maxLen, end - start + 1);
        }
        return maxLen;
    }
}