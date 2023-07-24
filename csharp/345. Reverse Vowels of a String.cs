public class Solution {
    public string ReverseVowels(string s) {

        //Array with the vowels  
        char[] vow = new [] {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};

        //Split the string into a array
        char[] stringArray = s.ToCharArray();

        //Start a stack called newString
        Stack newString = new Stack();

        for(int i = 0; i < stringArray.Length; i++)
        {
            if(vow.Contains(stringArray[i]))
            {
                newString.Push(stringArray[i]);
            }
        }

        for(int i = 0; i < stringArray.Length; i++)
        {
            if(vow.Contains(stringArray[i]))
            {
                stringArray[i] = Convert.ToChar(newString.Pop());
            }
        }

        return new string(stringArray);

    }
}