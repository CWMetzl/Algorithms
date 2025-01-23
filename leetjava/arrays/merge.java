import java.util.ArrayList;

class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        ArrayList<Integer> res = new ArrayList<>();
        
        int i = 0, j = 0;
        
        // Traverse both arrays and add smaller elements to the ArrayList
        while (i < m && j < n) {
            if (nums1[i] < nums2[j]) {
                res.add(nums1[i]);
                i++;
            } else {
                res.add(nums2[j]);
                j++;
            }
        }
        
        // Add remaining elements of nums1 (if any)
        while (i < m) {
            res.add(nums1[i]);
            i++;
        }
        
        // Add remaining elements of nums2 (if any)
        while (j < n) {
            res.add(nums2[j]);
            j++;
        }
        
        // Copy elements from ArrayList back to nums1
        for (int k = 0; k < res.size(); k++) {
            nums1[k] = res.get(k);
        }

        
        
    }

    public static void main(String[] args) {
        Duplicates solution = new Duplicates();
        
        int[] nums1 = {1, 2, 3, 4, 5, };
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;
        
        solution.merge(nums1, m, nums2, n);
        
        System.out.println("Merged array: " + Arrays.toString(nums1));
    }
}
