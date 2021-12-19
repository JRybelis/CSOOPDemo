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
    
}