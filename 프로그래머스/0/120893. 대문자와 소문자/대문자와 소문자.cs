using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        string upperString = my_string.ToUpper();
        string lowerString = my_string.ToLower();
        
        char[] arr = new char[my_string.Length];
        
        for(int i=0; i<my_string.Length; i++){
            if(my_string[i]==upperString[i])
                arr[i] = lowerString[i];
            else
                arr[i] = upperString[i];
        }

        answer = String.Join("", arr);
        
        
        
        return answer;
    }
}