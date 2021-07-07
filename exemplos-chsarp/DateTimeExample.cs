using System;

namespace exemplos_chsarp
{
    public static class DateTimeExample
    {
        public static void Run()
        {
            // Data inicial dia 1/1/0001
            var dataHoraDefaultVazia = new DateTime();

            // com base com o timezone do computador
            var dataHoraAtual = DateTime.Now;

            // em UTC
            var dataHoraAtualUTC = DateTime.UtcNow;

            // hora zerada
            var DataAtual = DateTime.Today;

            /* constante com o valor inicial do Unix Epoch. Data inicial de tudo
            UTC, 1º de janeiro de 1970. */
            var unixEpoch = DateTime.UnixEpoch;
        }
    }
}