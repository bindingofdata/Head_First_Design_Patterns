using System;
using System.Collections.Generic;
using System.Text;

using WeatherStationLib.Interfaces;
using WeatherStationLib.Weather;

namespace WeatherStationLib.Displays
{
    public class WeatherForecast : IObserver<WeatherData>, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private readonly IObservable<WeatherData> weatherData;
        private readonly IDisposable unsubscriber;

        public WeatherForecast(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            unsubscriber = this.weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.Write("Forecast: ");

            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same...");
            else
                Console.WriteLine("Watch out for cooler, rainy weather");
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
            lastPressure = currentPressure;
            currentPressure = value.Pressure;
            Display();
        }
    }
}
