namespace LeetCodeNet.G0001_0100.S0017_letter_combinations_of_a_phone_number {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Backtracking
// #LeetCode_75_Backtracking #Algorithm_II_Day_11_Recursion_Backtracking
// #Udemy_Backtracking/Recursion #Top_Interview_150_Backtracking #Big_O_Time_O(4^n)_Space_O(n)
// #2025_06_12_Time_0_ms_(100.00%)_Space_48.12_MB_(16.34%)

using System.Text;

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) {
            return new List<string>();
        }
        string[] letters = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        List<string> ans = new List<string>();
        StringBuilder sb = new StringBuilder();
        FindCombinations(0, digits, letters, sb, ans);
        return ans;
    }

    private void FindCombinations(
            int start, string nums, string[] letters, StringBuilder curr, List<string> ans) {
        if (curr.Length == nums.Length) {
            ans.Add(curr.ToString());
            return;
        }
        for (int i = start; i < nums.Length; i++) {
            int n = nums[i] - '0'; // Convert char to int
            for (int j = 0; j < letters[n].Length; j++) {
                char ch = letters[n][j];
                curr.Append(ch);
                FindCombinations(i + 1, nums, letters, curr, ans);
                curr.Remove(curr.Length - 1, 1); // Remove last character
            }
        }
    }
}
}
