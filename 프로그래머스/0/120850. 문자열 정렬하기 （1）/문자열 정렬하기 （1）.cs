using System;

public class Solution {
    public int[] solution(string my_string) {
        int count=0;
        
        for(int i=0; i<my_string.Length; i++){
            if('0'<=my_string[i]&&my_string[i]<='9')
                count++;
        }
        
        
        int[] answer = new int[count];

        count=0;
        
        for(int i=0; i<my_string.Length; i++){
            if('0'<=my_string[i]&&my_string[i]<='9')
                answer[count++]=int.Parse(my_string[i].ToString());
        }

        Array.Sort(answer);

        
        
        return answer;
    }
}