using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        return my_string.Length>=is_suffix.Length ? (my_string.Substring(my_string.Length-is_suffix.Length)==is_suffix ? 1 : 0) : 0;
    }
}