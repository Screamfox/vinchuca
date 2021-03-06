
using System;
using Vinchuca.Utils;

namespace Vinchuca.Workers
{
    public interface IWorker
    {
        void Queue(Action action);
        void Start();
        void Stop();
    }

    public interface IWorkScheduler
    {
        void QueueForever(Action action, TimeSpan interval);
        void QueueOneTime(Action action, TimeSpan interval);
        void Start();
        void Stop();
    }
}