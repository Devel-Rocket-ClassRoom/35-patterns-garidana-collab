using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


// README.md를 읽고 코드를 작성하세요.



// 1
{
    Object obj = "hello";  // object
    if (obj is string)  // pattern matching
    {
        string s = (string)obj;  // obj에 할당된 변수가 string 타입인지 확인 후, string으로 캐스팅

        Console.WriteLine(s.Length);
    }
    WriteLine();
}

// 1-2
{
    Object obj1 = 42;
    if (obj1 is int i)
    {
        Console.WriteLine($"정수값: {i}\n제곱: {i * i}");
    }
    else
    {
        Console.WriteLine("정수가 아님.");
    }

   WriteLine();

}

// 1-3
{
    PrintInfo(100);
    PrintInfo(3.14);
    PrintInfo("Hello");
    PrintInfo(true);
    PrintInfo(DateTime.Now);
             

   void PrintInfo(object obj)
    {
        switch (obj)
        {
            case int i:
                WriteLine($"정수: {i}, 2배: {i * 2}");
                break;
            case double d:
                WriteLine($"실수: {d}");
                break;
            case string s:
                WriteLine($"문자열: {s}, 길이: {s.Length}");
                break;
            case bool b:
                WriteLine($"불리언: {b}");
                break;
            deault:
                WriteLine($"기타 타입: {obj.GetType().Name}");
                break;
        }
    }
}

WriteLine();

// 2
{
    CheckValue(0);
    CheckValue("Hello");
    CheckValue(null);
    CheckValue(42);

    void CheckValue(object obj)
    {
        if (obj is 0)
        {
            WriteLine("값이 0임");
        }
        else if (obj is "Hello") 
        {
            WriteLine("값이 Hello임");
        }
        else if (obj is null)
        {
            WriteLine("값이 null임");
        }
        else
        {
            WriteLine($"다른 값: {obj}");
        }
    }
}

WriteLine();

// 3-1

{
    WriteLine(GetDayType(DayOfWeek.Friday));
    WriteLine(GetDayType(DayOfWeek.Saturday));


    string GetDayType(DayOfWeek day) => day switch
    {
        DayOfWeek.Saturday => "주말",
        DayOfWeek.Sunday => "주말",
        _ => "평일"  // _ 는 default 라는 뜻
    };
}

WriteLine();

// 3-2
{
    WriteLine(42);
    WriteLine(3.14);
    WriteLine("Hello");
    WriteLine();

    string DescribeValue(object obj) => obj switch
    {
        int i => $"정수: {i}",
        double d => $"실수: {d}",
        string s => $"문자열: {s}",
        null => $"{null} 값",
        _ => $"알 수 없는 타입({obj.GetType().Name}"
    };
}

WriteLine();

// 4-1
{
    Console.WriteLine($"95점: {GetGrade(95)}");
    Console.WriteLine($"85점: {GetGrade(85)}");
    Console.WriteLine($"75점: {GetGrade(75)}");
    Console.WriteLine($"65점: {GetGrade(65)}");
    Console.WriteLine($"55점: {GetGrade(55)}");

    string GetGrade(int score) => score switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F"
    };
}

WriteLine();


// 4-2
{
    // 인트 배열 변수를 만들어서 foreach문으로 ClassifyTemperature 함수 호출
    int[] temperatures = { -5, 5, 15, 25, 35 };
    foreach (int temp in temperatures)
    {
        Console.WriteLine($"{temp}도: {ClassifyTemperature(temp)}");
    }

    // 반환형 함수이름(데이터형 매개변수) => 변수이름 switch
    // { 조건문, 조건문, 조건문, 조건문, ,,,,,, _ = default };
    // 세미 콜론이 무조건 중괄호 끝나고 들어와야함
    string ClassifyTemperature(int celsius) => celsius switch
    {
        
        < 0 => "영하",
        < 10 => "추움",
        < 20 => "선선함",
        < 30 => "따뜻함",
        _ => "더움"
    };
}

WriteLine();

