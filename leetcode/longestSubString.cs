public class LongestSubString {
    public static int LengthOfLongestSubstring(string s) {
        if (String.IsNullOrEmpty(s)) return 0;
        var longest = 1;
        var vals = new HashSet<char>();
        var chars = s.ToCharArray();
        int i = 0;
        while(i < chars.Length) {
            for(int j = i;j < s.Length;j++) {
                var c = chars[j];
                if (!vals.Add(c)) {
                    if (vals.Count > longest) 
                    {
                        longest = vals.Count; 
                    }
                    vals.Clear();
                }
            
                if (vals.Count > longest) {
                    longest = vals.Count;
                }
            } 
            vals.Clear();
            i++;
        }
        return longest;
    }
}