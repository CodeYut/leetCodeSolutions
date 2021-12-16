public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0)
        {
            return string.Empty;
        }
        
        StringBuilder result = new StringBuilder();
        TrieNode header = strs[0] ==string.Empty ? null : Insert(strs[0], 0);
        
        
        if(header != null)
        {
            for(int i = 1; i < strs.Length; i++)
            {
                if(!Search(header, strs[i], 0))
                {
                    header = null;
                    break;
                }
            }
        }
        
        while(header != null)
        {
            result.Append(header.Set.Keys.First());
            header = header.Set.Values.First();
        }
        return result.ToString();
    }
    
    private TrieNode Insert(string s, int i)
    {
        if(i == s.Length)
        {    
            return null;
        }
        TrieNode node = new TrieNode();
        node.Set.Add(s[i], Insert(s, i + 1));
        return node;
    }
    
    
    private bool Search(TrieNode node, string s, int i)
    {
        if(s == string.Empty || s.Length == i || node == null || !node.Set.ContainsKey(s[i]))
        {
            return false;
        }
        if(!Search(node.Set[s[i]], s, i + 1))
        {
            node.Set[s[i]] = null;
        }
        return true;
            
    }
    
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Set { get; set; }
        public TrieNode()
            {
            Set = new Dictionary<char, TrieNode>();
            }
    }
}
