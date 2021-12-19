namespace ITCompanyManagementApp.EmployeeEntities;

public class QAEngineer:Employee
{
    public string TestSpecialisation { get; set; }
    
    public QAEngineer(string firstName, string lastName, int taxId, string testSpecialisation) : base(firstName, lastName, taxId)
    {
        TestSpecialisation = testSpecialisation;
    }
}