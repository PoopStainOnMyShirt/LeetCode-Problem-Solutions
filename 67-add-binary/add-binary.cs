public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        System.Text.StringBuilder result = new System.Text.StringBuilder(); 
        
        int carry = 0;
        
        while (i >= 0 || j >= 0 || carry == 1)
        {
            int x = (i >= 0) ? a[i] - '0' : 0;
            int y = (j >= 0) ? b[j] - '0' : 0;
            
            int total_sum = x + y + carry;

            result.Append(total_sum % 2); 
            
            carry = total_sum / 2;
            
            i--; 
            j--;
        }

        return string.Join("", result.ToString().Reverse());
    }
}