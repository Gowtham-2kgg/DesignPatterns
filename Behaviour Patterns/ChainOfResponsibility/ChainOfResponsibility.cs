using System;

namespace DesignPatterns.Behaviour_Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibility
    {
        //Instead of sending an message to all object can send it to one and thus forming a chain this will avoid tight coupling
    }

    public enum MsgPriority
    {
        High,
        Low
    };

    public class Message
    {
        public string MessageText { get; set; }
        public MsgPriority Priority { get; set; }

        public Message(string msg, MsgPriority priority)
        {
            MessageText = msg;
            Priority = priority;
        }

    }
    public abstract class Receiver
    {
        public Receiver NextReceiver;

        public void SetNextReceiver(Receiver receiver)
        {
            NextReceiver = receiver;
        }

        public abstract void Handle(Message message);
    }

    public class EmailError:Receiver
    {
        private bool _isMsgHandled = false;
        public override void Handle(Message message)
        {
            if (message.MessageText.Contains("email"))
            {
                _isMsgHandled = true;
                Console.WriteLine("Email Issue Handled");
            }
            else
            {
                if (NextReceiver != null)
                {
                    _isMsgHandled = true;
                    NextReceiver.Handle(message);
                }
            }
        }
    }
    public class Fax:Receiver
    {
        private bool _isMsgHandled = false;

        public override void Handle(Message message)
        {
            if (message.MessageText.Contains("fax"))
            {
                _isMsgHandled = true;
                Console.WriteLine("Fax Issue Handled");
            }
            else
            {
                if (NextReceiver != null)
                {
                    _isMsgHandled = true;
                    NextReceiver.Handle(message);
                }
            }
        }
    }
    public class Unknown:Receiver
    {
        private bool _isMsgHandled = false;

        public override void Handle(Message message)
        {
            if (!message.MessageText.Contains("email")&&!message.MessageText.Contains("fax"))
            {
                _isMsgHandled = true;
                Console.WriteLine("Unknown Issue Handled");
            }
            else
            {
                if (NextReceiver != null)
                {
                    _isMsgHandled = true;
                    NextReceiver.Handle(message);
                }
            }
        }
    }
}