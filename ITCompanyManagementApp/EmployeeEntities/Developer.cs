namespace ITCompanyManagementApp.EmployeeEntities;

public class Developer:Employee, IDemonstrator
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string firstName, string lastName, int taxId, string programmingLanguage) : base(firstName, lastName, taxId)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override string ProduceWorkResults()
    {
        return "I have implemented a method";
    }

    public override string ToString()
    {
        return base.ToString() + ProgrammingLanguage;
    }

    public void MakeDemo()
    {
        //demonstrate project
    }
}