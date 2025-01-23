public class Diner {
  // public static long getMaxAdditionalDinersCount(long N, long K, int M, long[] S) {
  //   var slist = new List<long>(S);
  //   slist.Sort();
  //   slist.Add(N + K + 1);
  //   long start = 1;
  //   long guests = 0;
  //   long delta = 0;
  //   foreach(long s in slist) {
  //     delta = s - K - start;
  //     guests += delta > 0 ? delta / (K + 1) : 0;
  //     start = s + K + 1;
  //   }
  //   return guests;
  // }
  /*
  public static long getMaxAdditionalDinersCount(long N, long K, int M, long[] S) {
    // Write your code here
    var table = new double[N];
    long totalExtra = 0;
    foreach(long l in S) {
      table[l - 1] = 1;
    }
    
    for(int i = 0;i < N;i++) {
      if (table[i] == 1) continue;
      long left = (i - K) > 0 ? i  - K : 0;
      long right = (i + K) < table.Length ? i + K : table.Length - 1;
      bool clear = true;
      for(long j = left; j <= right; j++) {
        if (table[j] == 1) {
          clear = false;
        }
      }
      if (clear) {
        table[i] = 1;
        totalExtra++;
      }
    }
    return totalExtra;
  } */
   public static long getMaxAdditionalDinersCount(long N, long K, int M, long[] S) {
     Array.Sort(S);
     long start = 0L;
     long extra = 0L;
     foreach(long s in S) {
       start = s - K;
     }
     return 0L;
   }
}