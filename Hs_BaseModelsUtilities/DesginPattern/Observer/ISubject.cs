﻿namespace Hs_BaseModelsUtilities.DesginPattern.Observer
{

    public interface ISubject<T>
    {
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
        void Notify(T data);
    }


}
