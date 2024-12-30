using System;

namespace exemplos_chsarp;

public static class TimeZoneList
{
    public static void Run()
    {
        foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
            Console.WriteLine($"{timeZone.Id} {timeZone.BaseUtcOffset.Hours:00}:{timeZone.BaseUtcOffset.Minutes:00} {timeZone.StandardName}");
    }
}