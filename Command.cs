namespace CommandPattern.BasicExample
{
    public abstract class Command
    {
        protected Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }
}