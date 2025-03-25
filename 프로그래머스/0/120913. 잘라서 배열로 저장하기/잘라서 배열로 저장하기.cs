using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int resultLen=0;
        if(my_str.Length%n==0)
            resultLen=my_str.Length/n;
        else
            resultLen=my_str.Length/n+1;
        
        string[] answer = new string[resultLen];
        
        
        for(int i=0; i<answer.Length; i++){
            for(int j=i*n; j<i*n+n; j++){
                if(j<my_str.Length)
                    answer[i]+=my_str[j];
                else
                    break;
            }
            Console.WriteLine();
        }
        
        
        
        return answer;
    }
}