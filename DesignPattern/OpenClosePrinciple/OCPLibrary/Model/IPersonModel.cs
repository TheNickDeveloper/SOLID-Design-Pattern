namespace OCPLibrary
{
    public interface IPersonModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}