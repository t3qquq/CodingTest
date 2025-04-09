using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int k) {
        return Enumerable.Range(1, n).Where(num=>num%k==0).ToArray();
    }
}