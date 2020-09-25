using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationLib.Weather
{
    public class WeatherReporter : IObservable<WeatherData>
    {
        private readonly WeatherData weatherData;
        private readonly List<IObserver<WeatherData>> observers;

        public WeatherReporter()
        {
            observers = new List<IObserver<WeatherData>>();
            weatherData = new WeatherData();
        }

        public void NotifyObservers()
        {
            if (observers.Count > 0)
                foreach (IObserver<WeatherData> observer in observers) { observer.OnNext(weatherData); }
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (observer != null)
            {
                observers.Add(observer);
                return new Unsubscriber(observers, observer);
            }
            else
            {
                return new Unsubscriber(observers, null);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        // This method is used to update the data for this example.
        // In practice, this data would likely be pushed/pulled from a server.
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            weatherData.Temperature = temperature;
            weatherData.Humidity = humidity;
            weatherData.Pressure = pressure;
            MeasurementsChanged();
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<WeatherData>> observers;
            private readonly IObserver<WeatherData> observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
    }
}
