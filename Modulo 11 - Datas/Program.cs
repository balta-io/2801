using System;

namespace DatesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var pt = new System.Globalization.CultureInfo("pt-BR");
            // var de = new System.Globalization.CultureInfo("de-DE");
            // var atual = System.Globalization.CultureInfo.CurrentCulture;

            // Console.WriteLine(DateTime.Now.ToString("D", atual));
            // Console.WriteLine(DateTime.Now.ToString("d", atual));

            // Console.WriteLine(DateTime.Now.ToString("D", pt));
            // Console.WriteLine(DateTime.Now.ToString("d", pt));

            // Console.WriteLine(DateTime.Now.ToString("D", de));
            // Console.WriteLine(DateTime.Now.ToString("d", de));

            // var dateTime = DateTime.UtcNow;
            // Console.WriteLine(dateTime);
            // Console.WriteLine(dateTime.ToLocalTime());
            // Console.WriteLine("_________");

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.Write(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            // var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);
            // Console.WriteLine(horaAtual);


            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            //     Console.WriteLine("_________");
            // }

            // var brazilTime = TimeZoneInfo.FindSystemTimeZoneById("");


            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            // var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            // Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            // Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}
