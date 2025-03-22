using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        

        for(int i=0; i<my_string.Length; i++){
            if('0'<=my_string[i] && my_string[i]<='9'){
                int n=0;
                int.TryParse(my_string[i].ToString(), out n);
                answer+=n;

            }

        }
        
        return answer;
    }
}