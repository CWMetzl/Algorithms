class Subsequence {
  public boolean isSubsequence(String s, String t) {
    if (s == null || s.length() == 0) {
      return true;
    }
    if (t == null || t.length() == 0) {
      return false;
    }
    char[] schar = s.toCharArray();
    char[] tchar = t.toCharArray();
    int spt = 0;
    int tpt = 0;
    while(tpt < t.length() && spt < s.length()) {
      if (schar[spt] == tchar[tpt]) {
        spt++;
      }
      tpt++;
    }
    if (spt >= schar.length) { return true; }
    return false;
  }

    
  public static void main(String[] args) {
    Subsequence sub = new Subsequence();
      boolean isSub1 = sub.isSubsequence("azc","ahbgdc" );
      boolean isSub2 = sub.isSubsequence("b","abc" );
      System.out.println("IsSub1: " + isSub1);
      System.out.println("IsSub2: " + isSub2);
  }
}
