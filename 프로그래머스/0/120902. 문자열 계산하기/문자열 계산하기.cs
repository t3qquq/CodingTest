using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        string[] parsed = my_string.Split(" ");
        
        int value;
        string op = "+";
        for(int i=0; i<parsed.Length; i++){
            if(int.TryParse(parsed[i], out value) && op=="+")
                answer+=value;
            else if(int.TryParse(parsed[i], out value) && op=="-")
                answer-=value;
            else if(parsed[i]=="+")
                op="+";
            else if(parsed[i]=="-")
                op="-";
        }
        
        return answer;
    }
}