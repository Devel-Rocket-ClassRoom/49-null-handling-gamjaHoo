using System;

class Program
{
    static void Main()
    {
        string userNameUser = null;
        string userNameProfile = "프로필유저";
        string userNameGlobal = null;
        string userNameDefault = "Player";

        string serverUser = null;
        string serverProfile = null;
        string serverGlobal = null;
        string serverDefault = "localhost";

        string languageUser = "English";
        string languageProfile = "Korean";
        string languageGlobal = "Japanese";
        string languageDefault = "Korean";

        int? volumeUser = null;
        int? volumeProfile = null;
        int? volumeGlobal = 70;
        int volumeDefault = 50;

        Console.WriteLine("=== 설정 결정 ===");

        string finalUserName = userNameUser ?? userNameProfile ?? userNameGlobal ?? userNameDefault;
        string finalServer = serverUser ?? serverProfile ?? serverGlobal ?? serverDefault;
        string finalLanguage = languageUser ?? languageProfile ?? languageGlobal ?? languageDefault;
        int finalVolume = volumeUser ?? volumeProfile ?? volumeGlobal ?? volumeDefault;

        Console.WriteLine($"플레이어 이름: {finalUserName} (프로필 설정에서 가져옴)");
        Console.WriteLine($"서버 주소: {finalServer} (기본값에서 가져옴)");
        Console.WriteLine($"언어: {finalLanguage} (사용자 설정에서 가져옴)");
        Console.WriteLine($"볼륨: {finalVolume} (전역 설정에서 가져옴)");

        Console.WriteLine();
        Console.WriteLine("=== 캐시 저장 (??=) ===");

        string cachedPlayerName = null;

        Console.WriteLine($"캐시 저장 전: {cachedPlayerName ?? "null"}");

        cachedPlayerName ??= finalUserName;
        Console.WriteLine($"첫 번째 ??= 적용 후: {cachedPlayerName}");

        cachedPlayerName ??= "다른값";
        Console.WriteLine($"두 번째 ??= 적용 후: {cachedPlayerName}");

        Console.WriteLine();
        Console.WriteLine("=== 최종 설정 ===");

        Console.WriteLine($"플레이어 이름: {cachedPlayerName}");
        Console.WriteLine($"서버 주소: {finalServer}");
        Console.WriteLine($"언어: {finalLanguage}");
        Console.WriteLine($"볼륨: {finalVolume}");
    }
}