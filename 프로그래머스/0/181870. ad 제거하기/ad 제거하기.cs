using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = strArr.Where(element => !element.Contains("ad")).ToArray();
        return answer;
    }
}