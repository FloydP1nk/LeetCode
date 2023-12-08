public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for (int i =0; i < nums.Length; ++i){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], 1);
            } else {
                return true;
            }
        }
        return false;
    }
}