using System;

namespace exemplos_chsarp
{
    public static class DateTimeOffsetExample
    {
        public static void Run()
        {
            // Data inicial dia 1/1/0001
            var dataHoraDefaultVazia = new DateTimeOffset();

            // com base com o timezone do computador
            var dataHoraAtual = DateTimeOffset.Now;

            // em UTC
            var dataHoraAtualUTC = DateTimeOffset.UtcNow;

            /* 
                Forma errada de trabalhar com timezone 
                O problema aqui acontece pois eu não estou
                obtendo a data usando o UTC(timezone zero)
            */
            var dataAtual = DateTimeOffset.Now;
            var dataAtualOffset6 = new DateTimeOffset(dataAtual.DateTime, new TimeSpan(+6, 0, 0));

            var dataAtualUTC = DateTimeOffset.UtcNow.DateTime;
            var dataAtualOffset8 = new DateTimeOffset(dataAtualUTC, new TimeSpan(+8, 0, 0));
            var offset = dataAtualOffset8.Offset;
        }
    }
}