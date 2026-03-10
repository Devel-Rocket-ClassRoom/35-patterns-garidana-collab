using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.
Circle c1 = new(5);
Circle c2 = new Circle(15);
Rectangle r1 = new(4, 6);
Rectangle r2 = new(5, 5);
Square s1 = new(7);

WriteLine("=== 도형 분류기 ===");

WriteLine($"원({c1.Radius}): {ClassifyShape(c1)}, 넓이: {CalculateArea(c1):F2}");
WriteLine($"원({c2.Radius}): {ClassifyShape(c2)}, 넓이: {CalculateArea(c2):F2}");
WriteLine($"직사각형({r1.Width}x{r1.Height}): {ClassifyShape(r1)}, 넓이: {CalculateArea(r1):F2}");
WriteLine($"직사각형({r2.Width}x{r2.Height}): {ClassifyShape(r2)}, 넓이: {CalculateArea(r2):F2}");
WriteLine($"정사각형({s1.Side}): {ClassifyShape(s1)}, 넓이: {CalculateArea(s1):F2}");




double CalculateArea(Shape shape) => shape switch
{
    Circle { Radius : var r} => r * r * Math.PI,
    Rectangle { Height : var h, Width : var w} => h * w,
    Square { Side : var s} => s * s
};

string ClassifyShape(Shape shape) => shape switch
{
    Circle { Radius : >= 10} => "큰 원",
    Circle => "작은원",
    Rectangle { Width: var w, Height: var h } when w == h => "정사각형 모양의 직사각형",
    Rectangle => "직사각형",
    Square => "정사각형"
};



