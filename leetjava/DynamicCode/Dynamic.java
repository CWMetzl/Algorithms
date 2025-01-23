public class Dynamic {
  public int robber(int[] nums) {
    if (nums.length == 0) return 0;
    int dp[] = new int[nums.length + 1];
    dp[0] = 0;
    dp[1] = nums[0];

    for(int i = 1;i < nums.length;i++) {
      dp[i+1] = Math.max(dp[i], dp[i - 1] + nums[i]);
    }
    return dp[nums.length];
  }
  
  public static void main(String[] args) {
    Dynamic d = new Dynamic();
    int nums[] = new int[]{1,3,5,5,19};
    int nums2[] = new int[] {1};
    int nums3[] = new int[] {1,3,5,7,100,71};
    System.out.println("Maximum Robbed Cash: " + d.robber(nums));
    System.out.println("Maximum Robbed Cash  2: " + d.robber(nums2));
    System.out.println("Maximum Robbed Cash  3: " + d.robber(nums3));
  }l
}
