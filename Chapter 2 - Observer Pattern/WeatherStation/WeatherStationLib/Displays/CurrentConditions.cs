using System;
using System.Collections.Generic;
using System.Text;

using WeatherStationLib.Interfaces;
using WeatherStationLib.Weather;

namespace WeatherStationLib.Displays
{
    public class CurrentConditions : IObserver<WeatherData>, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private readonly IObservable<WeatherData> weatherData;
        private readonly IDisposable unsubscriber;

        public CurrentConditions(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            unsubscriber = this.weatherData.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity.");
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
            temperature = value.Temperature;
            humidity = value.Humidity;
            Display();
        }
    }
}
