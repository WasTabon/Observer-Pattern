using System;

public interface IObserver : IDisposable
{
    void AddObservable(IObservable observable);
}