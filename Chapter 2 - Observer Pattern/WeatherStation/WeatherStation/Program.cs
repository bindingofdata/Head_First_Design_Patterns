using System;

using WeatherStationLib.Displays;
using WeatherStationLib.Weather;

namespace WeatherStation
{
    internal static class Program
    {
        private static void Main()
        {
            WeatherReporter weatherReporter = new WeatherReporter();

            CurrentConditions currentConditions = new CurrentConditions(weatherReporter);
            WeatherStatistics weatherStatistics = new WeatherStatistics(weatherReporter);
            WeatherForecast weatherForecast = new WeatherForecast(weatherReporter);
            HeatIndex heatIndex = new HeatIndex(weatherReporter);

            weatherReporter.SetMeasurements(80, 65, 30.4f);
            weatherReporter.SetMeasurements(82, 70, 29.2f);
            weatherReporter.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
