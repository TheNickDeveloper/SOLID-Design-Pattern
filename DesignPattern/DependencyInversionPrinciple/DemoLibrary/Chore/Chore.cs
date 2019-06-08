namespace DemoLibrary
{
    public class Chore : IChore
    {
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        private IMessager _emailer;
        private ILogger _logger;

        public Chore(IMessager emailer, ILogger logger)
        {
            _emailer = emailer;
            _logger = logger;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");
            _emailer.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
