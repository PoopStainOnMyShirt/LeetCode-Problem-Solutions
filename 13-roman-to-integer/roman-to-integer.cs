public class Solution {
    public int RomanToInt(string s) {
        int res = 0;
        Dictionary<char, int> numMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for(int i = 0; i < s.Length - 1; i++)
        {
            if(numMap[s[i]] < numMap[s[i+1]]) res -= numMap[s[i]];
            else res += numMap[s[i]];
        }

        return res+numMap[s[s.Length - 1]];
    }
}