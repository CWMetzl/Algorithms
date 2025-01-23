package arrays;
class calculateCanJump {
  public boolean canJump(int[] nums) {
    if (nums.length == 1) return true;
    int i = 0;
    while(i < nums.length) {
        int jump = nums[i];
        if (jump == 0 && i + jump < nums.length) return false;
        i = i + jump;
        if(i >= (nums.length - 1)) {
            return true;
        }
    }
    return false;
  }

  public static void main(String[] args) {
    calculateCanJump jump = new calculateCanJump();
      
      int[] jump1 = {2,3,1,1,4};
      int[] jump2 = {3,2,1,0,4};
      int[] jump3 = {2,0};
      int[] jump4 = {2,0,0};
      
      boolean canJump1 = jump.canJump(jump1);
      boolean canJump2 = jump.canJump(jump2);
      boolean canJump3 = jump.canJump(jump3);
      boolean canJump4 = jump.canJump(jump4);

      System.out.println("Can jump1 to end: " + canJump1);
      System.out.println("Can jump2 to end: " + canJump2);
      System.out.println("Can jump3 to end: " + canJump3);
      System.out.println("Can jump4 to end: " + canJump4);
  }
}