// 5-2 -> is & and 패턴 사용
{
    WriteLine($"25살 유효한 나이: {IsValidAge(25)}");
    WriteLine($"-5살 유효한 나이: {IsValidAge(-5)}");
    WriteLine($"15살 청소년: {IsTeenager(15)}");
    WriteLine($"25살 청소년: {IsTeenager(25)}");


    // 반환형 함수이름(데이터형 매개변수) => 변수 is 조건 and 조건;
    // 두 조건을 모두 만족하는지 확인
    bool IsValidAge(int age) => age is >= 0 and <= 150;
    bool IsTeenager(int age) => age is >= 13 and <= 19;

}

WriteLine();


// 5-2
{
    WriteLine($"토요일 주말: {IsWeekend(DayOfWeek.Saturday)}");
    WriteLine($"월요일 주말: {IsWeekend(DayOfWeek.Monday)}");
    WriteLine($"'a' 모음: {IsVowel('a')}");
    WriteLine($"'b' 모음: {IsVowel('b')}");
    WriteLine($"'i' 모음: {IsVowel('i')}");

    // 반환형 함수 이름(매개변수) => 매개변수 is 조건 or 조건;
    bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;
    bool IsVowel(char c) => char.ToLower(c) is 'a' or 'e' or 'i' or 'o' or 'u';
}

WriteLine();


// 5-3
{
    WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
    WriteLine($"null not null: {IsNotNull(null)}");
    WriteLine($"\"Hi\" not empty: {IsNotEmpty("Hi")}");
    WriteLine($"\"\" not empty: {IsNotEmpty("")}");

    // 반환형 함수이름 (데이터형 매개변수) => 매개변수 is not 조건;
    bool IsNotNull(object obj) => obj is not null;
    // 반환형 변수 이름 (데이터형 매개변수) => 매개변수 is not 조건(조건 or 조건);
    // or 같은 경우 괄호 안에 위치해서 or 이나 and 나를 쓸 수 있는듯
    bool IsNotEmpty(string s) => s is not (null or "");

}

WriteLine();

// 5-4
{
    int[] numbers = { 0, 5, 42, -3, 100, -50 };
    foreach (int number in numbers)
    {
        WriteLine($"{number}: {ClassifyNumber(number)}");
    }

    // 메서드의 매개변수를 switch로 다양한 조건문 검사 후 그에 맞는 => 반환형에 맞는 값 반환
    string ClassifyNumber(int n) => n switch
    {
        0 => "영",
        >= 1 and <= 9 => "한 자리 양수",
        >= -9 and <= -1 => "한 자리 음수",
        >= 10 and <= 99 => "두 자리 양수",
        _ => "그 외"
    };
}

WriteLine();


// 6
{
    // var upper =""; -> 이걸 선언해 줄 필요도 없이 바로 식에서 선언 할당함
    string[] Names = { "janet", "john", "mike" };
    foreach (string name in Names)
    {
        WriteLine($"{name}: {IsJanetOrJohn(name)}");
    }


    // name.ToUpper()을 한 결괏값을 바로 var upper 에 할당 (선언과 함께)
    bool IsJanetOrJohn(string name) =>
        name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");
}


WriteLine();

// 7-1
{
    Person p1 = new Person("철수", 15);
    Person p2 = new Person("영희", 30);
    Person p3 = new Person("할머니", 70);

    Person[] people = { p1, p2, p3 };
    foreach (Person person in people)
    {
        WriteLine($"{person.Name}({person.Age}): {DescribePerson(person)}");
    }

    string DescribePerson(Person p) => p.Age switch
    {
        < 18 => "미성년자",
        > 18 and < 65 => "성인",
        >= 65 => "노인"
    };
}

WriteLine();

// 7-2
{
    Person p1 = new Person("철수", 15);
    Person p2 = new Person("영희", 30);

    WriteLine($"{Greet(p1)}");
    WriteLine($"{Greet(p2)}");

    string Greet(Person p) => p.Age switch
    {
        <= 18 => $"안녕, {p.Name}!",
        > 18 => $"안녕하세요, {p.Name}님"
    };
}


WriteLine();

// 튜플 when 절 생략
