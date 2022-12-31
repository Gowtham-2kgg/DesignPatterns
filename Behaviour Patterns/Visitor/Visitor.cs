using System.Collections.Generic;

namespace DesignPatterns.Behaviour_Patterns.Visitor
{
    public class Visitor
    {
        //Performing operation without changing class of object where it belongs
        //perfect example for open-close principal
    }

    public abstract class Number
    {
        private int _value;
        private string _type;

        public Number(int value, string type)
        {
            _value = value;
            _type = type;
        }

        public int GetValue()
        {
            return _value;
        }

        public string GetType()
        {
            return _type;
        }

        public abstract void AcceptVisitor(IVisitor visitor);
    }

    public interface IVisitor
    {
        void AcceptBigNumber(Number number);
        void AcceptSmallNumber(Number number);
    }

    public class Visit : IVisitor
    {
        public void AcceptBigNumber(Number number)
        {
            throw new System.NotImplementedException();
        }

        public void AcceptSmallNumber(Number number)
        {
            throw new System.NotImplementedException();
        }
    }


    public class SmallNumber : Number
    {
        public SmallNumber(int value, string type) : base(value, type)
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.AcceptSmallNumber(this);
        }
    }

    public class BigNumber : Number
    {
        public BigNumber(int value, string type) : base(value, type)
        {
        }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.AcceptBigNumber(this);
        }
    }

    public class NumberCollection
    {
        public List<Number> List = new List<Number>();

        public void AddSmallNumber(Number number)
        {
            List.Add(number);
        }
        public void AddBigNumber(Number number)
        {
            List.Add(number);
        }
        public void RemoveSmallNumber(Number number)
        {
            List.Remove(number);
        }
        public void RemoveBigNumber(Number number)
        {
            List.Remove(number);
            
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var n in List)
            {
                n.AcceptVisitor(visitor);
            }
        }
    }

}