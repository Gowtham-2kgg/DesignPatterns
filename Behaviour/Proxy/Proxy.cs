using System;
using System.Collections.Generic;

namespace DesignPatterns.Behaviour.Proxy
{
    public class Proxy
    {
        //object act as a surrogate to access another object
        //types:remote,protection,virtual and smart reference proxy
        //used in wcf
        //if the object creation is costly then using this is advisable 
        //if there is any security concerns its advisable
        //cons:hidden object, bad performance and additional layer
    }

    public interface IHomeWork
    {
        void DoSomething();
    }

    public class Worker : IHomeWork
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing homework");
        }
    }

    public class ProxyUsed:IHomeWork
    {
        private Worker _worker;

        public ProxyUsed()
        {
            _worker = new Worker();
        }

        public void DoSomething()
        {
            if (_worker == null)
            {
                _worker = new Worker();
            }
            _worker.DoSomething();
        }
    }

    public class ProtectionProxy:IHomeWork
    {
        private List<string> _admins = new List<string>{"gowtham","gokul","bg","gg"};
        private string _user;
        private Worker _worker;

        public ProtectionProxy(string user)
        {
            this._user = user;
            if (_admins.Contains(user))
            {
                _worker = new Worker();
            }
        }

        public void DoSomething()
        {
            if (_worker == null)
            {
                _worker = new Worker();
                _worker.DoSomething();
            }
            _worker.DoSomething();//change do something if needs to diff between admin and user
        }
    }
}