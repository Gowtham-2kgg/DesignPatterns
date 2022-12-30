using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace DesignPatterns.Behaviour_Patterns.Mediator
{
    public class Mediator
    {
        //Object which defined how set of objects interact by encapsulating it
        //An object set as an mediate between communication of objects
    }

    public interface IMediator
    {
        void AddMediator(IMediator mediator);
        void Send(IMediator from, IMediator to, string msg);
        void Receive(IMediator from, string msg);
        void Display();
    }

    public class Mediators : IMediator
    {
        private List<IMediator> _list = new List<IMediator>();
        public void AddMediator(IMediator mediator)
        {
            if (!_list.Contains(mediator))
            {
                _list.Add(mediator);
            }
        }

        public void Send(IMediator from, IMediator to, string msg)
        {
            if (_list.Contains(from) && _list.Contains(to))
            {
                Console.WriteLine("message is sending");
                Receive(from,msg);
            }
            else
            {
                Console.WriteLine("error in sending msg");

            }
        }

        public void Receive(IMediator from, string msg)
        {
            Console.WriteLine($"from {from} u received {msg}");
        }

        public void Display()
        {
            foreach (var mediator in _list)
            {
                Console.WriteLine(mediator);
            }
        }
    }

    public abstract class Communication
    {
        public string Name { get; set; }
        private IMediator _mediator { get; set; }

        public Communication(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(IMediator to, string msg)
        {
            _mediator.Send(_mediator,to,msg);
        }

        public void Receive(IMediator from, string msg)
        {
            _mediator.Receive(from,msg);
        }
    }
    public class Stranger : Communication
    {
        public Stranger(IMediator mediator) : base(mediator)
        {
        }
    }

    public class Friend : Communication
    {
        public Friend(IMediator mediator) : base(mediator)
        {
        }
    }
}