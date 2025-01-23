import java.util.*;

class MysteryBox {

  private int elements[];

  private int realEnd;

  private Random rand;

  public MysteryBox(int values[]) {
    elements = Arrays.copyOf(values, values.length);

    realEnd = values.length - 1;

    rand = new Random();
  }

  public Integer pop() {
      if (realEnd < 0)
          return -1; // Return null when no elements are left

      int i = rand.nextInt(realEnd + 1); // Generate random index in the range [0, realEnd]
      int val = elements[i];
      elements[i] = elements[realEnd];
      realEnd--;
      return val;
  }

  public static void main(String[] args) {
    int someValues[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    MysteryBox b = new MysteryBox(someValues);
    for (int i = 0; i < someValues.length; i++) {
      System.out.println(b.pop());
    }
  }
}
