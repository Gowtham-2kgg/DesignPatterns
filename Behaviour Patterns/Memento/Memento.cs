namespace DesignPatterns.Behaviour_Patterns.Memento
{
    public class Memento
    {
        public string State { get; set; }
    }

    public class Originator
    {
        private string _state { get; set; }

        public Originator()
        {
            _state = "Zero";
        }

        public Memento CurrentState()
        {
            var memento = new Memento();
            memento.State = _state;
            return memento;
        }

        public void RestoreMemento(Memento memento)
        {
            this._state = memento.State;
        }
    }

    
}