public class Search {
  public static int BinarySearch(int[] nums, int target) {
        if (nums == null || nums.Length == 0) return -1;
        if (nums.Length == 1 && nums[0] == target) return 0;
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;
        // left or right
        while(left <= right) {
            middle = (left + right) / 2;
            if (nums[middle] == target) return middle;
            if (nums[middle] < target) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        return -1;
    }

    public static int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length == 0) return -1;
        if (nums.Length == 1 && nums[0] == target) return 0;
        if (nums[0] > target) return 0;
        if (target > nums[nums.Length - 1]) return nums.Length;
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;
        // left or right
        while(left <= right) {
            middle = (left + right) / 2;
            if (nums[middle] == target) return middle;
            int inleft = middle - 1 >= 0 ? middle - 1 : 0;
            if (target > nums[inleft] && target < nums[middle]) {
                return inleft + 1;
            }
            if (nums[middle] < target) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        return -1; 
    }
}