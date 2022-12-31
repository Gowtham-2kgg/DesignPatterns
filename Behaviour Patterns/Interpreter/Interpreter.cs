namespace DesignPatterns.Behaviour_Patterns.Interpreter
{
    public class Interpreter
    {
        //Changing string from on form to another
    }

    public class InputString
    {
        private string _input { get; set; }

        public InputString(string input)
        {
            _input = input;
        }

        public string GetInput()
        {
            return _input;
        }
    }

    public abstract class InterpreterClass
    {
        public abstract string Translate(string m);

        public string GetValue(string input)
        {
            switch (input)
            {
                case "1":
                    return "one";
                case "2":
                    return "two";
                case "3":
                    return "three";
                case "4":
                    return "four";
                case "5":
                    return "five";
                case "6":
                    return "six";
                case "7":
                    return "seven";
                case "8":
                    return "eight";
                case "9":
                    return "nine";
                case "0":
                    return "zero";
                default:
                    return "*";
            }
        }
    }
    public class Hundreds : InterpreterClass
    {
        public override string Translate(string input)
        {
            return GetValue(input.Substring(input.Length - 3))+"Hui=ndreds Digit";

        }
    }
    public class Tens : InterpreterClass
    {
        public override string Translate(string input)
        {
            return GetValue(input.Substring(input.Length - 2))+"Tens Digit";

        }
    }
    public class Unit : InterpreterClass
    {
        public override string Translate(string input)
        {
            return GetValue(input.Substring(input.Length - 1))+"Unit Digit";
        }
    }
}
