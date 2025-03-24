using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;

        for(int count=i; count<=j; count++){
            String str = count.ToString();
            for(int idx=0; idx<str.Length; idx++){
                if(k.ToString() == str.Substring(idx, 1))
                    answer++;
            }
        }
        
        
        return answer;
    }
}