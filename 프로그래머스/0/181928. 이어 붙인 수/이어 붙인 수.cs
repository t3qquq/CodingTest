using System;
using System.Text;

public class Solution {
    public int solution(int[] num_list) {
        
        StringBuilder odds = new StringBuilder();
        StringBuilder evens = new StringBuilder();
        
        for(int i=0; i<num_list.Length; i++){
            if(num_list[i]%2==0)
                evens.Append(num_list[i].ToString());
            else
                odds.Append(num_list[i].ToString());
        }
        
        return int.Parse(evens.ToString())+int.Parse(odds.ToString());
    }
}