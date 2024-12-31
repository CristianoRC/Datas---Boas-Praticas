using System;
using ConsoleTables;

namespace exemplos_chsarp;

public static class TimeZoneList
{
    public static void Run()
    {
        var table = new ConsoleTable("ID da Zona", "UTC Offset", "Nome Padrão");
        
        foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
        {
            table.AddRow(
                timeZone.Id,
                $"{timeZone.BaseUtcOffset.Hours:00}:{timeZone.BaseUtcOffset.Minutes:00}",
                timeZone.StandardName
            );
        }

        table.Configure(options => options.EnableCount = true)
             .Write(Format.MarkDown);
    }
}