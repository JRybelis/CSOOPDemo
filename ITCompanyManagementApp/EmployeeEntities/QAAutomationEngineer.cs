namespace ITCompanyManagementApp.EmployeeEntities;

public class QAAutomationEngineer:Employee
{
    public string ProgrammingLanguage { get; set; }
    public string TestSpecialisation { get; set; }
    
    public QAAutomationEngineer(string firstName, string lastName, int taxId, string programmingLanguage, string testSpecialisation) : base(firstName, lastName, taxId)
    {
        ProgrammingLanguage = programmingLanguage;
        TestSpecialisation = testSpecialisation;
    }
}