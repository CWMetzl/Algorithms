public class Kaitenzushi {
  public static int getMaximumEatenDishCount(int N, int[] D, int K) {
    var eaten = 0;
    var past = new List<int>(K);
    for(int i = 0;i < D.Length;i++) {
      if (!past.Contains(D[i])) {
         eaten++;
      }
      if (past.Count > K) past.RemoveAt(0);
      past.Add(D[i]);
    }
    return eaten;
  }
}