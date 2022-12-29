using System;

namespace DesignPatterns.Behaviour_Patterns.Template
{
    public class Template
    {
        //used when there is a class which follows certain algorithm
        //that can't be altered by subclass but can be refined
        //this follows SOLID principles and so it provides a template with algo.
        public void Example()
        {
            var _computerScience = new ComputerScience();
            var _electronics = new Electronics();
            _electronics.AllCourses();
            _computerScience.AllCourses();
            //here additionalCourse is changeable but not allCourses()
    }
    }

    public abstract class EngineerTemplate
    {
        private void BasicMath()
        {
            Console.WriteLine("Basic Maths");
        }
        private void SoftSkills()
        {
            Console.WriteLine("Soft Skills");
        }

        public abstract void AdditionalCourse();

        public void AllCourses()
        {
            BasicMath();
            SoftSkills();
            AdditionalCourse();
        }
    }
    public class ComputerScience : EngineerTemplate
    {
        public override void AdditionalCourse()
        {
            Console.WriteLine("Programming");

        }
    }

    public class Electronics : EngineerTemplate
    {
        public override void AdditionalCourse()
        {
            Console.WriteLine("Electronics");

        }
    }
}