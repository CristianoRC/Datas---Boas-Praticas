using System;

namespace Examples;

public static class TimeZoneExample
{
    public static void Run()
    {
        var data = DateTime.Parse("2028-02-28 15:35:00");
        var saoPaulo = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var campoGrade = TimeZoneInfo.FindSystemTimeZoneById("America/Campo_Grande");
        var rioBranco = TimeZoneInfo.FindSystemTimeZoneById("America/Rio_Branco");


        var dataSaoPauloCampoGrande = TimeZoneInfo.ConvertTime(data, saoPaulo, campoGrade);
        var dataSaoPauloRioBranco = TimeZoneInfo.ConvertTime(data, saoPaulo, rioBranco);

    }
}