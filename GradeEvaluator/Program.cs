using System;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.

string GetGrade(int grade) => grade switch
{
    >= 90 => "A",
    >= 80 and < 90 => "B",
    >= 70 and < 80 => "C",
    >= 60 and < 70 => "D",
    _ => "F"
};

string GetStatus(int grade) => grade switch
{
    >= 95 => "최우수",
    >= 90 and < 95 => "우수",
    >= 70 and < 90 => "보통",
    >= 40 and < 70 => "노력 필요",
    < 40 => "재수강 요망"
};

string IsPassingGrade(int grade) => grade switch
{
    >= 60 => "합격",
    < 60 => "불합띠"
};


int[] scores = { 95, 87, 73, 65, 45, 30 };
WriteLine("=== 성적 평가기 ===");
foreach (int score in scores)
{
    WriteLine($"{score}점: {GetGrade(score)} ({GetStatus(score)}) - {IsPassingGrade(score)}");
}
