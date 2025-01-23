class Palindrome {
  public boolean isPalindrome(String s) {
    String lowerStr = s.toLowerCase();

    StringBuilder onlyAlphaN = new StringBuilder();
    for(char c : lowerStr.toCharArray()) {
      if  (Character.isLetterOrDigit(c)) { 
        onlyAlphaN.append(c); 
      }
    }
    String lowersString = onlyAlphaN.toString();
    char[] lowerS = lowersString.toCharArray();
    int i = 0;
    int k = onlyAlphaN.length() - 1;
    while(i <= k) {
      if  (lowerS[i] != lowerS[k]) {
        return false;
      }
      i++;
      k--;
    }
    return true;
  }

  public static void main(String[] args) {
    Palindrome p = new Palindrome();
      
      boolean isPal1 = p.isPalindrome("A man, a plan, a canal: Panama");
      boolean isPal2 = p.isPalindrome("race a car");
      boolean isPal3 = p.isPalindrome(" ");
      
      System.out.println("Is palindrome1: " + isPal1);
      System.out.println("Is palindrome2: " + isPal2);
      System.out.println("Is palindrome3: " + isPal3);
    }
}