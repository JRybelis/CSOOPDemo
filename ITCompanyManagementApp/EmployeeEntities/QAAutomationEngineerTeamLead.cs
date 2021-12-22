namespace ITCompanyManagementApp.EmployeeEntities;

public class QAAutomationEngineerTeamLead: QAAutomationEngineer, ITaskAssigner
{
    public QAAutomationEngineerTeamLead(string firstName, string lastName, int taxId, string programmingLanguage, string testSpecialisation) : base(firstName, lastName, taxId, programmingLanguage, testSpecialisation)
    {
        ProgrammingLanguage = programmingLanguage;
        TestSpecialisation = testSpecialisation;
    }

    public void AssignTask(string Task)
    {
        //do something
    }
}