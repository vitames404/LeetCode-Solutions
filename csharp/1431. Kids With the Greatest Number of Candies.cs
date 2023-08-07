public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int max = candies.Max();

        bool[] candiesBool = new bool[candies.Length];

        for(int i = 0; i < candies.Length; i++)
        {
            if(candies[i] + extraCandies >= max)
            {
                candiesBool[i] = true;
            }
            else
            {
                candiesBool[i] = false;
            }
        }

        return candiesBool;
    }
}