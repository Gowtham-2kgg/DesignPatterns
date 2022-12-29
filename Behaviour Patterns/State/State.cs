using System;
using System.Runtime.InteropServices;

namespace DesignPatterns.Behaviour_Patterns.State
{
    public class State
    {
        //behaviour of object changes according to the state
        public void Example()
        {
        }
    }
    //lets take an example of TV remote
    public interface IState
    {
        void OnState(Tv tv);
        void OffState(Tv tv);
        void MuteState(Tv tv);
    }

    public class Tv
    {
        private IState _state;
        public IState State
        {
            get { return _state; }
            set { _state = value; }

        }

        public Tv()
        {
            this._state = new Off();
        }
        public void OnState(Tv tv)
        {
            Console.WriteLine("ON");
            _state.OnState(this);
            
        }

        public void OffState(Tv tv)
        {
            Console.WriteLine("Off");
            _state.OffState(this);

        }

        public void MuteState(Tv tv)
        {
            Console.WriteLine("Mute");
            _state.MuteState(this);

        }
        
    }
    
    public class On : IState
    {
        public void OnState(Tv tv)
        {
            Console.WriteLine("Off/Mute to ON");
            tv.State = new On();
        }

        public void OffState(Tv tv)
        {
            Console.WriteLine("On to Off");

        }

        public void MuteState(Tv tv)
        {
            Console.WriteLine("On to Mute");

        }
    }
    public class Off : IState
    {
        public void OnState(Tv tv)
        {
            Console.WriteLine("Off to ON");

        }

        public void OffState(Tv tv)
        {
            Console.WriteLine("to ON");
            tv.State = new Off();
        }

        public void MuteState(Tv tv)
        {
            Console.WriteLine("Off to mute not possible");

        }
    }
    public class Mute : IState
    {
        public void OnState(Tv tv)
        {
         Console.WriteLine("Mute to ON");
        }

        public void OffState(Tv tv)
        {
            Console.WriteLine("Mute to Off");
        }

        public void MuteState(Tv tv)
        {
            Console.WriteLine("Mute state");
            tv.State = new Mute();
        }
    }
}