using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = arr1.Length==arr2.Length ? arr1.Sum()>arr2.Sum() ? 1 : arr1.Sum()==arr2.Sum() ? 0 : -1 : arr1.Length > arr2.Length ? 1 : -1;
        return answer;
    }
}