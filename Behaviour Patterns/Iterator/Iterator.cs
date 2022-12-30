using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behaviour_Patterns.Iterator
{
    public class Iterator
    {
        //To iterate through abstract object without revealing its inner implementation
    }

    public class Subject
    {
        private List<string> _subjects = new();
        
        public Subject()
        {
            for (var i = 0; i < 5; i++)
            {
                if (!_subjects.Contains($"Subject{i}"))
                {
                    _subjects.Add($"Subject{i}");
                }
            }
        }

        public void GetIterator()
        {
        }
    }
    public class Students
    {
        private string[] _students = new String[100];
        
        public Students()
        {
            for (var i = 0; i < 5; i++)
            {
                if (!_students.ToString().Contains($"Subject{i}"))
                {
                    _students[i]=($"Subject{i}");
                }
            }
        }

        public void GetIterator()
        {
        }
    }

    public interface IIterator
    {
        string First();
        string CurrentElement();
        bool IsLastElement();
        void Next();
    }

    public class SubjectIterator : IIterator
    {
        private List<string> _subjects = null;
        private int _index = 0;

        public SubjectIterator(List<String> subject)
        {
            _subjects = subject;
        }

        public string First()
        {
            _index = 0;
            return _subjects.ElementAt(_index);
        }

        public string CurrentElement()
        {
            return _subjects.ElementAt(_index);
        }

        public bool IsLastElement()
        {
            return _index == _subjects.Count - 1;
        }

        public void Next()
        {
            _index++;
        }
    }
    
    public class StudentIterator : IIterator
    {
        private string[] _students = null;
        private int _index = 0;
        public StudentIterator(string[] a)
        {
            _students = a;
        }

        public string First()
        {
            _index = 0;
            return _students[_index];
        }

        public string CurrentElement()
        {
            return _students[_index];
        }

        public bool IsLastElement()
        {
            return _index == _students.Length - 1;
        }

        public void Next()
        {
            _index++;
        }
    }
}