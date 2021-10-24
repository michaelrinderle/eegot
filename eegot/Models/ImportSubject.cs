using eegot.Interface;
using System.Collections.Generic;
using System.Linq;

namespace eegot.Models
{
    public class ImportSubject : ISubject
    {
        private HashSet<IObserver> _observers = new HashSet<IObserver>();

        private string _Path { get; set; }
        public string Path
        {
            get => _Path;
            set
            {
                _Path = value;
                Notify();
            }
        }

        public void Notify()
        {
            _observers.ToList().ForEach(o => o.passString(Path));
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
