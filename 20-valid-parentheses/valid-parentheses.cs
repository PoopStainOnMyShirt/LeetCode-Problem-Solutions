public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        char popped;
        bool flag = true;
        for(int i = 0; i < s.Length; i++)
        {
            switch(s[i])
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(s[i]);
                    break;
                case ')':
                    if(stack.Count == 0) return false;
                    popped = stack.Pop();
                    if(popped != '(') return false;
                    break;
                case '}':
                    if(stack.Count == 0) return false;
                    popped = stack.Pop();
                    if(popped != '{') return false;
                    break;
                case ']':
                    if(stack.Count == 0) return false;
                    popped = stack.Pop();
                    if(popped != '[') return false;
                    break;

            }
        }
        if(stack.Count == 0) return true;
        else return false;
    }
}