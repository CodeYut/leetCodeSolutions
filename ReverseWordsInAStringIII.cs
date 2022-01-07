public class Solution {
    public string ReverseWords(string s) {
        
        string [] words = s.Split(' ');
        Stack<char> stack = new Stack<char>();
        StringBuilder output = new StringBuilder();
        
        foreach(string wrd in words)
        {
            foreach(char chr in wrd)
            {
                stack.Push(chr);
            }
            
            while(stack.Count != 0)
            {
                output.Append(stack.Pop());
            }
                output.Append(" ");
        }
        return output.ToString().TrimEnd();
        
    }
}
