import java.util.*;

public class ArrayTwoPointer {
  public int[] twoSum(int[] numbers, int target) {
      if (numbers.length == 0) return new int[]{0};
      int i = 0;
      int j = numbers.length - 1;

      while(i < j) {
          if ((numbers[i] + numbers[j]) == target) {
              return new int[]{i + 1, j + 1};
          }
          if ((numbers[i] + numbers[j]) > target) {
              j--;
          } else {
              i++;
          }
      }
      return new int[]{0};
  }

  public int binarySearch(int[] nums, int target) {
      if (nums.length == 0) return 0;
      int l = 0;
      int h = nums.length - 1;
      while(l <= h) {
          // check the middle
          int mid = ((h - l) / 2) + l;
          // handle the bullseye
          if (target == nums[mid]) return mid;
          // split down the middle and figure out which side we're looking at
          if (nums[mid] > target) {
              // set the high to the mid
              h = mid - 1;
          } else {
              l = mid + 1;
          }
      }
      return -1;
  }

  public List<List<Integer>> threeSum(int[] nums) {
      // create the result
      List<List<Integer>> result = new ArrayList<>();

      // sort the array first
      Arrays.sort(nums);
      // loop the array and create a left and right to do a two pointer
      for(int i = 0;i < nums.length;i++) {
        // skip duplicate elements for i
          if(i > 0 && nums[i] == nums[i - 1]) {
            continue;
          }
          int l = i + 1;
          int r = nums.length - 1;
          while(l < r) {
              int sum = nums[i] + nums[l] + nums[r];
              if (sum == 0) {
                  // save that value
                  result.add(Arrays.asList(nums[i], nums[l], nums[r]));
                  l++;
                  r--;
                  // handle any dups
                  while (l < r && nums[l] == nums[l - 1]) {
                    l++;
                  } 
                  while (l < r && nums[r] == nums[r + 1]) {
                      r--;
                  }
              } else if(sum < 0 ) {
                  l++;
              } else {
                  r--;
              }
          }
      }
      return result;
  }

  public static void main(String[] args) {
    ArrayTwoPointer s = new ArrayTwoPointer();
    // int val1[] = new int[]{2,7,11,15};
    // // get result
    // int res1[] = s.twoSum(val1, 26);
    // System.out.println("Result 1: " + Arrays.toString(res1)); 

    // // test 3sum
    // int threeSum1[] = new int[]{-1,0,1,2,-1,-4};
    // List<List<Integer>> threeSumRes1 = s.threeSum(threeSum1);
    // System.out.println("ThreeSumResult1: Yes");
    int searchArray[] = new int[]{-1,0,3,5,9,12};
    int searchResult1 = s.binarySearch(searchArray, 9);
    int searchResult2 = s.binarySearch(searchArray, 2);
    System.out.println("Binary Search Result: " + searchResult1);
    System.out.println("Binary Search Result2: " + searchResult2);
  }
}
