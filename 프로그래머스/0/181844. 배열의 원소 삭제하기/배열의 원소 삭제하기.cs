using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        int[] answer = arr.Where(num => !delete_list.Contains(num)).ToArray();
        return answer;
    }
}