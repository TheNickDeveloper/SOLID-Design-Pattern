namespace DemoLibrary
{
    public static class InstanceSetter
    {
        public static IPerson SetPersonInstance()
        {
            return new Person();
        }
        public static IMessager SetEmailerInstance()
        {
            return new Emailer();
        }
        public static ILogger SetLoggerInstance()
        {
            return new Logger();
        }

        public static IMessager SetPhoneTextInstance()
        {
            return new PhoneText();
        }

        public static IChore SetChoreInstance(IMessager messager, ILogger logger)
        {
            return new Chore(messager, logger);
        }
    }
}
