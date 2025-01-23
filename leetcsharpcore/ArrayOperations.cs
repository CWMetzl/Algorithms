public class ArrayOperations {
  public static void Rotate(int[] nums, int k) {
    var result = new int[nums.Length];
    int pos = 0;
    for(int i = nums.Length - k; i < nums.Length;i++) {
      result[pos++] = nums[i];
    }
    for(int i = 0; i <= (nums.Length - k + 1);i++) {
      result[pos++] = nums[i];
    }
    result.CopyTo(nums, 0);
  }
  public static int[] MoveZeroesToLeft(int[] nums) {
    var read_index = nums.Length - 1;
    var write_index = nums.Length - 1;
    while (read_index >= 0) {
      var index = read_index--;
      if (nums[index] != 0) {
        nums[write_index--] = nums[index];
      }
    }
    while(write_index >= 0) {
      nums[write_index--] = 0;
    }
    return nums;
  }
}
