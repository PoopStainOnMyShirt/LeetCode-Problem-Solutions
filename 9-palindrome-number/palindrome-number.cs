public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0 || (x % 10 == 0 && x != 0)) return false;
        //We try to compare two halves instead
        int reverseHalf = 0;
        while(reverseHalf < x)
        {
            reverseHalf *= 10;
            reverseHalf += x%10;

            x/=10;
        }
        return reverseHalf == x || reverseHalf / 10 == x;
    }
}