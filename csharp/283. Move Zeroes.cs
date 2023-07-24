public class Solution {
    public void MoveZeroes(int[] nums) {

        //Define 0 position
        int zeroPosition = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                (nums[zeroPosition], nums[i]) = (nums[i], nums[zeroPosition]);
                zeroPosition++;
            }
        }

    }
}