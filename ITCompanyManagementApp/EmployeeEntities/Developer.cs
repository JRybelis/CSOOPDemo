namespace ITCompanyManagementApp.EmployeeEntities;

public class Developer:Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string firstName, string lastName, int taxId, string programmingLanguage) : base(firstName, lastName, taxId)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public void DoCoding()
    {
        Console.WriteLine("Coding now...");
    }


    public override string ProduceWorkResults()
    {
        return "I have implemented a method";
    }

    public override string ToString()
    {
        return base.ToString() + ProgrammingLanguage;
    }
}