namespace LeetCodeNet.G0101_0200.S0162_find_peak_element {

// #Medium #Top_Interview_Questions #Array #Binary_Search #LeetCode_75_Binary_Search
// #Algorithm_II_Day_2_Binary_Search #Binary_Search_II_Day_12 #Top_Interview_150_Binary_Search
// #2025_07_12_Time_0_ms_(100.00%)_Space_42.58_MB_(54.62%)

public class Solution {
    public int FindPeakElement(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        while (start < end) {
            int mid = start + ((end - start) / 2);
            if (nums[mid + 1] > nums[mid]) {
                start = mid + 1;
            } else {
                end = mid;
            }
        }
        return start;
    }
}
}
