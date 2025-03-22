using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] arr = new char[my_string.Length];
        
        my_string=my_string.ToLower();
        
   
        for(int i=0; i<my_string.Length; i++){
            arr[i]=my_string[i];
        }

        Array.Sort(arr);
        
        for(int i=0; i<my_string.Length; i++){
            answer+=arr[i];
        }
        
        Console.WriteLine(answer);
        return answer;
    }
}