namespace OCPLibrary
{
    public class CeoAccounts:IAccounts
    {
        public EmployeeModel Create(IPersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";
            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
