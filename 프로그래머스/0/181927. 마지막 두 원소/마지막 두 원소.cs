using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = num_list.Concat(new int[] {num_list[num_list.Length-1]>num_list[num_list.Length-2] ? num_list[num_list.Length-1] - num_list[num_list.Length-2] : num_list[num_list.Length-1]*2}).ToArray();
        return answer;
    }
}