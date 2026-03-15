using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> player1Items = null;
        List<string> player2Items = new List<string>();
        List<string> player3Items = new List<string> { "검", "방패", "포션" };

        PrintInventory("플레이어 1 (인벤토리 없음)", player1Items);
        PrintInventory("플레이어 2 (빈 인벤토리)", player2Items);
        PrintInventory("플레이어 3 (아이템 보유)", player3Items);
    }

    static void PrintInventory(string title, List<string> items)
    {
        Console.WriteLine($"=== {title} ===");

        int count = items?.Count ?? 0;
        Console.WriteLine($"아이템 수: {count}");

        string firstItem = (items != null && items.Count > 0) ? items?[0] ?? "없음" : "없음";
        Console.WriteLine($"첫 번째 아이템: {firstItem}");

        string lastItem = (items != null && items.Count > 0) ? items?[^1] ?? "없음" : "없음";
        Console.WriteLine($"마지막 아이템: {lastItem}");

        Console.WriteLine();
    }
}