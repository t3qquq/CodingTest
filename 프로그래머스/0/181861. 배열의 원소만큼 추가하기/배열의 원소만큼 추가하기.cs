using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Sum()];
        int idx = 0;
        for(int i=0; i<arr.Length; i++){
            for(int j=0; j<arr[i]; j++){
                answer[idx++] = arr[i];
            }
        }
        
        return answer;
    }
}