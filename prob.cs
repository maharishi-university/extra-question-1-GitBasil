public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Initialize the map to store the value and its index
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        // Iterate over each element in the nums array
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];  // Calculate the complement
            
            // Check if the complement exists in the map
            if (map.ContainsKey(complement)) {
                // If found, return the indices
                return new int[] { map[complement], i };
            }
            
            // If not found, add the current number and its index to the map
            map[nums[i]] = i;
        }
        
        // If no solution is found, which should not happen according to the problem statement
        throw new Exception("No two sum solution exists.");
    }
}