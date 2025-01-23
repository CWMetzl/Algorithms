class Duplicates {
    public int removeDuplicates2(int[] nums) {
        int k = 2;
        for(int i = 2;i < nums.length;i++) {
            if (nums[i] != nums[k - 2]) {
                nums[k] = nums[i];
                k++;
            }   
        }
        return k;
    }

    public int removeDuplicates(int[] nums) {
        int k = 1;
        for(int i = 1;i < nums.length;i++) {
            if (nums[i] != nums[k - 1]) {
                nums[k] = nums[i];
                k++;
            }   
        }
        return k;
    }
}