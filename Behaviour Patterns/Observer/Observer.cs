using System;
using System.Collections.Generic;

namespace DesignPatterns.Behaviour_Patterns.Observer
{
    public class Observer
    {
        //Used in Pub-sub -- publisher-subscriber
        //when a object is updater all its observer will get notified
        //many observers will observe object
    }

    public interface IObserver
    {
        void Update(ICelebrity celebrity);
    }

    public class Observer1 : IObserver
    {
        private ICelebrity _celebrity = null;
        public void Update(ICelebrity celebrity)
        {
            _celebrity = celebrity;
            Console.WriteLine("celebrity got updated Observer 1 is notified");
        }
    }
    public class Observer2 : IObserver
    {
        private ICelebrity _celebrity = null;
        public void Update(ICelebrity celebrity)
        {
            _celebrity = celebrity;
            Console.WriteLine("celebrity got updated Observer 2 is notified");

        }
    }
    public class Observer3 : IObserver
    {
        private ICelebrity _celebrity = null;
        public void Update(ICelebrity celebrity)
        {
            _celebrity = celebrity;
            Console.WriteLine("celebrity got updated Observer 3 is notified");

        }
    }

    public interface ICelebrity
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyEveryObserver();
    }

    public class Celebrity : ICelebrity
    {
        private List<IObserver> _observer = null;
        public void AddObserver(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observer.Contains(observer))
            {
                _observer.Remove(observer);
            }
        }

        public void NotifyEveryObserver()
        {
            foreach (var observ in _observer)
            {
                observ.Update(this);
            }
        }
    }
}