public class Solution {
    public int RomanToInt(string s) {
        int res = 0;
        Dictionary<char, int> numMap = new Dictionary<char, int>();
        numMap['I'] = 1;
        numMap['V'] = 5;
        numMap['X'] = 10;
        numMap['L'] = 50;
        numMap['C'] = 100;
        numMap['D'] = 500;
        numMap['M'] = 1000;

        for(int i = 0; i < s.Length; i++)
        {
            if(i < s.Length - 1 && numMap[s[i]] < numMap[s[i+1]]) res -= numMap[s[i]];
            else res += numMap[s[i]];
        }

        return res;
    }
}