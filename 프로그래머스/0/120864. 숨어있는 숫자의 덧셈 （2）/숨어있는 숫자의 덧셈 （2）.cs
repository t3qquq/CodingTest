using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string strNumber = "";

        for (int i = 0; i < my_string.Length; i++) {
            if (char.IsDigit(my_string[i])) {
                strNumber += my_string[i];
            } else {
                if (strNumber != "") {
                    answer += int.Parse(strNumber);
                    strNumber = "";
                }
            }
        }

        if (strNumber != "") {
            answer += int.Parse(strNumber);
        }

        return answer;
    }
}
