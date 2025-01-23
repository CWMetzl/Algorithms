import java.util.*;

class rotateArray {
  public void rotate(int[] nums, int k) {
      int rotated[] = new int[nums.length];
      // get the real amount of rotations if it's rotated more than the length
      int realRotations = k % nums.length;
      // get starting point
      int startingI = nums.length - realRotations;
      int realI = 0;
      for(int i = startingI;i < nums.length;i++) {
          rotated[realI++] = nums[i];
      }
      // now fill in the rest
      if (startingI != 0) {
          for(int i = 0;i < startingI;i++) 
          {
              rotated[realI++] = nums[i];
          }
      }
      for(int i = 0;i < nums.length;i++) {
        nums[i] = rotated[i];
      }
    }
    
    public static void main(String[] args) {
      rotateArray rotater = new rotateArray();
      
      int[] nums = {1, 2, 3, 4, 5, 6};
      int m = 41;
      
      rotater.rotate(nums, m);
      
      System.out.println("Rotated array: " + Arrays.toString(nums));
  }
}
