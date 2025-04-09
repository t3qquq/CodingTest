using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int mul = 1;
        for(int i=0; i<num_list.Length; i++){
            mul*=num_list[i];
        }
        int sqr = num_list.Sum()*num_list.Sum();
        return mul>sqr ? 0 : 1;
    }
}