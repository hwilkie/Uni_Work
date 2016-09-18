using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoupledGUIProject
{
    public class CurrentConditions : IObserver , ISubject
    {
        private ISubject _subject;
        private List<IObserver> _observers = new List<IObserver>();
        private float _temp { get; set; }
        private float _humidity { get; set; }
        private int _pressure { get; set; }

        public CurrentConditions(ISubject s)
        {
            _subject = s;
        }

        #region observer Code
        public void Update(float temp, float humidity, int pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;

            NotifyObservers();
        }

        public void Register()
        {
                _subject.RegisterObserver(this);   
        }

        public void Remove()
        {
            if (_observers.Contains(this))
            {
                _subject.RemoveObserver(this);
            }
        }
        #endregion

        #region Subject Code
        public void RegisterObserver(IObserver o)
        {
            if (!_observers.Contains(o))
            {
                _subject.RegisterObserver(o);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers.Contains(o))
            {
                _subject.RemoveObserver(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }
        #endregion
    }
}
