public class Photography {
  public static int getArtisticPhotographCount(int N, string C, int X, int Y) {
    // Count photos
    var photostring = C.ToCharArray();
    var numartistic = 0;
    for(int i = 0;i < photostring.Length;i++) {
      char c = photostring[i];
      // a photo is at least 1 pab sequence
      if (char.ToLowerInvariant(c) == 'p') {
        // check left and right for 'a''s and compare them to the distance to p\
        var left = (i - X) >= 0 ? i - X : 0;
        var right = (i + Y) < photostring.Length ? i + Y : photostring.Length;
        var isArtistic = false;
        var foundA = false;
        var foundB = false;
        for(int j = left;j < right;j++) {
          char ch = photostring[j];
          if (char.ToLowerInvariant(ch) == 'a') {
            if (foundB && !foundA) {
              
            }
            foundA = true; 

          }
          if (foundA && foundB) {

          }
        }
        if (isArtistic) numartistic++;
        isArtistic = false;
      }
    }
    return numartistic;
  }
}