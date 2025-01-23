import java.util.*;

class RearrangeArray {

  public static List<Integer> Rearrange(int[] input) {
    //if (input.length == 0) return 
    Map<Integer, Integer> numNums = new HashMap<>();

    for(int number : input) {
      numNums.put(number, numNums.getOrDefault(number, 0) + 1);
    }

    PriorityQueue<Integer[]> myQueue = new PriorityQueue<>((a, b) -> b[0] - a[0]);
    for(Map.Entry<Integer, Integer> entry : numNums.entrySet()) {
        myQueue.offer(new Integer[]{entry.getValue(), entry.getKey()});
    }

    List<Integer> res = new ArrayList<>();

    Integer[] prev = {-1,0};

    while(!myQueue.isEmpty()) {
      Integer[] currentValue = myQueue.poll();
      res.add(currentValue[1]);

      if (prev[0] > 0) {
        myQueue.offer(prev);
      }

      prev = new Integer[]{currentValue[0] - 1, currentValue[1]};
    }

    return res;
  }

  public static void main(String[] args) {
    int samp1[] = {1,1,1,1,2,2,3,3,1,3,2};
    // Solution sol = new Solution();
    List<Integer> samp1Out = Rearrange(samp1);

    for(int i = 0;i < samp1Out.size();i++) {
      System.out.print(samp1Out.get(i));
      if (i < samp1Out.size() - 1) System.out.print(",");
    }
    System.out.println();
  }
}
