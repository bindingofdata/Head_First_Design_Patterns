using System;
using System.Collections.Generic;
using System.Text;

using WeatherStationLib.Interfaces;
using WeatherStationLib.Weather;

namespace WeatherStationLib.Displays
{
    public class WeatherStatistics : IObserver<WeatherData>, IDisplayElement
    {
        private float maxTemp;
        private float minTemp = 200;
        private float tempSum;
        private int numReadings;
        private readonly IObservable<WeatherData> weatherData;
        private readonly IDisposable unsubscriber;

        public WeatherStatistics(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            unsubscriber = this.weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " +
                (tempSum / numReadings) + $"/{maxTemp}/{minTemp}");
        }

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            tempSum += value.Temperature;
            numReadings++;

            if (value.Temperature > maxTemp)
                maxTemp = value.Temperature;

            if (value.Temperature < minTemp)
                minTemp = value.Temperature;

            Display();
        }
    }
}
