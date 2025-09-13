using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.DesginPattern.Observer
{
   
    public class SubjectBase<T> : ISubject<T>
    {
        private readonly List<IObserver<T>> _observers = new();
        public void Attach(IObserver<T> observer) => _observers.Add(observer);
        public void Detach(IObserver<T> observer) => _observers.Remove(observer);
        public void Notify(T data)
        {
            foreach (var obs in _observers)
                obs.Update(data);
        }
    }


}
