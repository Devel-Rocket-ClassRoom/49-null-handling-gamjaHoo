using System;

int?[] scores = { 3, null, 7, null, 5 };

Console.WriteLine("=== 경기 상태 ===");

int total = 0;
int count = 0;

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i].HasValue)
    {
        Console.WriteLine($"경기 {i + 1}: {scores[i].Value}점 (진행 완료)");
        total += scores[i].Value;
        count++;
    }
    else
    {
        Console.WriteLine($"경기 {i + 1}: 미진행");
    }
}

Console.WriteLine();
Console.WriteLine("=== 전체 점수 (미진행 = -1) ===");

for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: {scores[i].GetValueOrDefault(-1)}");
}

Console.WriteLine();
Console.WriteLine("=== 통계 ===");

double average = count > 0 ? (double)total / count : 0;

Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {total}");
Console.WriteLine($"평균: {average:F1}");