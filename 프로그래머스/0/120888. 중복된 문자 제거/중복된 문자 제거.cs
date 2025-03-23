using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        answer+=my_string[0];
        
        for(int i=1; i<my_string.Length; i++){
            int check=0;
            for(int j=0; j<i; j++){
                if(my_string[i]==my_string[j]){
                    check=-1;
                    break;
                }
            }
            if(check==0)
                answer+=my_string[i];
        }
        
        return answer;
    }
}