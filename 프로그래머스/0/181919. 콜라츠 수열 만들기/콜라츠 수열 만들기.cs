using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = {};
        List<int> list = new List<int>();
        while(true){
            if(n!=1){
                list.Add(n);
                if(n%2==0)
                    n/=2;
                else
                    n=n*3+1;
            }
            else{
                list.Add(1);
                return list.ToArray();
            }
        }
    }
}