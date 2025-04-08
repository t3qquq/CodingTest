using System;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        
        int l=-1;
        
        while(l!=my_string.Length){
            l=my_string.Length;
            my_string = my_string.Replace("  ", " ");
        }
        my_string=my_string.Trim();
        answer = my_string.Split(' ');
        
        return answer;
    }
}