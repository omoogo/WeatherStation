using System;

namespace WeatherStation.Display
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humdity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions: " + _temperature + "F degrees and " + _humdity + "% humdity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humdity = humidity;
            Display();
        }
    }
}