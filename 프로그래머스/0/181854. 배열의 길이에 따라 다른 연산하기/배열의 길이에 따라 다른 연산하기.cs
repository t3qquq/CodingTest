using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        
        if(arr.Length%2==0){
            for(int i=0; i<arr.Length; i++){
                answer[i]=i%2==0?arr[i]:arr[i]+n;
            }
        }
        else{
            for(int i=0; i<arr.Length; i++){
                answer[i]=i%2==0?arr[i]+n:arr[i];
            }
        }
        
        return answer;
    }
}