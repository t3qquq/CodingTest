using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[,] score) {
        int length = score.GetLength(0);
        double[] averages = new double[length];
        
        // 1. 평균 계산
        for (int i = 0; i < length; i++) {
            averages[i] = (score[i, 0] + score[i, 1]) / 2.0;
        }

        // 2. 평균 점수를 정렬한 후 등수 매기기 (동점 처리 포함)
        var sorted = averages
            .Select((val, idx) => new { val, idx }) // 평균과 인덱스 같이 저장
            .OrderByDescending(x => x.val)          // 평균 기준 내림차순 정렬
            .ToList();

        int[] ranks = new int[length];
        int rank = 1;
        for (int i = 0; i < sorted.Count; i++) {
            if (i > 0 && sorted[i].val < sorted[i - 1].val) {
                rank = i + 1;
            }
            ranks[sorted[i].idx] = rank;
        }

        return ranks;
    }
}
