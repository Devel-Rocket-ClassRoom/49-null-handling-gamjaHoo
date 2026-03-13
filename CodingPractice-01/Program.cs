using System;

//1
{
    int number = 0;
    string text = "";
    string nothing = null;

    Console.WriteLine(number);
    Console.WriteLine(text);
    Console.WriteLine(nothing);
}

//2
{
    string name = null;
    Console.WriteLine(name==null);
}

//3
{
    int? i = null; 
    double? d = null;
    bool? b = null;

    Nullable<int> n = null;
    Nullable<double> dd = null;

    Console.WriteLine(i);
    Console.WriteLine(dd);
    Console.WriteLine(n);
}

//3-2
{
    int? score = null;
    Console.WriteLine(score.HasValue);
    score = 95;
    Console.WriteLine(score.HasValue);
    Console.WriteLine(score.Value);
}

//3-3
{
    int? empty = null;
    if (empty.HasValue)
    {
        Console.WriteLine(empty.Value);
    }
    else
    {
        Console.WriteLine("값이 없습니다.");
    }
}

//3-4
{
    int? level = null;
    Console.WriteLine(level.GetValueOrDefault());
    Console.WriteLine(level.GetValueOrDefault(1));
    level = 50;
    Console.WriteLine(level.GetValueOrDefault());
}

//3-5
{
    int number = 42;
    int? nullable = number;
    int back = (int)nullable;

    Console.WriteLine($"nullable: {nullable}");
    Console.WriteLine($"back: {back}");
}

//4-1
{
    string message = null;
    string result = message ?? "기본 메시지";
    Console.WriteLine(result);
    message = "안녕하세요";
    result = message ?? "기본 메시지";
    Console.WriteLine(result);
}

//4-2
{
    string input = null;
    string output;
    if(input == null)
    {
        output = "기본값";
    }
    else
    {
        output = input;
    }
    Console.WriteLine(output);

    output = input ?? "기본값";

    Console.WriteLine(output);
}

//4-3
{
    int? score = null;
    int score1;
    int health1;
    score1 = score ?? -1;

    int? health = null;
    health1 = health ?? default(int);

    Console.WriteLine($"점수: {score1}");
    Console.WriteLine($"체력: {health1}");
}

//4-4
{
    string first = null;
    string second = null;
    string third = "세 번째 값";
    Console.WriteLine(first ?? second ?? third);
}