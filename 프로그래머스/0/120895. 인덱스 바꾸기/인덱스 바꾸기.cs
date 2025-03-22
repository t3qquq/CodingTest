using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        char[] arr = new char[my_string.Length];
        
        for(int i=0; i<my_string.Length; i++){
            arr[i]=my_string[i];
        }
        
        char tmp = arr[num1];
        arr[num1]=arr[num2];
        arr[num2]=tmp;
        
        answer = String.Join("", arr);
        

        
        return answer;
    }
}