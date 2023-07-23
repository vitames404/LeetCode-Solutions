public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        //Add counter
        int counter = 0;

        for(int i = 0; i < flowerbed.Length; i++)
        {
          if(flowerbed[i] == 0)
          {
            int prevValue = (i == 0 || flowerbed[i - 1] == 0)?0:1;
            int nextValue = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)?0:1;

            if(prevValue == 0 && nextValue == 0)
            {
              flowerbed[i] = 1;
              counter++;
            }

          }

        }

        return counter >= n;

    }
}