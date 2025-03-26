using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        
        while(numbers.Length/2 < k){
            numbers = numbers.Concat(numbers).ToArray();

        }
        
        for(int i=0; i<k; i++){
            answer = numbers[2*i];
        }
        
        return answer;
    }
}