using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoupledGUIProject
{
    public class WeatherData : ISubject
    {

        private readonly List<IObserver> _observers = new List<IObserver>();

        public float Temp { get; set; }
        public float Humidity { get; set; }
        public int Pressure { get; set; }

        public void RegisterObserver(IObserver o)
        {
            if (!_observers.Contains(o))
            {
                _observers.Add(o);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers.Contains(o))
            {
                _observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in  _observers)
            {
                observer.Update(Temp, Humidity, Pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}
