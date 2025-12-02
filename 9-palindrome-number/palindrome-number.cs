public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0 || (x % 10 == 0 && x != 0)) return false;
        //STEP: copy x into a temp var
        int tmp = x;
        //STEP: while var isnt zero
        int ctr = 0;
        int r = 0;
        while (tmp > 0)
        {
            //STEP: add a counter starting from zero and a result with initial value 0
            //STEP: res = temp%10 * (10^count)
            r *= 10;
            r += tmp % 10;
            tmp /= 10;
            ctr++;
        }
        return (r == x);
        //STEP: Return res == x
    }
}