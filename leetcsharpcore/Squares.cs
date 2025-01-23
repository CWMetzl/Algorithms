public class Squares {
  public int[] SortedSquares(int[] nums) {
    for(int i = 0;i < nums.Length;i++) {
      nums[i] = nums[i] * nums[i];
    }       
    // sort the array
    Array.Sort(nums);
    return nums;
  }
}