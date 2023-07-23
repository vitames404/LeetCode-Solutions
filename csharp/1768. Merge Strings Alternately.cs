public class Solution {
    public string MergeAlternately(string word1, string word2) {
        char[] firstWord = word1.ToCharArray();
        char[] secondWord = word2.ToCharArray();

        string finalWord = "";

        int counter = 0;

        if(firstWord.Length == secondWord.Length)
        {
            //Durante toda a primeira palavra
            for(int i = 0; i < firstWord.Length ; i++)
            {
                finalWord = finalWord + firstWord[i];
                finalWord = finalWord + secondWord[i];
            }
        }

        if(firstWord.Length > secondWord.Length)
        {
           for(int i = 0; i < secondWord.Length; i++)
           {
               finalWord = finalWord + firstWord[i];
               finalWord = finalWord + secondWord[i];
               counter++;
           } 
            
            for(int i = counter; i < firstWord.Length; i++)
            {
                finalWord = finalWord + firstWord[i];
            }

        }

        if(secondWord.Length > firstWord.Length)
        {
            for(int i = 0; i < firstWord.Length; i++)
            {
                finalWord = finalWord + firstWord[i];
                finalWord = finalWord + secondWord[i];
                counter++;
            }

            for(int i = counter; i < secondWord.Length; i++)
            {
                finalWord = finalWord + secondWord[i];
            }
        } 
        

        return finalWord;
    }
}