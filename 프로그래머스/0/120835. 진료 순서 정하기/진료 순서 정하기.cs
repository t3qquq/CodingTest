using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        
        int[] order = (int[])emergency.Clone();
        Array.Sort(order);
        Array.Reverse(order);
        
        for(int i=0; i<emergency.Length; i++){
            Console.Write($"{emergency[i]} ");
        }
        Console.WriteLine();
        for(int i=0; i<emergency.Length; i++){
            Console.Write($"{order[i]} ");
        }
        Console.WriteLine();
        
        
        for(int i=0; i<emergency.Length; i++){
            answer[i]=Array.IndexOf(order, emergency[i])+1;
        }
        
        return answer;
    }
}