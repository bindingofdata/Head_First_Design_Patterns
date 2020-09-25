using System;
using System.Collections.Generic;
using System.Text;

using WeatherStationLib.Interfaces;
using WeatherStationLib.Weather;

namespace WeatherStationLib.Displays
{
    public class HeatIndex : IObserver<WeatherData>, IDisplayElement
    {
        private float heatIndex;
        private readonly IObservable<WeatherData> weatherData;
        private readonly IDisposable unsubscriber;

        public HeatIndex(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            unsubscriber = this.weatherData.Subscribe(this);
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            return (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh))
                + (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583
                * (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh))
                + (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh))
                + 0.000000000843296 * (t * t * rh * rh * rh))
                - (0.0000000000481975 * (t * t * t * rh * rh * rh)));
        }

        public void Display()
        {
            Console.WriteLine("Heat index is " + heatIndex);
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
            heatIndex = ComputeHeatIndex(value.Temperature, value.Humidity);
            Display();
        }
    }
}
