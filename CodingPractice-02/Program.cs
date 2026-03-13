using System;
using System.Collections.Generic;
using System.ComponentModel;

//1-1
{
    string name = null;
    name ??= "이름 없음";
    Console.WriteLine(name);
    name ??= "새 이름";
    Console.WriteLine(name);
}

//1-2
{
    string playerName = null;
    if(playerName == null)
    {
        playerName = "플레이어";
    }
    Console.WriteLine(playerName);
}

//1-3
{
    List<string> _items = null;
    _items ??= new List<string>();
    _items.Add("검");
    _items ??= new List<string>();
    _items.Add("방패");
    Console.WriteLine($"아이템 수: {_items.Count}");
    foreach( string item in _items)
    {
        Console.WriteLine($" - {item}"); 
    }
}

//2-1
{
    string message = null;

    int? length = message?.Length;
    Console.WriteLine($"길이: {length}");
    message = "안녕하세요";
    length = message?.Length;
    Console.WriteLine($"길이: {length}");
}

//2-2
{
    string text = null;
    int? length = text?.Length;
    if (length == null) Console.WriteLine("텍스트가 없습니다.");
}

//2-3
{
    string name = null;
    string result = name?.ToUpper();
    Console.WriteLine($"대문자: {result}");
    name = "hello";
    result = name?.ToUpper();
    Console.WriteLine($"대문자: {result}");
}

//2-4
{
    string text = null;
    string result = text?.ToUpper()?.Trim();
    Console.WriteLine($"결과: {result}");
    text = " hello ";
    result = text?.ToUpper()?.Trim();
    Console.WriteLine($"결과: {result}");
}

//2-5
{
    List<string> items = null;
    int? count = items?.Count;
    Console.WriteLine($"아이템 수: {count}");
    items.Add("사과");
    items.Add("바나나");
    count = items?.Count;
    Console.WriteLine($"아이템 수: {count}");
}

//2-6
{
    string text = null;
    char? c = text?[0];
    Console.WriteLine($"첫 글자: {c}");
    text = "Hello";
    c = text?[0];
    Console.WriteLine($"첫 글자: {c}");
}

//3-1
{
    string message = null;
    int length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");
    message = "Hello";
    length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");
}

//3-2
{
    List<string> names = null;
    int count = names?.Count ?? 0;
    names.Add("Kim");
    names.Add("Lee");
    names.Add("Park");
    Console.WriteLine($"이름 수: {count}");
    count = names?.Count ?? 0;
    Console.WriteLine($"이름 수: {count}");
}

//3-3
{
    string playerNAme = null;
    int? playerLevel = null;
    List<string> inventory = null;

    string displayName = playerNAme ?? "Unknown";
    int level = playerLevel ?? 1;
    int itemCount = inventory?.Count ?? 0;

    Console.WriteLine($"플레이어: {displayName}\n레벨: {level}\n인벤토리 아이템: {itemCount}");
}