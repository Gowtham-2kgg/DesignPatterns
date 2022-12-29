using System;

namespace DesignPatterns.Behaviour_Patterns.Command
{
    public class Command
    {
        //used in giving control to change object by changing even log through a controller passing command that are undoable
        public void Example()
        {
            IControl start = new Starting(new Game());
            IControl end = new Ending(new Game());

            Controller controller1 = new Controller(start);
            controller1.Execute();
            controller1.Undo();
            
            Controller controllerEnd = new Controller(end);
            controllerEnd.Execute();
            controllerEnd.Undo();
        }
    }

    public class Game
    {
        public void Start()
        {
            Console.WriteLine("Start");
        }
        public void Run()
        {
            Console.WriteLine("Run");

        }
        public void End()
        {            
            Console.WriteLine("End");
        }
    }
    public interface IControl
    {
        void Execute();
        void Undo();
    }

    public class Starting : IControl
    {
        private Game _game;

        public Starting(Game game)
        {
            _game = game;
        }

        public void Execute()
        {
            _game.Start();
            _game.Run();
        }

        public void Undo()
        {
            _game.End();
        }
    }
    public class Ending : IControl
    {
        private Game _game;

        public Ending(Game game)
        {
            _game = game;
        }

        public void Undo()
        {
            _game.Start();
            _game.Run();
        }

        public void Execute()
        {
            _game.End();
        }
    }

    public class Controller
    {
        private IControl _control, _lastControl;

        public Controller(IControl control)
        {
            _control = control;
        }

        public void Execute()
        {
            _control.Execute();
            _lastControl = _control;
        }

        public void Undo()
        {
            _lastControl.Undo();
        }
    }
}